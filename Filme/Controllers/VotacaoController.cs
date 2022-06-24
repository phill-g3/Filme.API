using Filme.Domain.Votacao;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Filme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class VotacaoController : ControllerBase
    {
        private readonly IVotacaoService _votacaoService;
        public VotacaoController(IVotacaoService votacaoService)
        {
            _votacaoService = votacaoService;
        }

        [HttpGet("GetVotacaoNaoFinalizada")]
        public async Task<ActionResult> GetVotacaoNaoFinalizada()
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult> ListVotacoesFinalizadas()
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult> AddFilme(Guid idVotacao, int idFilme)
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult> PrepararVotar(Guid idVotacao)
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult> Votar(Guid idUsuario, int idFilme)
        {
            throw new NotImplementedException();
        }
        public async Task<ActionResult> FinalizarVotacao(Guid idVotacao)
        {
            throw new NotImplementedException();
        }
    }
}
