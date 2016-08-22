using DomainEventValidation.Domain.Interface.Service;
using DomainEventValidation.Domain.Services;
using SimpleInjector;

namespace DomainEventValidation.Infra.CrossCutting.Modules.Domain
{
    internal static class ServiceModule
    {
        internal static void RegisterServices(Container container)
        {
            container.Register<ICidadeService, CidadeService>(Lifestyle.Scoped);
        }
    }
}