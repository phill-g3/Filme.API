using Filme.Domain.Votacao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Filme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VotacaoController : ControllerBase
    {
        private readonly IVotacaoService _votacaoService;
        public VotacaoController(IVotacaoService votacaoService)
        {
            _votacaoService = votacaoService;
        }
    }
}
