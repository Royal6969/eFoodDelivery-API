using eFoodDelivery_API.DbContexts;
using eFoodDelivery_API.DTOs;
using eFoodDelivery_API.Models;
using eFoodDelivery_API.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace eFoodDelivery_API.Controllers
{
    // [Route("api/[controller]")] // instead a dynamic route, if I change the controller name, the route does not get updated
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


        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO loginRequestDTO)
        {
            // when the user tries to login in base his username, we have to retrieve that user from db
            ApplicationUser userRetrievedFromDb = _dbContext.ApplicationUsersDbSet.FirstOrDefault(user => user.UserName.ToLower() == loginRequestDTO.UserName.ToLower());

            // we can use a Identity Helper Method to check the password
            bool valid = await _userManager.CheckPasswordAsync(userRetrievedFromDb, loginRequestDTO.Password);

            // if password given by user doesn't match with password in db --> BadRequest
            if (!valid)
            {
                _apiResponse.Result = new LoginResponseDTO();
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                _apiResponse.Success = false;
                _apiResponse.ErrorsList.Add("Username or Password is incorrect");

                return BadRequest(_apiResponse);
            }

            ////////////////////////////////////// Token Generation starts ///////////////////////////////////////
            // if the password match correctly, we have to generate a JWT
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            // we have to convert in array our _JWTsecretKey
            byte[] secretKey = Encoding.ASCII.GetBytes(_JWTsecretKey);
            // we will need the user role so let's get it with an Identity helper method
            var userRoles = await _userManager.GetRolesAsync(userRetrievedFromDb);
            // to define properties for the token
            SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor();
            // each one of those properties are defined in a Claim inside a claim array (creating an object of ClaimsIdentity type)
            securityTokenDescriptor.Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim("fullName", userRetrievedFromDb.Name),
                new Claim("userId", userRetrievedFromDb.Id.ToString()),
                // there are some claims alredy defined inside ClaimTypes class
                new Claim(ClaimTypes.Email, userRetrievedFromDb.UserName.ToString()),
                new Claim(ClaimTypes.Role, userRoles.FirstOrDefault()),
            });
            // how long the token is valid for ??
            securityTokenDescriptor.Expires = DateTime.UtcNow.AddDays(7);
            // we need to use our byte[]secretKey to validate or add a signature to our token
            securityTokenDescriptor.SigningCredentials = new SigningCredentials
                (
                    new SymmetricSecurityKey(secretKey), 
                    SecurityAlgorithms.HmacSha256Signature
                );
            // Final step --> generate token
            SecurityToken securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
            ////////////////////////////////////// Token Generation ends ///////////////////////////////////////

            // populate email and token
            LoginResponseDTO loginResponseDTO = new LoginResponseDTO();
            loginResponseDTO.Email = userRetrievedFromDb.Email;
            loginResponseDTO.Token = jwtSecurityTokenHandler.WriteToken(securityToken);

            // if the email is null, return again a BadRequest
            if (loginResponseDTO.Email == null || string.IsNullOrEmpty(loginResponseDTO.Token))
            {
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                _apiResponse.Success = false;
                _apiResponse.ErrorsList.Add("Username or Password is incorrect");

                return BadRequest(_apiResponse);
            }

            // if everything is valid like email and token are populated, then we will return back OK
            _apiResponse.StatusCode = HttpStatusCode.OK;
            _apiResponse.Success = true;
            _apiResponse.Result = loginResponseDTO;

            return Ok(_apiResponse);
        }


        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDTO registerRequestDTO)
        {
            // check if the new user alredy exists
            ApplicationUser userRetrievedFromDb = _dbContext.ApplicationUsersDbSet.FirstOrDefault(user => user.UserName.ToLower() == registerRequestDTO.UserName.ToLower());

            // if the user alredy exists --> Error message and BadRequest
            if (userRetrievedFromDb != null)
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
