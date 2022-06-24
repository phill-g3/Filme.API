using Filme.Domain.Filmes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Domain.Votacao
{
    public interface IVotacaoService
    {
        Task<Votacao> GetVotacaoNaoFinalizada();
        Task<List<Votacao>> ListVotacoesFinalizadas();
        Task AddFilme(Guid idVotacao, int idFilme);
        Task PrepararVotar(Guid idVotacao);
        Task Votar(Guid idUsuario, int idFilme);
        Task<Movie> FinalizarVotacao(Guid idVotacao);
    }
}
