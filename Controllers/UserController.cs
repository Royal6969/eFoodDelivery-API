using eFoodDelivery_API.DbContexts;
using eFoodDelivery_API.Entities;
using eFoodDelivery_API.Models;
using eFoodDelivery_API.Tools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
        private readonly UserManager<ApplicationUser> _userManager;

        // dependency injection
        public UserController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _apiResponse = new ApiResponse();
            _userManager = userManager;
        }



        /// <summary>
        /// 1º endpoint to get all users from db
        /// </summary>
        /// <returns>Ok with apiResponse complete</returns>
        [HttpGet]
        [Authorize(Roles = Constants.ROLE_ADMIN)]
        public async Task<ActionResult<ApiResponse>> GetUsers()
        {
            try
            {
                //IEnumerable<ApplicationUser> usersRetrievedFromDb = _dbContext.ApplicationUsersDbSet; // when I get users without roles at first
                // "System.InvalidOperationException: There is already an open DataReader associated with this Connection which must be closed first
                IEnumerable<ApplicationUser> usersRetrievedFromDb = _dbContext.ApplicationUsersDbSet.ToList();
                List<UserWithRoleModel> usersWithRoles = new List<UserWithRoleModel>();

                // iterate all users to get their roles
                foreach (var user in usersRetrievedFromDb)
                {
                    string role = (await _userManager.GetRolesAsync(user)).FirstOrDefault();
                    usersWithRoles.Add(new UserWithRoleModel { User = user, Role = role });
                }

                //_apiResponse.Result = usersRetrievedFromDb; // when I get users without roles at first
                _apiResponse.Result = usersWithRoles; // return users and roles
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
        /// 2º endpoint to get a user by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>BadRequest, NotFound or Ok with apiResponse</returns>
        [HttpGet("{id}", Name = "GetUser")]
        [Authorize(Roles = Constants.ROLE_ADMIN)]
        public async Task<ActionResult<ApiResponse>> GetUser(string id)
        {
            if (id == "0" || id.IsNullOrEmpty()) // check for BadRequest
            {
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                _apiResponse.Success = false;
                return BadRequest();
            }

            // retrieve the user and his role
            ApplicationUser user = _dbContext.ApplicationUsersDbSet.FirstOrDefault(p => p.Id == id);
            string role = (await _userManager.GetRolesAsync(user)).FirstOrDefault();

            if (user == null) // check for NotFound
            {
                _apiResponse.StatusCode = HttpStatusCode.NotFound;
                _apiResponse.Success = false;
                return NotFound(_apiResponse);
            }

            _apiResponse.Result = new { User = user, Role = role };
            _apiResponse.StatusCode = HttpStatusCode.OK;
            return Ok(_apiResponse);
        }



        /// <summary>
        /// 3º endpoint to update the role of an user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roles"></param>
        /// <returns>BadRequest or Ok with apiResponse</returns>
        [HttpPut("{id}")]
        [Authorize(Roles = Constants.ROLE_ADMIN)]
        public async Task<ActionResult<ApiResponse>> UpdateUser(string id, [FromBody] string role)
        {
            try
            {
                // retrieve the user by id
                ApplicationUser userRetrievedFromDb = await _userManager.FindByIdAsync(id);

                if (userRetrievedFromDb == null || id != userRetrievedFromDb.Id)
                {
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    _apiResponse.Success = false;
                    return BadRequest();
                }

                // get the user roles
                var existingRole = await _userManager.GetRolesAsync(userRetrievedFromDb);

                // if role is the same that we're receiving in request, there's nothing to do
                if (existingRole.FirstOrDefault() == role)
                {
                    return Ok(_apiResponse);
                }

                // delete actual role
                await _userManager.RemoveFromRoleAsync(userRetrievedFromDb, existingRole.FirstOrDefault());

                // add new role
                await _userManager.AddToRoleAsync(userRetrievedFromDb, role);

                // update the object in DB
                _dbContext.ApplicationUsersDbSet.Update(userRetrievedFromDb);
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
      


        /// <summary>
        /// 4º endpoint to delete a user by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>BadRequest or Ok with apiResponse</returns>
        [HttpDelete("{id}")]
        [Authorize(Roles = Constants.ROLE_ADMIN)]
        public async Task<ActionResult<ApiResponse>> DeleteUser(string id)
        {
            try
            {
                if (id == "0" || id.IsNullOrEmpty())
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
