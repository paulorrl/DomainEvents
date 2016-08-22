﻿using System;
using System.Collections.Generic;
using DomainEventValidation.Domain.DomainEvents.Container;
using SimpleInjector;

namespace DomainEventValidation.API.Helpers
{
    public class DomainEventsContainer : IContainer
    {
        private readonly Container _resolver;

        public DomainEventsContainer(Container resolver)
        {
            this._resolver = resolver;
        }

        public T GetService<T>()
        {
            return (T)this._resolver.GetInstance(typeof(T));
        }

        public object GetService(Type serviceType)
        {
            return this._resolver.GetInstance(serviceType);
        }

        public IEnumerable<T> GetServices<T>()
        {
            return (IEnumerable<T>)this._resolver.GetAllInstances(typeof(T));
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this._resolver.GetAllInstances(serviceType);
        }
    }
}