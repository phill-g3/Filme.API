using Filme.Domain.Filmes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Service.Services
{
    public class FilmesService : IFilmesService
    {
        private readonly IFilmesRepository _filmesRepository;

        public FilmesService(IFilmesRepository filmesRepository)
        {
            _filmesRepository = filmesRepository;
        }

        public async Task<Movie> GetMovie(int id)
        {
           return await _filmesRepository.GetMovie(id);
        }
    }
}
