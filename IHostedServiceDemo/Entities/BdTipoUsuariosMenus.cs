﻿using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class BdTipoUsuariosMenus
    {
        public int IdTipoUsuariosMenus { get; set; }
        public int? IdTipoUsuario { get; set; }
        public int? IdMenu0 { get; set; }
        public int? IdMenu1 { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
