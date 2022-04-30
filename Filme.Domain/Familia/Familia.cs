using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Domain.Familia
{
    public class Familia
    {
        public Guid Id{ get; set; }
        public string Nome { get; set; }
        public Guid IdUsuario { get; set; }
    }
}
