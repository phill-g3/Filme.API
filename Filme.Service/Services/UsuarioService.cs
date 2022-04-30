using Filme.Domain.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task Delete(Guid id)
        {
            await _usuarioRepository.Delete<Usuario>(id);
        }

        public async Task<Usuario> Get(Guid id)
        {
           return await _usuarioRepository.Get<Usuario>(id);
        }

        public async Task Post(Usuario usuario)
        {
            await _usuarioRepository.Post(usuario);
        }

        public async Task Put(Usuario usuario)
        {
            await _usuarioRepository.Put(usuario);
        }
    }
}
