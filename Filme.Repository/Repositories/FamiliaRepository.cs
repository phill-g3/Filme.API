using Filme.Domain;
using Filme.Domain.Familia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Repository.Repositories
{
    internal class FamiliaRepository : IFamiliaRepository
    {
        private readonly IContext _context;

        public FamiliaRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Familia> GetFamilia(Familia familia)
        {
            var sql = @"SELECT IdFamilia, Nome, IdUsuario 
                        FROM Familia
                        WHERE IdFamilia = @IdFamilia";

            object dbParams = new { IdFamilia = familia.idFamilia };

            return await _context.Get<Familia>(sql, dbParams);
        }
    }
}
