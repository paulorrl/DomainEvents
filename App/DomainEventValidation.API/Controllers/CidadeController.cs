using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using DomainEventValidation.Application.Interface;
using DomainEventValidation.API.Attributes;
using DomainEventValidation.API.Controllers.Base;

namespace DomainEventValidation.API.Controllers
{
    [RoutePrefix("api/v1/cidades")]
    public class CidadeController : BaseController
    {
        private readonly ICidadeApplicationService _cidadeApplicationService;

        public CidadeController(ICidadeApplicationService cidadeApplicationService)
        {
            _cidadeApplicationService = cidadeApplicationService;
        }

        [DeflateCompression]
        [Route(""), HttpGet]
        public Task<HttpResponseMessage> Cidades(int estadoId)
        {
            var listCidades = _cidadeApplicationService.GetByEstado(estadoId);
            return CreateResponse(HttpStatusCode.OK, listCidades);
        }
    }
}