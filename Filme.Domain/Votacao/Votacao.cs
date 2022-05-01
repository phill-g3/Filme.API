using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Domain.Votacao
{
    public class Votacao
    {
        public Guid Id { get; set; }
        public Guid IdFamilia { get; set; }
        public bool Finalizada { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
