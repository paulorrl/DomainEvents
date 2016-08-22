using System;
using System.Collections.Generic;
using DomainEventValidation.Domain.Entities;

namespace DomainEventValidation.Application.Interface
{
    public interface ICidadeApplicationService : IDisposable
    {
        IEnumerable<Cidade> GetByEstado(int estadoId);
    }
}