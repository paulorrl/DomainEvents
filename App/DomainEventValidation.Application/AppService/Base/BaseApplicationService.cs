using DomainEventValidation.Application.Interface.Base;
using DomainEventValidation.Domain.DomainEvents;
using DomainEventValidation.Domain.DomainEvents.Handler;
using DomainEventValidation.Domain.Notification.Event;

namespace DomainEventValidation.Application.AppService.Base
{
    public class BaseApplicationService : IBaseApplicationService
    {
        private readonly IHandler<DomainNotification> _notifications;
        // private readonly IUnitOfWork _uow;

        public BaseApplicationService()
        {
            //_uow = uow;
            _notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
        }

        public bool HasNotification()
        {
            return _notifications.HasNotifications();
        }

        public bool Commit()
        {
            if (HasNotification()) return false;

            // call Commit
            return true;
        }

        public void RollBack(string message)
        {
            DomainEvent.Raise<DomainNotification>(new DomainNotification("BusinessError", message));
            // call RollBack
        }

        public void RollBack()
        {
            // call RollBack
        }
    }
}