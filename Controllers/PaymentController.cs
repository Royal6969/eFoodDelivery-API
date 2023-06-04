using eFoodDelivery_API.DbContexts;
using eFoodDelivery_API.Entities;
using eFoodDelivery_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Stripe;
using Microsoft.AspNetCore.Authorization;

namespace eFoodDelivery_API.Controllers
{
    // [Route("api/[controller]")] // instead a dynamic route, if I change the controller name, the route does not get updated
    [Route("api/Payment")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        // dependencies to inject
        protected ApiResponse _apiResponse;
        private readonly IConfiguration _configuration; // with IConfiguration we will be able to access to our appsettings.json and use our Stripe API Secret Key defined there
        private readonly ApplicationDbContext _dbContext;
        private readonly ILogger<PaymentController> _logger; // for App Service logging to Kudu console and container in storage account 

        // dependency injection
        public PaymentController(IConfiguration configuration, ApplicationDbContext dbContext, ILogger<PaymentController> logger)
        {
            _configuration = configuration;
            _dbContext = dbContext;
            _apiResponse = new ApiResponse();
            _logger = logger;
        }



        /// <summary>
        /// 1º endpoint to create a PaymentIntent in Stripe
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>BadRequest or Ok with apiResponse</returns>
        // when we're making a payment, we will require the user id because based on that user id, we will generate a payment intent
        // because from their shopping cart we need to find out what is their order total price
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<ApiResponse>> OrderPayment(string userId)
        {
            // first we need to retrieve their shopping cart
            Cart cartRetrievedFromDb = _dbContext.CartDbSet
                // we will include the cart items as well as the product, because we need to calculate the order total price
                .Include(cartItems => cartItems.CartItemsList)
                .ThenInclude(product => product.Product)
                .FirstOrDefault(user => user.UserId == userId)
            ;

            if (cartRetrievedFromDb == null || cartRetrievedFromDb.CartItemsList == null || cartRetrievedFromDb.CartItemsList.Count() == 0)
            {
                _apiResponse.Success = false;
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;

                return BadRequest(_apiResponse);
            }

            /********************************** Create Payment Intent for Stripe ************************************/
            // so the last piece that remains here is creating the payment intent based on the user id and their shopping cart total price
            // the final piece of the puzzle is to create a payment intent for Stripe
            // to start, just copy and paste here the dummy code from the Stripe API documentation
            
            // for the Stripe configuration, we will add the using statement of Stripe and we use the secret key that we have in _configuration dependency
            StripeConfiguration.ApiKey = _configuration["StripeSecrets:StripeKey"];

            // then, we need the cart total price
            cartRetrievedFromDb.Total = cartRetrievedFromDb.CartItemsList.Sum(cartItem => cartItem.Quantity * cartItem.Product.Price);

            PaymentIntentCreateOptions paymentIntentCreateOptions = new PaymentIntentCreateOptions
            {
                // the amount here is an integer and a long field, so we have to multiply it by 100 to make it long
                Amount = (int)(cartRetrievedFromDb.Total * 100), // basically we need the value in cents and not in euros
                Currency = "EUR",
            /*
                AutomaticPaymentMethods = new PaymentIntentAutomaticPaymentMethodsOptions
                {
                    Enabled = true,
                },
            */
                PaymentMethodTypes = new List<string>
                {
                    "card"
                }
            };

            PaymentIntentService paymentIntentService = new PaymentIntentService();
            
            // let's wait for the response here
            PaymentIntent paymentIntentResponse = paymentIntentService.Create(paymentIntentCreateOptions);  // if you examen the type of var service, note it's of the type payment intent

            // finally, in our shopping cart, we have the Stripe payment intended
            cartRetrievedFromDb.PaymentAttempId = paymentIntentResponse.Id; // because that is the payment intent itself

            // and we also added a not mapped property for client secret
            cartRetrievedFromDb.ClientSecret = paymentIntentResponse.ClientSecret; // this client secret is what we'll use to make the actual payment later
            /********************************************************************************************************/

            _apiResponse.Result = cartRetrievedFromDb;
            _apiResponse.StatusCode = HttpStatusCode.OK;
            _logger.LogInformation("Ha creado un intento de pago el usuario con id: " + userId);
            return Ok(_apiResponse);
        }
    }
}