using System.Collections.Generic;
using DomainEventValidation.Domain.Entities;
using DomainEventValidation.Domain.Interface.Repository;
using DomainEventValidation.Domain.Interface.Service;

namespace DomainEventValidation.Domain.Services
{
    public class CidadeService : ICidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;

        public CidadeService(ICidadeRepository cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }

        public IEnumerable<Cidade> GetByEstado(Estado estado)
        {
            return _cidadeRepository.GetByEstado(estado);
        }

        public void Dispose()
        {
            _cidadeRepository.Dispose();
        }
    }
}