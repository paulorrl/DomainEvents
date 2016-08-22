using DomainEventValidation.Domain.Interface.Repository;
using DomainEventValidation.Infra.Data.Repository;
using SimpleInjector;

namespace DomainEventValidation.Infra.CrossCutting.Modules.Repository
{
    internal static class RepositoryModule
    {
        internal static void RegisterRepositories(Container container)
        {
            container.Register<ICidadeRepository, CidadeRepository>(Lifestyle.Scoped);
        }
    }
}