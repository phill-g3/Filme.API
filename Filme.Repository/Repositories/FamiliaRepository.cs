using Filme.Domain;
using Filme.Domain.Familia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Repository.Repositories
{
    public class FamiliaRepository : BaseRepository, IFamiliaRepository
    {
        public FamiliaRepository(IContext context) : base(context)
        {
        }
       
    }
}
