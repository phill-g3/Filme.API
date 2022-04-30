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

        public async Task Delete(int id)
        {
            await _filmesRepository.Delete<Movie>(id);
        }

        public async Task<Movie> Get(int id)
        {
           return await _filmesRepository.Get<Movie>(id);
            
        }

        public async Task Post(Movie movie)
        {
            await _filmesRepository.Post<Movie>(movie);
        }

        public async Task Put(Movie movie)
        {
            await _filmesRepository.Put<Movie>(movie);
        }
    }
}
