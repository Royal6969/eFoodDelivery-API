namespace eFoodDelivery_API.Services.Interfaces
{
    public interface IEmailService
    {
        public void SendVerificationEmail(string userId, string userEmail, string userName);
    }
}
