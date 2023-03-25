using eFoodDelivery_API.Tools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eFoodDelivery_API.Controllers
{
    // [Route("api/[controller]")]
    [Route("api/AuthenticationTest")]
    [ApiController]
    public class AuthenticationTestController : ControllerBase
    {
        [HttpGet]
        [Authorize] // if we want to get some endpoint to be accessed by only authenticated users, we have to add this tag
        public async Task<ActionResult<string>> GetAuthentication()
        {
            // Authentication means that if my username and password is valid, I'm authenticated
            return "You're authenticated successfully";
        }

        [HttpGet("{id:int}")]
        [Authorize(Roles = Constants.ROLE_ADMIN)] // if we want that some endpoint needs to be accessed only with an admin role, we have to specify the rol
        public async Task<ActionResult<string>> GetAuthorization(int id)
        {
            // Authorization means the role we get when we login and what we're able to go and do
            return "You're authorized with admin role";
        }
    }
}
