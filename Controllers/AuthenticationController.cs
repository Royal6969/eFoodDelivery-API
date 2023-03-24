using eFoodDelivery_API.DbContexts;
using eFoodDelivery_API.DTOs;
using eFoodDelivery_API.Models;
using eFoodDelivery_API.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace eFoodDelivery_API.Controllers
{
    // [Route("api/[controller]")]
    [Route("api/Authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        // dependencies to inject 
        private readonly ApplicationDbContext _dbContext;
        private ApiResponse _apiResponse;
        private string _JWTsecretKey;
        private readonly UserManager<ApplicationUser> _userManager; // Identity helper method
        private readonly RoleManager<IdentityRole> _roleManager;    // Identity helper methods

        public AuthenticationController(ApplicationDbContext dbContext, IConfiguration configuration, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager) // using this configuration, we can access to appsettings.json
        {
            _dbContext = dbContext;
            _apiResponse = new ApiResponse();
            _JWTsecretKey = configuration.GetValue<string>("ApiSecrets:JWTsecret"); //  and we can populate the JWTsecretKey by this way
            _userManager = userManager;
            _roleManager = roleManager;
        }


        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDTO registerRequestDTO)
        {
            // check if the new user alredy exists
            ApplicationUser userFetchedFromDb = _dbContext.ApplicationUsersDbSet.FirstOrDefault(user => user.UserName.ToLower() == registerRequestDTO.UserName.ToLower());

            // if the user alredy exists --> Error message and BadRequest
            if (userFetchedFromDb != null)
            {
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                _apiResponse.Success = false;
                _apiResponse.ErrorsList.Add("UserName alredy exists");

                return BadRequest(_apiResponse);
            }

            // if the user not exists yet --> create the new user
            ApplicationUser newUser = new ApplicationUser();
            newUser.UserName = registerRequestDTO.UserName;
            newUser.Email = registerRequestDTO.UserName; // by the moment, we will keep the email as the UserName
            newUser.NormalizedEmail = registerRequestDTO.UserName.ToUpper();
            newUser.Name = registerRequestDTO.Name;

            try
            {
                // to insert the new user in db we use _userManager
                var result = await _userManager.CreateAsync(newUser, registerRequestDTO.Password);

                // now it's time to assign a role to the new user
                if (result.Succeeded)
                {
                    // if the role we want to create doesn't exists yet
                    if (!_roleManager.RoleExistsAsync(Constants.ROLE_ADMIN).GetAwaiter().GetResult()) // like we can't use await in conditions, we have to use the method GetAwaiter()
                    {
                        // create roles in db
                        await _roleManager.CreateAsync(new IdentityRole(Constants.ROLE_ADMIN));
                        await _roleManager.CreateAsync(new IdentityRole(Constants.ROlE_CUSTOMER));
                    }

                    // once roles are created in db we need to assign a role to this particular new user
                    if (registerRequestDTO.Role.ToLower() == Constants.ROLE_ADMIN)
                        await _userManager.AddToRoleAsync(newUser, Constants.ROLE_ADMIN);
                    else
                        await _userManager.AddToRoleAsync(newUser, Constants.ROlE_CUSTOMER);

                    _apiResponse.StatusCode = HttpStatusCode.OK;
                    _apiResponse.Success = true;

                    return Ok(_apiResponse);
                }
            }
            catch (Exception ex)
            {

            }

            _apiResponse.StatusCode = HttpStatusCode.BadRequest;
            _apiResponse.Success = false;
            _apiResponse.ErrorsList.Add("Error occurred during registration");

            return BadRequest(_apiResponse);
        }
    }
}
