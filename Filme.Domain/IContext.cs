using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Domain
{
    public interface IContext
    {
        Task<List<T>> List<T>(string sql, object dbParams);
        Task<T> Get<T>(string sql, object dbParams);
        Task Execute(string sql, object dbParams);
    }
}
