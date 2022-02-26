using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filme.Domain;
using Filme.Domain.Usuario;

namespace Filme.Repository.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly IContext _context;
        public AuthRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Usuario> FindByLogin(UsuarioLogin usuarioLogin)
        {
            var sql = @"SELECT * 
                        FROM Usuario
                        WHERE Login = @Login AND Senha = @Senha";

            object dbParams = new {Login = usuarioLogin.Login, Senha = usuarioLogin.Senha};

            return await _context.Get<Usuario>(sql, dbParams);
        }
    }
}
