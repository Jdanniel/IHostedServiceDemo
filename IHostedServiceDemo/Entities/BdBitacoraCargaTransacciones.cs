﻿using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class BdBitacoraCargaTransacciones
    {
        public int IdBitacoraCargaTransacciones { get; set; }
        public int? IdCarga { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Status { get; set; }
    }
}
