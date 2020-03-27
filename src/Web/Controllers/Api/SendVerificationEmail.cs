using System;
using System.Threading.Tasks;
using Coravel.Events.Interfaces;
using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using Microsoft.eShopWeb.Web.Services;

namespace Web.Controllers.Api
{
    public class SendVerificationEmail : IListener<UserVerified>
    {
        private IEmailSender _emailSender;

        public SendVerificationEmail(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public async Task HandleAsync(UserVerified e)
        {
            Console.WriteLine("Starting...");
            await _emailSender.SendEmailConfirmationAsync(e.Email, e.CallbackUrl);
            Console.WriteLine("Ending...");
        }
    }
}