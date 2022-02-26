using Filme.Domain.Usuario;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Filme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<UsuarioLogin>> Login([FromBody]UsuarioLogin usuarioLogin)
        {
            var user = await _authService.Authenticate(usuarioLogin);

            if(user != null)
            {
                var token = await _authService.Generate(user);
                return Ok(token);
            }

            return NotFound();
        }

    }
}
