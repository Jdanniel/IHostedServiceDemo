﻿using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class BdTempActualizaTipoPlazaCliente
    {
        public int Id { get; set; }
        public int? IdServicio { get; set; }
        public int? IdSegmento { get; set; }
        public int? IdTipoPlaza { get; set; }
        public int? IdTipoPlazaCliente { get; set; }
    }
}