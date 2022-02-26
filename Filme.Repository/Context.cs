using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Filme.Domain;
using Microsoft.Extensions.Configuration;

namespace Filme.Repository
{
    public class Context : IContext
    {

        private IConfiguration _config;

        public Context(IConfiguration config)
        {
            _config = config;
        }

        public async Task<List<T>> List<T>(string sql, object dbParams)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(_config["ConnectionString"]))
            {
                var retorno = await connection.QueryAsync<T>(sql, dbParams);
                return retorno.ToList();
            }
        }

        public async Task<T> Get<T>(string sql, object dbParams)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(_config["ConnectionString"]))
            {
                var retorno = await connection.QueryAsync<T>(sql, dbParams);
                return retorno.FirstOrDefault();
            }
        }

        public async Task Execute(string sql, object dbParams)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(_config["ConnectionString"]))
            {
                await connection.QueryAsync(sql, dbParams);
            }
        }
    }
}
