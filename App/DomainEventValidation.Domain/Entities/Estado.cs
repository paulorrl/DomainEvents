using DomainEventValidation.Domain.Scopes;

namespace DomainEventValidation.Domain.Entities
{
    public class Estado
    {
        public Estado(int estadoId)
        {
            EstadoId = estadoId;
            this.CidadesPorEstadoIsValid();
        }

        public int EstadoId { get; }

        public string Nome { get; }

        public string Sigla { get; }
    }
}