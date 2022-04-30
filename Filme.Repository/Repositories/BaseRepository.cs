using Filme.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Repository.Repositories
{
    public abstract class BaseRepository
    {
        public readonly IContext _context;
        private readonly string _className;

        public BaseRepository(IContext context, string className)
        {
            _context = context;
            _className = className;
        }
        public virtual async Task<T> Get<T>(int id) where T : class, new()
        { 
            var tipo = new T().GetType();
            string tableName = GetTableName(tipo.Name);

            string sql = $"SELECT * FROM {tableName} WHERE Id{tableName} = @id";

            object dbParams = new {Id = id};    

            return await _context.Get<T>(sql, dbParams);

        }

        public virtual async Task Post<T>(T entity) 
        {
            try
            {
                var tipo = entity.GetType();
                string tableName = GetTableName(tipo.Name);

                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($"INSERT INTO {tableName} VALUES(");

                var props = tipo.GetProperties();
                var i = props.Count();

                for (int p = 0; p < i; p++)
                {
                    if (props[p].Name.Contains("Id")) continue;

                    if (p == i - 1)
                    {
                        stringBuilder.Append($"'{props[p].GetValue(entity)}')");
                    }
                    else
                    {
                        stringBuilder.Append($"'{props[p].GetValue(entity)}',");
                    }
                }

                string sql = stringBuilder.ToString();

                await _context.Execute(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual async Task Put<T>(T entity)
        {
            try
            {
                var tipo = entity.GetType();
                string tableName = GetTableName(tipo.Name);

                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($"UPDATE {tableName} SET ");

                var props = tipo.GetProperties();
                var i = props.Count();
                string id = string.Empty;

                for (int p = 0; p < i; p++)
                {
                    if (props[p].Name.Contains("Id"))
                    {
                        id = props[p].GetValue(entity).ToString();
                        continue;
                    }

                    if (p == i - 1)
                    {
                        stringBuilder.Append($"{props[p].Name} = '{props[p].GetValue(entity)}'");
                    }
                    else
                    {
                        stringBuilder.Append($"{props[p].Name} = '{props[p].GetValue(entity)}', ");
                    }
                }

                stringBuilder.Append($" WHERE Id{tableName} = {id}");
                string sql = stringBuilder.ToString();

                await _context.Execute(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        public virtual async Task Delete<T>(Guid id) where T : class, new()
        {
            var tipo = new T().GetType();
            string tableName = GetTableName(tipo.Name);

            string sql = $"DELETE FROM {tableName} WHERE Id{tableName} = @id";

            object dbParams = new { Id = id };

            await _context.Execute(sql);
        }

        private string GetTableName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name"); 

            switch (name)
            {
                case "Movie":
                    return "Filmes";
                default:
                    return name;
            }
        }

    }
}
