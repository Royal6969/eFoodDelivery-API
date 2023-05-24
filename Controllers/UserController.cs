using eFoodDelivery_API.DbContexts;
using eFoodDelivery_API.Entities;
using eFoodDelivery_API.Models;
using eFoodDelivery_API.Tools;
using Microsoft.AspNetCore.Authorization;
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


        [HttpGet("{id}", Name = "GetUser")] // like this method has a parameter, I need to specify what parameter is (name:type)
        public async Task<IActionResult> GetUser(string id)
        {
            if (id == 0.ToString()) // check for BadRequest
            {
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                _apiResponse.Success = false;
                return BadRequest(_apiResponse);
            }

            ApplicationUser user = _dbContext.ApplicationUsersDbSet.FirstOrDefault(p => p.Id == id);

            if (user == null) // check for NotFound
            {
                _apiResponse.StatusCode = HttpStatusCode.NotFound;
                _apiResponse.Success = false;
                return NotFound(_apiResponse);
            }

            _apiResponse.Result = user;
            _apiResponse.StatusCode = HttpStatusCode.OK;
            return Ok(_apiResponse);
        }


        [HttpDelete("{id}")]
        [Authorize(Roles = Constants.ROLE_ADMIN)]
        public async Task<ActionResult<ApiResponse>> DeleteUser(string id)
        {
            try
            {
                if (id == 0.ToString())
                {
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    _apiResponse.Success = false;
                    return BadRequest();
                }

                ApplicationUser userRetrievedFromDb = await _dbContext.ApplicationUsersDbSet.FindAsync(id);

                if (userRetrievedFromDb == null)
                {
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    _apiResponse.Success = false;
                    return BadRequest();
                }

                _dbContext.ApplicationUsersDbSet.Remove(userRetrievedFromDb);
                _dbContext.SaveChanges();
                _apiResponse.StatusCode = HttpStatusCode.NoContent;

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
