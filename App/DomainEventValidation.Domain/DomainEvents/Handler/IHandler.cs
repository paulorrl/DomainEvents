using System;
using System.Collections.Generic;
using DomainEventValidation.Domain.DomainEvents.Events;

namespace DomainEventValidation.Domain.DomainEvents.Handler
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);

        bool HasNotifications();

        IEnumerable<T> Notify();
    }
}