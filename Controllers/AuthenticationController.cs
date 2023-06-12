using eFoodDelivery_API.DbContexts;
using eFoodDelivery_API.DTOs;
using eFoodDelivery_API.Models;
using eFoodDelivery_API.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NLog;
using Stripe;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
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
        // create a static logger field for nLog
        // private static Logger logger = LogManager.GetCurrentClassLogger();

        // dependencies to inject 
        private readonly ApplicationDbContext _dbContext;
        protected ApiResponse _apiResponse;
        private string _JWTsecretKey;
        private readonly UserManager<ApplicationUser> _userManager; // Identity helper method
        private readonly RoleManager<IdentityRole> _roleManager;    // Identity helper methods
        private readonly ILogger<AuthenticationController> _logger; // for App Service logging to Kudu console and container in storage account 

        // dependency injection
        public AuthenticationController(ApplicationDbContext dbContext, IConfiguration configuration, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, ILogger<AuthenticationController> logger) // using this configuration, we can access to appsettings.json
        {
            _dbContext = dbContext;
            _apiResponse = new ApiResponse();
            _JWTsecretKey = configuration.GetValue<string>("ApiSecrets:JWTsecret"); //  and we can populate the JWTsecretKey by this way
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
        }



        /// <summary>
        /// 1º endpoint to login users
        /// </summary>
        /// <param name="loginRequestDTO"></param>
        /// <returns>Ok or BadRequest with apiResponse</returns>
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO loginRequestDTO)
        {
            // when the user tries to login in base his username, we have to retrieve that user from db
            ApplicationUser userRetrievedFromDb = _dbContext.ApplicationUsersDbSet
                .FirstOrDefault(user => user.UserName.ToLower() == loginRequestDTO.UserName.ToLower());

            // we can use a Identity Helper Method to check the password
            bool valid = await _userManager.CheckPasswordAsync(userRetrievedFromDb, loginRequestDTO.Password);

            // if password given by user doesn't match with password in db --> BadRequest
            if (!valid)
            {
                _apiResponse.Result = new LoginResponseDTO();
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                _apiResponse.Success = false;
                _apiResponse.ErrorsList.Add("Usuario o Contraseña incorrecto.");

                return BadRequest(_apiResponse);
            }
            // if the email given by the new user is not confirmed yet --> BadRequest
            else if (!userRetrievedFromDb.EmailConfirmed)
            {
                _apiResponse.Result = new LoginResponseDTO();
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                _apiResponse.Success = false;
                _apiResponse.ErrorsList.Add("Este email aún no ha sido confirmado. Revise su correo electrónico.");

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
            securityTokenDescriptor.Expires = DateTime.UtcNow.AddDays(1);
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
                _apiResponse.ErrorsList.Add("Usuario o Contraseña incorrecto.");

                return BadRequest(_apiResponse);
            }

            // if everything is valid like email and token are populated, then we will return back OK
            _apiResponse.StatusCode = HttpStatusCode.OK;
            _apiResponse.Success = true;
            _apiResponse.Result = loginResponseDTO;
            _logger.LogInformation("Ha iniciado sesión el usuario: " + userRetrievedFromDb.Email);
            return Ok(_apiResponse);
        }



        /// <summary>
        /// 2º endpoint to register users
        /// </summary>
        /// <param name="registerRequestDTO"></param>
        /// <returns>Ok or BadRequest with apiResponse</returns>
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDTO registerRequestDTO)
        {
            // check if the new user alredy exists
            ApplicationUser userRetrievedFromDb = _dbContext.ApplicationUsersDbSet
                .FirstOrDefault(user => user.UserName.ToLower() == registerRequestDTO.UserName.ToLower());

            // if the user alredy exists --> Error message and BadRequest
            if (userRetrievedFromDb != null)
            {
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                _apiResponse.Success = false;
                _apiResponse.ErrorsList.Add("Ese email ya está en uso. Pruebe con otra dirección de correo.");

                return BadRequest(_apiResponse);
            }

            // if the user not exists yet --> create the new user
            ApplicationUser newUser = new ApplicationUser();
            newUser.UserName = registerRequestDTO.UserName;
            newUser.Email = registerRequestDTO.UserName; // by the moment, we will keep the email as the UserName
            newUser.NormalizedEmail = registerRequestDTO.UserName.ToUpper();
            newUser.Name = registerRequestDTO.Name;
            newUser.PhoneNumber = registerRequestDTO.PhoneNumber;
            newUser.EmailConfirmed = false;

            try
            {
                // to insert the new user in db we use _userManager
                var result = await _userManager.CreateAsync(newUser, registerRequestDTO.Password);

                // now it's time to assign a role to the new user
                if (result.Succeeded)
                {
                    // retrieve the new user created and send the email verification
                    ApplicationUser newUserCreatedBefore = _dbContext.ApplicationUsersDbSet.FirstOrDefault(user => user.Email == newUser.Email);
                    EmailUtils.SendVerificationEmail(newUserCreatedBefore.Id, newUserCreatedBefore.Email, newUserCreatedBefore.Name);
                    
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
                    _logger.LogInformation("Se ha registrado el usuario: " + newUser.Email);
                    return Ok(_apiResponse);
                }
            }
            catch (Exception ex)
            {
                // Return a generic user-friendly error message
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                _apiResponse.Success = false;
                _apiResponse.ErrorsList.Add("Ha ocurrido un error durante el registro. Inténtelo más tarde.");
                _apiResponse.ErrorsList.Add(ex.ToString());

                return BadRequest(_apiResponse);
            }

            _apiResponse.StatusCode = HttpStatusCode.BadRequest;
            _apiResponse.Success = false;
            _apiResponse.ErrorsList.Add("Ha ocurrido un error durante el registro. Inténtelo más tarde.");

            return BadRequest(_apiResponse);
        }



        /// <summary>
        /// 3º endpoint to confirm the email given in registration and activate that user
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Ok or BadRequest with apiResponse</returns>
        [HttpGet("confirmEmail/{id}")]
        public async Task<ActionResult<ApiResponse>> ActivateUser(string id)
        {
            try
            {
                // retrieve the new user registered by the id
                ApplicationUser user = _dbContext.ApplicationUsersDbSet.FirstOrDefault(u => u.Id == id);
                
                // check if the email gicen by the new user is not conformed yet, then confirm that email
                if (!user.EmailConfirmed)
                {
                    try
                    {
                        // set true the EmailConfirmed field and apply the changes in db
                        user.EmailConfirmed = true;
                        _dbContext.Entry(user).State = EntityState.Modified;
                        await _dbContext.SaveChangesAsync();

                        _apiResponse.StatusCode = HttpStatusCode.OK;
                        _apiResponse.Success = true;
                        _logger.LogInformation("Ha verificado su email el usuario: " + user.Email);
                        // return Ok(_apiResponse);
                        // we return a HTML page better that response only
                        return Content(Constants.CONFIRM_EMAIL_HTML, "text/html");
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        if (!_dbContext.ApplicationUsersDbSet.Any(user => user.Id == id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            _apiResponse.StatusCode = HttpStatusCode.InternalServerError;
                            _apiResponse.Success = false;
                            _apiResponse.ErrorsList.Add("Ha ocurrido un error mientras se confirmaba el usuario. Inténtelo más tarde.");
                            _apiResponse.ErrorsList.Add(ex.ToString());

                            return StatusCode((int)HttpStatusCode.InternalServerError, _apiResponse);
                        }
                    }
                }

                _apiResponse.StatusCode = HttpStatusCode.OK;
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



        /// <summary>
        /// 4º endpoint to send email to change the user password - init proccess for ForgotPassword
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Ok or BadRequest with apiResponse</returns>
        [HttpPost("SendEmailToRecoverPassword")]
        public async Task<IActionResult> SendEmailToRecoverPassword([FromBody] string email)
        {
            // when the user tries to login in base his username, we have to retrieve that user from db
            ApplicationUser userRetrievedFromDb = _dbContext.ApplicationUsersDbSet
                .FirstOrDefault(user => user.UserName.ToLower() == email.ToLower());

            if (userRetrievedFromDb != null)
            {
                try
                {
                    // generate the random code and set it in the Code field and apply the changes in db
                    userRetrievedFromDb.Code = CodeUtils.GenerateCode();
                    _dbContext.Entry(userRetrievedFromDb).State = EntityState.Modified;
                    await _dbContext.SaveChangesAsync();

                    // send an email to user with the random code
                    EmailUtils.SendCodeEmail(email, userRetrievedFromDb.Name, userRetrievedFromDb.Code);

                    _apiResponse.StatusCode = HttpStatusCode.OK;
                    _apiResponse.Success = true;
                    _logger.LogInformation("Ha solicitado restablecer la contraseña el usuario: " + userRetrievedFromDb.Email);
                    return Ok(_apiResponse);
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    _apiResponse.StatusCode = HttpStatusCode.InternalServerError;
                    _apiResponse.Success = false;
                    _apiResponse.ErrorsList.Add("Ha ocurrido un error mientras se enviaba el email de recuperación. Inténtelo más tarde.");
                    _apiResponse.ErrorsList.Add(ex.ToString());

                    return StatusCode((int)HttpStatusCode.InternalServerError, _apiResponse);
                }
            }

            _apiResponse.StatusCode = HttpStatusCode.BadRequest;
            _apiResponse.Success = false;
            _apiResponse.ErrorsList.Add("Ha ocurrido un error enviando el email de recuperación");

            return BadRequest(_apiResponse);
        }



        /// <summary>
        /// 5º endpoint to verify the code given in the email we sent to user in 4º endpoint before
        /// </summary>
        /// <param name="verifyCodeDTO"></param>
        /// <returns>Ok or BadRequest with apiResponse</returns>
        [HttpPost("VerifyCode")]
        public async Task<IActionResult> VerifyCode([FromBody] VerifyCodeDTO verifyCodeDTO)
        {
            // when the user tries to login in base his username, we have to retrieve that user from db
            ApplicationUser userRetrievedFromDb = _dbContext.ApplicationUsersDbSet
                .FirstOrDefault(user => 
                    (user.UserName.ToLower() == verifyCodeDTO.Email.ToLower()) && (user.Code == verifyCodeDTO.Code));

            if (userRetrievedFromDb != null)
            {
                _apiResponse.StatusCode = HttpStatusCode.OK;
                _apiResponse.Success = true;
                _logger.LogInformation("Ha verificado el código de cambio de contraseña el usuario: " + userRetrievedFromDb.Email);
                return Ok(_apiResponse);
            }

            _apiResponse.StatusCode = HttpStatusCode.BadRequest;
            _apiResponse.Success = false;
            _apiResponse.ErrorsList.Add("El códido no coincide con el que se ha enviado en el correo de recuperación.");

            return BadRequest(_apiResponse);
        }



        /// <summary>
        /// 6º endpoint to allow user to change the password once code is verified with 5º endpoint before
        /// </summary>
        /// <param name="newPasswordDTO"></param>
        /// <returns>Ok or BadRequest with apiResponse</returns>
        [HttpPost("ChangeUserPassword")]
        public async Task<IActionResult> ChangeUserPassword([FromBody] NewPasswordDTO newPasswordDTO)
        {
            // when the user tries to login in base his username, we have to retrieve that user from db
            ApplicationUser userRetrievedFromDb = _dbContext.ApplicationUsersDbSet
                .FirstOrDefault(user => (user.UserName.ToLower() == newPasswordDTO.Email.ToLower()) && (user.Code == newPasswordDTO.Code));

            if (userRetrievedFromDb != null)
            {
                // retrieve the user again
                var user = await _userManager.FindByIdAsync(userRetrievedFromDb.Id);
                // generate token
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                // reset password
                var result = await _userManager.ResetPasswordAsync(user, token, newPasswordDTO.Password);

                _apiResponse.StatusCode = HttpStatusCode.OK;
                _apiResponse.Success = true;
                _logger.LogInformation("Ha restablecido su contraseña el usuario: " + userRetrievedFromDb.Email);
                return Ok(_apiResponse);
            }

            _apiResponse.StatusCode = HttpStatusCode.BadRequest;
            _apiResponse.Success = false;
            _apiResponse.ErrorsList.Add("Ha ocurrido un error mientras se cambiaba la contraseña.");

            return BadRequest(_apiResponse);
        }
    }
}
