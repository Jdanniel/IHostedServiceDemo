﻿using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class BdConfigureCausaCancelacion
    {
        public int IdConfigureCausaCancelacion { get; set; }
        public int? IdCausaCancelacion { get; set; }
        public string Status { get; set; }
        public int? IsActivo { get; set; }
        public DateTime? FechaAlta { get; set; }
    }
}
