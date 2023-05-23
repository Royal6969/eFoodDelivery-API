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
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // dependencies to inject
        private readonly ApplicationDbContext _dbContext;
        protected ApiResponse _apiResponse;

        // dependency injection
        public UserController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _apiResponse = new ApiResponse();
        }


        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetUsers()
        {
            try
            {
                IEnumerable<ApplicationUser> usersRetrievedFromDb = _dbContext.ApplicationUsersDbSet;

                _apiResponse.Result = usersRetrievedFromDb;
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
