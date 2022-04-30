using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Filme.Domain.Filmes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Filme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class FilmesController : ControllerBase
    {
        private readonly IFilmesService _filmesService;

        public FilmesController(IFilmesService filmesService)
        {
            _filmesService = filmesService;
        }

        [HttpGet]
        public async Task<ActionResult<Movie>> Get(int id)
        {
            return Ok(await _filmesService.Get(id));
        }

        [HttpPost]
        public async Task<ActionResult> Post(Movie movie)
        {
            await _filmesService.Post(movie);
            return Ok();

        }

        [HttpPut]
        public async Task<ActionResult> Put(Movie movie)
        {
            await _filmesService.Put(movie);
            return Ok();

        }

    }
}
