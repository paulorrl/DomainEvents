using System;
using System.Collections.Generic;
using System.Linq;
using DomainEventValidation.Domain.Entities;
using DomainEventValidation.Domain.Interface.Repository;

namespace DomainEventValidation.Infra.Data.Repository
{
    public class CidadeRepository : ICidadeRepository
    {
        public IEnumerable<Cidade> GetByEstado(Estado estado)
        {
            return Populate().Where(x => x.EstadoId == estado.EstadoId);
        }

        private static IEnumerable<Cidade> Populate()
        {
            return new List<Cidade>
            {
                new Cidade { EstadoId = 1, Nome = "Rio Branco", Capital = true, CidadeId = 16 },
                new Cidade { EstadoId = 1, Nome = "Acrelândia", Capital = false, CidadeId = 1 },
                                                                               
                new Cidade { EstadoId = 2, Nome = "Maceió", Capital = true, CidadeId = 69 },
                new Cidade { EstadoId = 2, Nome = "Água Branca", Capital = false, CidadeId = 23 },
                                                                               
                new Cidade { EstadoId = 3, Nome = "Macapá", Capital = true, CidadeId = 131 },
                new Cidade { EstadoId = 3, Nome = "Amapá", Capital = false, CidadeId = 125 },
                                                                               
                new Cidade { EstadoId = 4, Nome = "Manaus", Capital = true, CidadeId = 178 },
                new Cidade { EstadoId = 4, Nome = "Alvarães", Capital = false, CidadeId = 141 },
                                                                               
                new Cidade { EstadoId = 5, Nome = "Salvador", Capital = true, CidadeId = 538 },
                new Cidade { EstadoId = 5, Nome = "Abaíra", Capital = false, CidadeId = 203 },
                                                                               
                new Cidade { EstadoId = 6, Nome = "Fortaleza", Capital = true, CidadeId = 678 },
                new Cidade { EstadoId = 6, Nome = "Acopiara", Capital = false, CidadeId = 623 },
                                                                               
                new Cidade { EstadoId = 7, Nome = "Brasília", Capital = true, CidadeId = 804 },
                                                                                     
                new Cidade { EstadoId = 8, Nome = "Vitória", Capital = true, CidadeId = 882 },
                new Cidade { EstadoId = 8, Nome = "Afonso Cláudio", Capital = false, CidadeId = 805 },
                                                                                     
                new Cidade { EstadoId = 9, Nome = "Goiânia", Capital = true, CidadeId = 977 },
                new Cidade { EstadoId = 9, Nome = "Abadia de Goiás", Capital = false, CidadeId = 883 },
                             
                new Cidade { EstadoId = 10, Nome = "São Luís", Capital = true, CidadeId = 1314 },
                new Cidade { EstadoId = 10, Nome = "Alcântara", Capital = false, CidadeId = 1132 },
                                                                                
                new Cidade { EstadoId = 11, Nome = "Cuiabá", Capital = true, CidadeId = 1383 },
                new Cidade { EstadoId = 11, Nome = "Acorizal", Capital = false, CidadeId = 1346 },
                                                                                
                new Cidade { EstadoId = 12, Nome = "Campo Grande", Capital = true, CidadeId = 1506 },
                new Cidade { EstadoId = 12, Nome = "Água Clara", Capital = false, CidadeId = 1487 },
                                                                                
                new Cidade { EstadoId = 13, Nome = "Belo Horizonte", Capital = true, CidadeId = 1631 },
                new Cidade { EstadoId = 13, Nome = "Abre Campo", Capital = false, CidadeId = 1568 },
                                                                                
                new Cidade { EstadoId = 14, Nome = "Belém", Capital = true, CidadeId = 2437 },
                new Cidade { EstadoId = 14, Nome = "Abaetetuba", Capital = false, CidadeId = 2419 },
                                                                                
                new Cidade { EstadoId = 15, Nome = "João Pessoa", Capital = true, CidadeId = 2656 },
                new Cidade { EstadoId = 15, Nome = "Aguiar", Capital = false, CidadeId = 2564 },
                                                                                
                new Cidade { EstadoId = 16, Nome = "Curitiba", Capital = true, CidadeId = 2880 },
                new Cidade { EstadoId = 16, Nome = "Agudos do Sul", Capital = false, CidadeId = 2788 },
                                                                                
                new Cidade { EstadoId = 17, Nome = "Recife", Capital = true, CidadeId = 3317 },
                new Cidade { EstadoId = 17, Nome = "Alagoinha", Capital = false, CidadeId = 3191 },
                                                                                
                new Cidade { EstadoId = 18, Nome = "Teresina", Capital = true, CidadeId = 3585 },
                new Cidade { EstadoId = 18, Nome = "Acauã", Capital = false, CidadeId = 3370 },
                                                                                
                new Cidade { EstadoId = 19, Nome = "Rio de Janeiro", Capital = true, CidadeId = 3661 },
                new Cidade { EstadoId = 19, Nome = "Angra dos Reis", Capital = false, CidadeId = 3594 },
                                                                                
                new Cidade { EstadoId = 20, Nome = "Natal", Capital = true, CidadeId = 3773 },
                new Cidade { EstadoId = 20, Nome = "Acari", Capital = false, CidadeId = 3686 },
                                                                                
                new Cidade { EstadoId = 21, Nome = "Porto Alegre", Capital = true, CidadeId = 4178 },
                new Cidade { EstadoId = 21, Nome = "Aceguá", Capital = false, CidadeId = 3853 },
                                                                                
                new Cidade { EstadoId = 22, Nome = "Porto Velho", Capital = true, CidadeId = 4386 },
                new Cidade { EstadoId = 22, Nome = "Alta Floresta d'Oeste", Capital = false, CidadeId = 4350 },
                                                                                
                new Cidade { EstadoId = 23, Nome = "Boa vista", Capital = true, CidadeId = 4404 },
                new Cidade { EstadoId = 23, Nome = "Alto Alegre", Capital = false, CidadeId = 4402 },
                                                                                
                new Cidade { EstadoId = 24, Nome = "Florianópolis", Capital = true, CidadeId = 4506 },
                new Cidade { EstadoId = 24, Nome = "Abdon Batista", Capital = false, CidadeId = 4417 },
                                                                                
                new Cidade { EstadoId = 25, Nome = "São Paulo", Capital = true, CidadeId = 5276 },
                new Cidade { EstadoId = 25, Nome = "São Vicente", Capital = false, CidadeId = 5283 },
                                                                                
                new Cidade { EstadoId = 26, Nome = "Aracaju", Capital = true, CidadeId = 5359 },
                new Cidade { EstadoId = 26, Nome = "Arauá", Capital = false, CidadeId = 5360 },
                                                                                
                new Cidade { EstadoId = 27, Nome = "Palmas", Capital = true, CidadeId = 5520 },
                new Cidade { EstadoId = 27, Nome = "Abreulândia", Capital = false, CidadeId = 5432 },
            };
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}