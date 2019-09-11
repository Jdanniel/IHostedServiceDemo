﻿using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class CCalifJunta
    {
        public int IdCalifJunta { get; set; }
        public string CalifJunta { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Status { get; set; }
        public int? IdStatusJunta { get; set; }
    }
}
