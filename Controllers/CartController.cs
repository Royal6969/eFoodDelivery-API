
using eFoodDelivery_API.DbContexts;
using eFoodDelivery_API.Entities;
using eFoodDelivery_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace eFoodDelivery_API.Controllers
{
    // [Route("api/[controller]")] // instead a dynamic route, if I change the controller name, the route does not get updated
    [Route("api/Cart")]
    [ApiController]
    public class CartController : ControllerBase
    {
        // dependencies to inject
        private readonly ApplicationDbContext _dbContext;
        protected ApiResponse _apiResponse;

        // dependency injection
        public CartController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _apiResponse = new ApiResponse();
        }


        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetCart(string userId)
        {
            try
            {
                if (userId == null) // we can also say ... if (string.IsNullOrEmpty(userId))
                {
                    _apiResponse.Success = false;
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;

                    return BadRequest(_apiResponse);
                }

                // if the userId is not null, then we want to retrieve the cart
                Cart cartRetrievedFromDb = _dbContext.CartDbSet
                    // we also want to include cart items
                    .Include(cart => cart.CartItemsList)
                    // including the product, if the user wants to display what is the product name, they can do it
                    // but we have to use ThenInclude() this time because inside cart we only have CartItemsList,
                    // and in CartItem we want to include the Product... so it is the parent, child and the grandchild
                    // so if there were two things that we want to include in cart, then we can use another Include() statement here and add that
                    // but we want to include something that is inside the CartItemList
                    .ThenInclude(product => product.Product)
                    // we dont't have to pass anything here because cart is always one per userId, but in any case, let's write the condition
                    .FirstOrDefault(user => user.UserId == userId)
                ;

                // calculate the total amount of the cart
                if (cartRetrievedFromDb.CartItemsList != null && cartRetrievedFromDb.CartItemsList.Count() > 0)
                    cartRetrievedFromDb.Total = cartRetrievedFromDb.CartItemsList.Sum(cart => cart.Quantity * cart.Product.Price);

                _apiResponse.Result = cartRetrievedFromDb;      // once we have the cart, we will assign that to the result here
                _apiResponse.StatusCode = HttpStatusCode.OK;    // set the status Ok and return the Ok with the api response

                return Ok(_apiResponse);
            } 
            catch (Exception ex)
            {
                _apiResponse.Success = false;
                _apiResponse.ErrorsList = new List<string> { ex.Message };
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
            }

            return _apiResponse;
        }


        // we need a userId to find out which user's shopping cart are we working with
        // then we want to find out the productId that user wants to either add to the shopping cart update or remove
        // finally we need a counter by which the product needs to be updated
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> AddOrUpdateCartItem(string userId, int productId, int updateQuantity)
        {
            ////////////////////////////////////////// Cart Rules /////////////////////////////////////////////
            // Shopping cart will have one entry per user id, even if a user has many items in cart.
            // Cart items will have all the items in shopping cart for a user
            // updatequantityby will have count by with an items quantity needs to be updated
            // if it is -1 that means we have lower a count if it is 5 it means we have to add 5 count to existing count.
            // if updatequantityby by is 0, item will be removed
            //
            ////////////////////////////////////// Possibilities to handle /////////////////////////////////////
            // 1. user adds a new item to a new shopping cart for the first time
            // 2. user adds a new item to an existing shopping cart (user alredy has a cart with few items, but he is adding a new item to his existing cart)
            // 3. user updates an existing item count
            // 4. user removes an existing item
            ///////////////////////////////////////////////////////////////////////////////////////////////////

            // first thing that we have to do is we have to retrieve a shopping cart based on the userId if it exists
            // but when we control the possibility 2, we need to make sure that the ID that this cartItem belongs to the same user
            // so what we can do is when we're populating the cart, we can also populate the cart items
            Cart cart = _dbContext.CartDbSet
                .Include(navProperty => navProperty.CartItemsList)
                .FirstOrDefault(user => user.UserId == userId);
            // we can also retrieve the product based on the ID that we receive as parameter
            Product product = _dbContext.ProductsDbSet.FirstOrDefault(product => product.Id == productId);

            if (product == null)
            {
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                _apiResponse.Success = false;

                return BadRequest(_apiResponse);
            }

            // possibility 1 --> user adds a new item to a new shopping cart for the first time
            if (cart == null && updateQuantity > 0)
            {
                // create a cart and add the cart item
                Cart newCart = new Cart();
                newCart.UserId = userId;

                // add the new cart to db
                _dbContext.CartDbSet.Add(newCart);
                _dbContext.SaveChanges();

                CartItem cartItem = new CartItem();
                cartItem.ProductId = productId;
                cartItem.Quantity = updateQuantity;
                cartItem.CartId = newCart.Id;
                // when we're working with FK, the product is a navigation property, so I have to set that to be null,
                // because if I don't do that, then it will try to create a new Product, and eg it will fail creating the product image as null...
                cartItem.Product = null;

                // add the cartItem to db
                _dbContext.CartItemsDbSet.Add(cartItem);
                _dbContext.SaveChanges();
            }
            // possibility 2 --> user adds a new item to an existing shopping cart
            else
            {
                CartItem cartItemsCarried = cart.CartItemsList.FirstOrDefault(cartItem => cartItem.ProductId == productId);
                
                if (cartItemsCarried == null)
                {
                    // it means that the current cart doesn't exists...
                    CartItem newCartItem = new CartItem();
                    newCartItem.ProductId = productId;
                    newCartItem.Quantity = updateQuantity;
                    newCartItem.CartId = cart.Id; // ... but we alredy hace a cart instance created and we can use it instead create a new cart
                    newCartItem.Product = null;

                    // add newCartItems to db
                    _dbContext.CartItemsDbSet.Add(newCartItem);
                    _dbContext.SaveChanges();
                }
                else
                {
                    // it means that the cart item alredy exists in the current cart and we have to update the quantity
                    int newQuantity = cartItemsCarried.Quantity + updateQuantity;

                    // if updateQuantity == 0 or newQuantity <= 0, then we have to remove the cart items
                    // becasue eg if they have -10 updateQuantity and the cartItemsCarried are only 3, we don't want to display -7
                    if (updateQuantity == 0 || newQuantity <= 0)
                    {
                        // remove cart item from the cart and if it's the only item, then remove the current cart
                        _dbContext.CartItemsDbSet.Remove(cartItemsCarried);

                        // and if it's the only item, then we will remove the cart as well
                        if (cart.CartItemsList.Count() == 1)
                            _dbContext.CartDbSet.Remove(cart);

                        _dbContext.SaveChanges();
                    }
                    // if the quantity is not 0 or if the newQuantity is not going less than 0, update teh quantity
                    else
                    {
                        cartItemsCarried.Quantity = newQuantity;
                        _dbContext.SaveChanges();
                    }
                }
            }

            return _apiResponse;
        }
    }
}
