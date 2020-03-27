using Coravel.Events.Interfaces;

namespace Web.Controllers.Api
{
    public class UserVerified : IEvent
    {
        public string Email { get; set; }
        public string CallbackUrl { get; set; }
    }
}