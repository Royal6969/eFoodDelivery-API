namespace eFoodDelivery_API.DTOs
{
    public class RegisterRequestDTO
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } 
        // if we want to create a user with admin role, we will expect that as a string when a user is registering
        // but I know role should not be in the registration in the production API
        // then, I will find out some other way to register the admin user like by seeding the database
        public string PhoneNumber { get; set; }
    }
}
