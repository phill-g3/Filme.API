using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Domain.Votacao
{
    public class VotacaoFilme
    {
        public int Id { get; set; }
        public Guid IdVotacao { get; set; }
        public int IdFilme { get; set; }
    }
}
