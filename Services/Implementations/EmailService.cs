using eFoodDelivery_API.Services.Interfaces;
using System.Net.Mail;
using System.Net;
using Azure.Storage.Blobs;

namespace eFoodDelivery_API.Services.Implementations
{
    public class EmailService : IEmailService
    {
        // dependencies to inject
        private readonly IEmailService _emailService;

        // dependency injection
        public EmailService(IEmailService emailService)
        {
            _emailService = emailService;
        }



        /// <summary>
        /// 1º method to send the verification email when a new user registers
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userEmail"></param>
        /// <param name="userName"></param>
        public void SendVerificationEmail(string userId, string userEmail, string userName)
        {
            // SMTP client setup for Gmail
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("efooddelivery.noreply@gmail.com", "gzwahdpshxyxfwiq");
            smtpClient.EnableSsl = true;

            // creating the email
            MailMessage mensaje = new MailMessage();
            mensaje.From = new MailAddress("efooddelivery.noreply@gmail.com");
            mensaje.To.Add(userEmail);
            mensaje.Subject = "eFoodDelivery - Verificación de correo electrónico";

            // HTML email content
            mensaje.IsBodyHtml = true;
            mensaje.Body = $"<h3>Hola " + userName + "!</h3><br/>" +
                $"<p>Necesitamos que confirmes esta dirección de correo electrónico haciendo&nbsp;<a href='https://efooddelivery-api.azurewebsites.net/api/Authentication/confirmEmail/{userId}'>click aquí</a></p>";

            try
            {
                // send email
                smtpClient.Send(mensaje);
                Console.WriteLine("Correo electrónico enviado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo electrónico: " + ex.Message);
            }
        }



        /// <summary>
        /// 2º method to send an email with a code to allow user recover his password
        /// </summary>
        /// <param name="userEmail"></param>
        /// <param name="userName"></param>
        /// <param name="verificationCode"></param>
        public static void SendCodeEmail(string userEmail, string userName, string verificationCode)
        {
            // SMTP client setup for Gmail
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("efooddelivery.noreply@gmail.com", "gzwahdpshxyxfwiq");
            smtpClient.EnableSsl = true;

            // creating the email
            MailMessage mensaje = new MailMessage();
            mensaje.From = new MailAddress("efooddelivery.noreply@gmail.com");
            mensaje.To.Add(userEmail);
            mensaje.Subject = "eFoodDelivery - Código para restablecer la contraseña";

            // HTML email content
            mensaje.IsBodyHtml = true;
            mensaje.Body = $"<h3>Hola " + userName + "!</h3><br/>" +
                $"<p><h2>{verificationCode}</h2></p>";

            try
            {
                // send email
                smtpClient.Send(mensaje);
                Console.WriteLine("Correo electrónico enviado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo electrónico: " + ex.Message);
            }
        }
    }
}
