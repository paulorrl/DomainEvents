using System;
using System.Collections.Generic;
using DomainEventValidation.Domain.Entities;

namespace DomainEventValidation.Domain.Interface.Repository
{
    public interface ICidadeRepository : IDisposable
    {
        IEnumerable<Cidade> GetByEstado(Estado estado);
    }
}