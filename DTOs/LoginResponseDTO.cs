namespace eFoodDelivery_API.DTOs
{
    public class LoginResponseDTO
    {
        public string Email { get; set; }
        public string Token { get; set; } // in this string Token we can add whatever details we want, like email, userID, userRole and more
    }
}
