using Filme.Domain;
using Filme.Domain.Familia;
using Filme.Domain.Filmes;
using Filme.Domain.Usuario;
using Filme.Repository;
using Filme.Repository.Repositories;
using Filme.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Filme.ExtensionMethods
{
    public static class DependencyInjection
    {
        public static IServiceCollection InjectDependecies(this IServiceCollection services)
        {
            //Services
            services.AddTransient<IFilmesService, FilmesService>();
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IFamiliaService, FamiliaService>();


            //Repositories
            services.AddScoped<IContext, Context>();
            services.AddScoped<IFilmesRepository, FilmesRepository>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IFamiliaRepository, FamiliaRepository>();

            return services;
        }
    }
}
