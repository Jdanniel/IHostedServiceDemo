﻿using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class BdBitacoraProcedure
    {
        public int IdBitacoraProcedure { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaUso { get; set; }
        public int? IdUsuario { get; set; }
    }
}
