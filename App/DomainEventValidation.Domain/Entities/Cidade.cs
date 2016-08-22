namespace DomainEventValidation.Domain.Entities
{
    public class Cidade
    {
        public int CidadeId { get; set; }

        public string Nome { get; set; }

        public bool Capital { get; set; }

        public int EstadoId { get; set; }
    }
}