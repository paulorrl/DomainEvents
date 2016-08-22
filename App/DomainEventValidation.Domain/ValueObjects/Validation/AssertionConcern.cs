using System.Collections.Generic;
using System.Linq;
using DomainEventValidation.Domain.DomainEvents;
using DomainEventValidation.Domain.Notification.Event;

namespace DomainEventValidation.Domain.ValueObjects.Validation
{
    public class AssertionConcern
    {
        public static DomainNotification AssertArgumentGreater(decimal valueReference, decimal valueCompare, string message)
        {
            return (valueReference > valueCompare)
                ? null
                : new DomainNotification("AssertGreaterValue", message);
        }

        public static DomainNotification AssertArgumentRangeNumeric(int value, int min, int max, string message)
        {
            if (value >= min && value <= max)
                return null;

            return new DomainNotification("AssertRangeNumeric", message);
        }

        public static bool IsSatisfiedBy(params DomainNotification[] validations)
        {
            IEnumerable<DomainNotification> notifications = from validation in validations
                                                            where validation != null
                                                            select validation;

            NotifyAll(notifications);
            return notifications.Count<DomainNotification>().Equals(0);
        }

        private static void NotifyAll(IEnumerable<DomainNotification> notifications)
        {
            notifications.ToList<DomainNotification>()
                .ForEach(validation => DomainEvent.Raise<DomainNotification>(validation));
        }
    }
}