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
        Task<T> Get<T>(Guid id) where T : class, new();
        Task Post<T>(T entity);
        Task Put<T>(T entity);
        Task Delete<T>(int id) where T : class, new();
        Task Delete<T>(Guid id) where T : class, new();
    }
}
