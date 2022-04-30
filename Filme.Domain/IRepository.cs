using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Domain
{
    public interface IRepository
    {
        Task<T> Get<T>(int id) where T : class, new();
        Task Post<T>(T entity);
        Task Put<T>(T entity);
        Task<T> Delete<T>(Guid id);
    }
}
