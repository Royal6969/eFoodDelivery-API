using Microsoft.AspNetCore.Identity;

namespace eFoodDelivery_API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
