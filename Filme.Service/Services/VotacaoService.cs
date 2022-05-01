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
    }
}
