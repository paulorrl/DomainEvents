using DomainEventValidation.Application.AppService;
using DomainEventValidation.Application.Interface;
using SimpleInjector;

namespace DomainEventValidation.Infra.CrossCutting.Modules.Application
{
    internal static class ApplicationServiceModule
    {
        internal static void RegisterAppServices(Container container)
        {
            container.Register<ICidadeApplicationService, CidadeApplicationService>(Lifestyle.Scoped);
        }
    }
}