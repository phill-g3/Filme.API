﻿using Filme.Domain;
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
        public FilmesRepository(IContext context) : base(context)
        {
        }
    }
}
