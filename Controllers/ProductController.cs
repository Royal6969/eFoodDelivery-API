using eFoodDelivery_API.DbContexts;
using eFoodDelivery_API.Entities;
using eFoodDelivery_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace eFoodDelivery_API.Controllers
{
    // [Route("api/[controller]")] // instead a dynamic route, if I change the controller name, the route does not get updated
    [Route("api/Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext; // read property for our context
        private ApiResponse _apiResponse; // property for our API response

        public ProductController(ApplicationDbContext dbContext) // dependency injection
        {
            _dbContext = dbContext;
            _apiResponse = new ApiResponse();
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            // return Ok(_dbContext.ProductsDbSet); // it will go to DB and fetch all products and return back, but I want to get better control for api response

            _apiResponse.Result = _dbContext.ProductsDbSet;
            _apiResponse.StatusCode = HttpStatusCode.OK;
            return Ok(_apiResponse);
        }

        [HttpGet("{id:int}")] // like this method has a parameter, I need to specify what parameter is (name:type)
        public async Task<IActionResult> GetProduct(int id)
        {
            if (id == 0) // check for BadRequest
            {
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                return BadRequest(_apiResponse);
            }
            
            Product product = _dbContext.ProductsDbSet.FirstOrDefault(p => p.Id == id);
            
            if(product == null) // check for NotFound
            {
                _apiResponse.StatusCode = HttpStatusCode.NotFound;
                return NotFound(_apiResponse);
            }

            _apiResponse.Result = product;
            _apiResponse.StatusCode = HttpStatusCode.OK;
            return Ok(_apiResponse);
        }
    }
}
