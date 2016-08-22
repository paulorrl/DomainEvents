using System.Collections.Generic;
using DomainEventValidation.Application.AppService.Base;
using DomainEventValidation.Application.Interface;
using DomainEventValidation.Domain.Entities;
using DomainEventValidation.Domain.Interface.Service;

namespace DomainEventValidation.Application.AppService
{
    public class CidadeApplicationService : BaseApplicationService, ICidadeApplicationService
    {
        private readonly ICidadeService _cidadeService;

        public CidadeApplicationService(/*IUnitofWork uow,*/ ICidadeService cidadeService)
            : base(/*uow*/)
        {
            _cidadeService = cidadeService;
        }

        public IEnumerable<Cidade> GetByEstado(int estadoId)
        {
            var estado = new Estado(estadoId); // call factory
            return HasNotification() ? null : _cidadeService.GetByEstado(estado);
        }

        public void Dispose()
        {
            _cidadeService.Dispose();
        }
    }
}