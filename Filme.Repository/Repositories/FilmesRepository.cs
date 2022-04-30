using Filme.Domain;
using Filme.Domain.Filmes;
using Filme.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Repository.Repositories
{
    public class FilmesRepository : BaseRepository, IFilmesRepository 
    {

        public FilmesRepository(IContext context) : base(context, "Filmes")
        {
        }

        public async Task<Movie> GetMovie(int id)
        {
            var sql = @"SELECT *
                        FROM Filmes
                        WHERE Filmes.IdFilme = @Id";

            object dbParams = new { Id = id };
         

            return await _context.Get<Movie>(sql, dbParams);
        }

        
    }
}
