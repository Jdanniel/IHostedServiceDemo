﻿using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class BdRecepcionInsumos
    {
        public int IdRecepcionInsumo { get; set; }
        public int? IdOrdenCompra { get; set; }
        public int? IdInsumo { get; set; }
        public double? CantidadRecepcionada { get; set; }
    }
}