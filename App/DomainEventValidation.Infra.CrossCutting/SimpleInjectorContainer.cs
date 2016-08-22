using DomainEventValidation.Infra.CrossCutting.Modules.Application;
using DomainEventValidation.Infra.CrossCutting.Modules.Domain;
using DomainEventValidation.Infra.CrossCutting.Modules.Repository;
using SimpleInjector;

namespace DomainEventValidation.Infra.CrossCutting
{
    public class SimpleInjectorContainer
    {
        public static void DependencyResolver(Container container)
        {
            // Application
            ApplicationServiceModule.RegisterAppServices(container);

            // Domain
            DomainEventsModule.RegisterDomainEvents(container);
            ServiceModule.RegisterServices(container);

            // Repository
            RepositoryModule.RegisterRepositories(container);
        }
    }
}