using Filme.Domain.Usuario;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Filme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<ActionResult> Get(Guid Id)
        {
            return Ok(await _usuarioService.Get(Id));
        }

        [HttpPost]
        public async Task<ActionResult> Post(Usuario usuario)
        {
            await _usuarioService.Post(usuario);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(Usuario usuario)
        {
            await _usuarioService.Put(usuario);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(Guid Id)
        {
            await _usuarioService.Delete(Id);
            return Ok();
        }

    }
}
