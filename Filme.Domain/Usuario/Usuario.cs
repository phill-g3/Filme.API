﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme.Domain.Usuario
{
    public class Usuario
    {
        public Guid IdUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
