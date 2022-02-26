using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Filme.Domain.Filmes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Filme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FilmesController : ControllerBase
    {
        private readonly IFilmesService _filmesService;

        public FilmesController(IFilmesService filmesService)
        {
            _filmesService = filmesService;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            return Ok(await _filmesService.GetMovie(id));
        }

    }
}
