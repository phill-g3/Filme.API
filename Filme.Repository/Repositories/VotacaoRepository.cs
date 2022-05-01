using Filme.Domain;
using Filme.Domain.Votacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Repository.Repositories
{
    public class VotacaoRepository : BaseRepository, IVotacaoRepository
    {
        public VotacaoRepository(IContext context) : base(context)
        {
        }
    }
}
