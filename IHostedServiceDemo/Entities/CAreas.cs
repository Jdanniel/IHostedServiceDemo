﻿using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class CAreas
    {
        public int IdArea { get; set; }
        public string DescArea { get; set; }
        public int? IdJefeArea { get; set; }
        public string Status { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}
