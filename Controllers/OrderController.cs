using eFoodDelivery_API.DbContexts;
using eFoodDelivery_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace eFoodDelivery_API.Controllers
{
    // [Route("api/[controller]")] // instead a dynamic route, if I change the controller name, the route does not get updated
    [Route("api/Order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // dependencies to inject
        private readonly ApplicationDbContext _dbContext;
        private ApiResponse _apiResponse;

        // dependency injection
        public OrderController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _apiResponse = new ApiResponse();
        }


        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetOrders(string? userId)
        {
            // note that the parameter userId has its type string with ?
            // that's why userId can be populated or not, because if admin is getting all the orders, we want to fetch all the orders from db
            // but if a user wants to see their orders, then we will only fetch the orders for that user

            try
            {
                var ordersRetrievedFromDb = _dbContext.OrdersDbSet
                    .Include(orderDetails => orderDetails.OrderDetails) // inlude the child objetc (collection for OrderDetails) in Order
                    .ThenInclude(product => product.Product)            // include the grandchild object (FK for Product) in OrderDetails
                    .OrderByDescending(order => order.OrderId)          // specify the way we want to order the resulting objects
                ;

                if (userId != null) // we can also say ... if (!string.IsNullOrEmpty(userId))
                {
                    _apiResponse.Result = ordersRetrievedFromDb.Where(client => client.ClientId == userId);
                }
                else
                {
                    _apiResponse.Result = ordersRetrievedFromDb;
                }

                _apiResponse.StatusCode = HttpStatusCode.OK;
                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.Success = false;
                _apiResponse.ErrorsList = new List<string>() { ex.ToString() };
            }

            return _apiResponse;
        }


        [HttpGet("{id:int}")] // like this method has a parameter, I need to specify what parameter is (name:type)
        public async Task<ActionResult<ApiResponse>> GetOrder(int orderId)
        {
            try
            {
                if (orderId == 0)
                {
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_apiResponse);
                }

                var ordersRetrievedFromDb = _dbContext.OrdersDbSet
                    .Include(orderDetails => orderDetails.OrderDetails) // inlude the child objetc (collection for OrderDetails) in Order
                    .ThenInclude(product => product.Product)            // include the grandchild object (FK for Product) in OrderDetails
                    .Where(order => order.OrderId == orderId)           // we have to filter the resulting objects by the orderId
                ;

                if (ordersRetrievedFromDb == null)
                {
                    _apiResponse.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_apiResponse);
                }

                _apiResponse.Result = ordersRetrievedFromDb;
                _apiResponse.StatusCode = HttpStatusCode.OK;
                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.Success = false;
                _apiResponse.ErrorsList = new List<string>() { ex.ToString() };
            }

            return _apiResponse;
        }
    }
}