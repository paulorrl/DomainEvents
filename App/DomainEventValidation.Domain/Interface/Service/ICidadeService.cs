using System;
using System.Collections.Generic;
using DomainEventValidation.Domain.Entities;

namespace DomainEventValidation.Domain.Interface.Service
{
    public interface ICidadeService : IDisposable
    {
        IEnumerable<Cidade> GetByEstado(Estado estado);
    }
}