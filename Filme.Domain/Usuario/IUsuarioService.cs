using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Domain.Usuario
{
    public interface IUsuarioService
    {
        Task<Usuario> Get(Guid id);
        Task Post(Usuario usuario);
        Task Put(Usuario usuario);
        Task Delete(Guid id);

       
    }
}
