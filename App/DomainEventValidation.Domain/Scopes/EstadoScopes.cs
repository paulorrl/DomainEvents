using DomainEventValidation.Domain.Entities;
using DomainEventValidation.Domain.ValueObjects.Enum;
using DomainEventValidation.Domain.ValueObjects.Resource;
using DomainEventValidation.Domain.ValueObjects.Validation;

namespace DomainEventValidation.Domain.Scopes
{
    public static class EstadoScopes
    {
        public static bool CidadesPorEstadoIsValid(this Estado estado)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertArgumentRangeNumeric(estado.EstadoId, (int)UnidadeFederativa.AC, (int)UnidadeFederativa.TO, Errors.InvalidStateId)
                );
        }
    }
}