﻿using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class BdModeloCategoria
    {
        public int IdModeloCategoria { get; set; }
        public int? IdModelo { get; set; }
        public int? IdCategoria { get; set; }
    }
}
