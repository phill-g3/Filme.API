using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Domain.Filmes
{
    public interface IFilmesService
    {
        Task<Movie> GetMovie(int id);
    }
}
