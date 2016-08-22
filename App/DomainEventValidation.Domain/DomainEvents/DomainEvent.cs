using DomainEventValidation.Domain.DomainEvents.Container;
using DomainEventValidation.Domain.DomainEvents.Events;
using DomainEventValidation.Domain.DomainEvents.Handler;

namespace DomainEventValidation.Domain.DomainEvents
{
    public static class DomainEvent
    {
        public static IContainer Container { get; set; }

        public static void Raise<T>(T evento) where T : IDomainEvent
        {
            ((IHandler<T>)Container.GetService(typeof(IHandler<T>))).Handle(evento);
        }
    }
}