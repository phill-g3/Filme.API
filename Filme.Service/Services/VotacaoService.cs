using Filme.Domain.Filmes;
using Filme.Domain.Votacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Service.Services
{
    public class VotacaoService : BaseService, IVotacaoService
    {
        private readonly IVotacaoRepository _repository;
        public VotacaoService(IVotacaoRepository repository)
        {
            _repository = repository;
        }

        public Task AddFilme(Guid idVotacao, int idFilme)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> FinalizarVotacao(Guid idVotacao)
        {
            throw new NotImplementedException();
        }

        public Task<Votacao> GetVotacaoNaoFinalizada()
        {
            throw new NotImplementedException();
        }

        public Task<List<Votacao>> ListVotacoesFinalizadas()
        {
            throw new NotImplementedException();
        }

        public Task PrepararVotar(Guid idVotacao)
        {
            throw new NotImplementedException();
        }

        public Task Votar(Guid idUsuario, int idFilme)
        {
            throw new NotImplementedException();
        }
    }
}
