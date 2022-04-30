using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Domain.Familia
{
    public interface IFamiliaService
    {
        Task<Familia> Get(Guid id);
        Task Post(Familia familia);
        Task Put(Familia familia);
        Task Delete(Guid id);
    }
}
