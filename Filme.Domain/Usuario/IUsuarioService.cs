using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Domain.Usuario
{
    public interface IUsuarioService
    {
        Usuario Get(int id);
        Usuario Post(Usuario usuario);
        Usuario Put(Usuario usuario);
        Usuario Delete(int id);

       
    }
}
