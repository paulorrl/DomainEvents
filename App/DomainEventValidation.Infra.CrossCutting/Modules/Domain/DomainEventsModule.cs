using DomainEventValidation.Domain.DomainEvents.Handler;
using DomainEventValidation.Domain.Notification.Event;
using DomainEventValidation.Domain.Notification.Handler;
using SimpleInjector;

namespace DomainEventValidation.Infra.CrossCutting.Modules.Domain
{
    internal static class DomainEventsModule
    {
        internal static void RegisterDomainEvents(Container container)
        {
            container.Register<IHandler<DomainNotification>, DomainNotificationHandler>(Lifestyle.Scoped);
        }
    }
}