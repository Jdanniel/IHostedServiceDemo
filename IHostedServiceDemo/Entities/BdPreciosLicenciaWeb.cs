﻿using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class BdPreciosLicenciaWeb
    {
        public int IdPrecioLicencia { get; set; }
        public string RangoLicencia { get; set; }
        public decimal? CostoMensual { get; set; }
    }
}
