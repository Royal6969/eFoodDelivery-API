using eFoodDelivery_API.DbContexts;
using eFoodDelivery_API.DTOs;
using eFoodDelivery_API.Entities;
using eFoodDelivery_API.Models;
using eFoodDelivery_API.Tools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text.Json;

namespace eFoodDelivery_API.Controllers
{
    // [Route("api/[controller]")] // instead a dynamic route, if I change the controller name, the route does not get updated
    [Route("api/Order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // dependencies to inject
        private readonly ApplicationDbContext _dbContext;
        protected ApiResponse _apiResponse;

        // dependency injection
        public OrderController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _apiResponse = new ApiResponse();
        }



        /// <summary>
        /// 1º endpoint to get all orders in db
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="orderSearch"></param>
        /// <param name="orderStatus"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns>Ok with apiResponse complete</returns>
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<ApiResponse>> GetOrders(
            string? userId, 
            string orderSearch, string orderStatus,  // search and status are for search functionality
            int pageNumber = 1, int pageSize = 5     // this is for pagination functionality, we'll start in page numer 1 and we'll see five orders per page
        )
        {
            // note that the parameter userId has its type string with ?
            // that's why userId can be populated or not, because if admin is getting all the orders, we want to fetch all the orders from db
            // but if a user wants to see their orders, then we will only fetch the orders for that user

            try
            {
                //var ordersRetrievedFromDb = _dbContext.OrdersDbSet
                IEnumerable<Order> ordersRetrievedFromDb = _dbContext.OrdersDbSet
                    .Include(orderDetails => orderDetails.OrderDetails) // inlude the child objetc (collection for OrderDetails) in Order
                    .ThenInclude(product => product.Product)            // include the grandchild object (FK for Product) in OrderDetails
                    .OrderByDescending(order => order.OrderId)          // specify the way we want to order the resulting objects
                ;

                // we're checking if a userId is populated we filter that as we're getting the complete result here (in the else part)
                if (!string.IsNullOrEmpty(userId)) // we can also say ... if (userId != null)
                {
                    //_apiResponse.Result = ordersRetrievedFromDb.Where(client => client.ClientId == userId);
                    // now for pagination...
                    ordersRetrievedFromDb = ordersRetrievedFromDb.Where(client => client.ClientId == userId);
                }
                /*
                else
                {
                    _apiResponse.Result = ordersRetrievedFromDb;
                }
                */ // but now we don't want it like before
                
                // what we want to do is we want to apply all the other filters that we have
                // so right here, let me scroll down and we will be adding to if condition
                
                // the first one we can check if orderSearch string is not empty, then we will filter our orders by name, email or phone
                // if any of them have the search string within them, then we will display and assign that to order
                if (!string.IsNullOrEmpty(orderSearch))
                {
                    ordersRetrievedFromDb = ordersRetrievedFromDb.Where(client =>
                        client.ClientName.ToLower().Contains(orderSearch.ToLower())  ||
                        client.ClientEmail.ToLower().Contains(orderSearch.ToLower()) ||
                        client.ClientPhone.ToLower().Contains(orderSearch.ToLower())
                    );
                }
                // similarly, if orderStatus is not empty, we will filter based on status and converting to lower case
                if (!string.IsNullOrEmpty(orderStatus))
                {
                    ordersRetrievedFromDb = ordersRetrievedFromDb.Where(order => order.OrderStatus.ToLower() == orderStatus.ToLower());
                }
                // whith that, we added the search functionality to orders

                // first, create a pagination object and populate actual page, page size and records number
                Pagination pagination = new Pagination();
                pagination.ActualPage = pageNumber;
                pagination.PageSize = pageSize;
                pagination.RecordsNumber = ordersRetrievedFromDb.Count();

                // note that we have to add the "X-Pagination" special type for the Headers in the response to allow the pagination
                Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagination));

                // aply filter for pagination
                // so where we're returning the complete orders, we¡ll be using .Skip() and .Take() with Enumerable
                _apiResponse.Result = ordersRetrievedFromDb
                    .Skip((pageNumber - 1) * pageSize) // so think about pageNumber is 2, how many records we want to skip?
                    .Take(pageSize) //we want to take records base on the pageSize, if our pageSize is 10, we want to take the next 10 records to be displayed
                ;

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



        /// <summary>
        /// 2º endpoint to get an order by its id
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>BadRequest, NotFound or Ok with apiResponse</returns>
        [HttpGet("{orderId:int}")] // like this method has a parameter, I need to specify what parameter is (name:type)
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



        /// <summary>
        /// 3º endpoint to create a new order
        /// </summary>
        /// <param name="orderCreateDTO"></param>
        /// <returns>Ok with the apiResponse</returns>
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> CreateOrder([FromBody] OrderCreateDTO orderCreateDTO) // with [FromBody] we will get an object of order
        {
            // the idea is to create a new Order object with the OrderCreateDTO we're receiving as parameter
            try
            {
                // and right here we'll manually convert the DTO to an Order object
                Order newOrder = new Order();
                newOrder.ClientId = orderCreateDTO.ClientId;
                newOrder.ClientEmail = orderCreateDTO.ClientEmail;
                newOrder.ClientName = orderCreateDTO.ClientName;
                newOrder.ClientPhone = orderCreateDTO.ClientPhone;
                newOrder.OrderTotal = orderCreateDTO.OrderTotal;
                newOrder.OrderDate = DateTime.Now;
                newOrder.OrderPaymentID = orderCreateDTO.OrderPaymentID;
                newOrder.OrderQuantityItems = orderCreateDTO.OrderQuantityItems;
                // now it would be interesting to control the order status, and for that, we have to define more contants and set it here
                // so when we have to populate the initial status, we have to add a condition here
                newOrder.OrderStatus = string.IsNullOrEmpty(orderCreateDTO.OrderStatus) // if the user doesn't provide any status
                    ? Constants.STATUS_PENDING      // then we will set the status to be status_pending
                    : orderCreateDTO.OrderStatus;   // else we will set the status to be the status that is passed inside the DTO

                // if the ModelState is valid, let's add this new order to the OrdersDbSet
                if (ModelState.IsValid)
                {
                    _dbContext.OrdersDbSet.Add(newOrder);
                    // we need to save changes because in order to create the OrderDetails, we need this new Order id
                    _dbContext.SaveChanges();

                    // and once the new order is created, now we can loop through the OrderDetailsCreateDTO
                    foreach (var orderDetailsDTO in orderCreateDTO.OrderDetailsCreateDTO)
                    {
                        // create a new OrderDetails object and let's assign the properties
                        OrderDetails newOrderDetails = new OrderDetails();
                        newOrderDetails.OrderId = newOrder.OrderId;
                        newOrderDetails.Name = orderDetailsDTO.Name;
                        newOrderDetails.ProductId = orderDetailsDTO.ProductId;
                        newOrderDetails.Price = orderDetailsDTO.Price;
                        newOrderDetails.Quantity = orderDetailsDTO.Quantity;

                        // adding the newOrderDetails to the OrderDetailsDbSet 
                        _dbContext.OrderDetailsDbSet.Add(newOrderDetails);
                        // but now we don't want to save the changes if there are ten order details...
                    }
                    // ... so let's add them all together in one single call
                    _dbContext.SaveChanges();
                    // if I added this SaveChanges() inside the forEach(), then it will make ten database call for ten separate order details
                    // but if we add them outside of the forEach() loop, it will push them in one single call

                    _apiResponse.Result = newOrder;
                    newOrder.OrderDetails = null;
                    _apiResponse.StatusCode = HttpStatusCode.Created;

                    return Ok(_apiResponse);
                }
            }
            catch(Exception ex)
            {
                _apiResponse.Success = false;
                _apiResponse.ErrorsList = new List<string>() { ex.ToString() };
            }

            return _apiResponse;
        }



        /// <summary>
        /// 4º endpoint to update an order
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="orderUpdateDTO"></param>
        /// <returns>BAdRequest or Ok with apiResponse</returns>
        // when we are working with order, we are not updating all the properties, so we have few basic properties that could be updated in OrderUpdateDTO
        [HttpPut("{orderId:int}")]
        public async Task<ActionResult<ApiResponse>> UpdateOrder(int orderId, [FromBody] OrderUpdateDTO orderUpdateDTO)
        {
            try
            {
                // if the orderUpdateDTO is null or if the orderId doesn't match with the parameter
                if (orderUpdateDTO == null || orderId != orderUpdateDTO.OrderId)
                {
                    _apiResponse.Success = false;
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    
                    return BadRequest();
                }

                // then we will retrieve from the DB the order based on the orderId
                Order orderRetrievedFromDb = _dbContext.OrdersDbSet.FirstOrDefault(order => order.OrderId == orderId);

                // once we retrieve that, if that is null, we can return again a bad request
                if (orderRetrievedFromDb == null)
                {
                    _apiResponse.Success = false;
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    
                    return BadRequest();
                }

                // then we will check individual property, if they are null, then we will not update them
                if (!string.IsNullOrEmpty(orderUpdateDTO.ClientName))
                    orderRetrievedFromDb.ClientName = orderUpdateDTO.ClientName;

                if (!string.IsNullOrEmpty(orderUpdateDTO.ClientPhone))
                    orderRetrievedFromDb.ClientPhone = orderUpdateDTO.ClientPhone;

                if (!string.IsNullOrEmpty(orderUpdateDTO.ClientEmail))
                    orderRetrievedFromDb.ClientEmail = orderUpdateDTO.ClientEmail;

                if (!string.IsNullOrEmpty(orderUpdateDTO.OrderPaymentID))
                    orderRetrievedFromDb.OrderPaymentID = orderUpdateDTO.OrderPaymentID;

                if (!string.IsNullOrEmpty(orderUpdateDTO.OrderStatus))
                    orderRetrievedFromDb.OrderStatus = orderUpdateDTO.OrderStatus;

                // finally, we need to save the changes
                _dbContext.SaveChanges();
                _apiResponse.StatusCode = HttpStatusCode.NoContent;
                _apiResponse.Success = true;

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