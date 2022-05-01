using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Domain.Votacao
{
    public class Votos
    {
        public int IdVotacaoFilme { get; set; }
        public Guid IdUsuario { get; set; }
    }
}
