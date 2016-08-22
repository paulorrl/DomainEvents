using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using DomainEventValidation.Domain.DomainEvents;
using DomainEventValidation.Domain.DomainEvents.Handler;
using DomainEventValidation.Domain.Notification.Event;

namespace DomainEventValidation.API.Controllers.Base
{
    // [Authorize]
    public class BaseController : ApiController
    {
        private readonly IHandler<DomainNotification> _notifications;
        protected HttpResponseMessage _responseMessage;

        public BaseController()
        {
            _notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
            _responseMessage = new HttpResponseMessage();
        }

        protected Task<HttpResponseMessage> CreateResponse(HttpStatusCode code, object result)
        {
            _responseMessage = _notifications.HasNotifications()
                ? Request.CreateResponse(HttpStatusCode.BadRequest, new { errors = _notifications.Notify() })
                : Request.CreateResponse(code, result);

            return Task.FromResult(_responseMessage);
        }

        protected Task<HttpResponseMessage> CreateErrorResponse(HttpStatusCode code, string message)
        {
            _responseMessage = _notifications.HasNotifications()
                ? Request.CreateResponse(HttpStatusCode.BadRequest, new { errors = _notifications.Notify() })
                : Request.CreateResponse(code);

            // Log async (message)
            return Task.FromResult(_responseMessage);
        }

        protected override void Dispose(bool disposing)
        {
            _notifications.Dispose();
        }
    }
}