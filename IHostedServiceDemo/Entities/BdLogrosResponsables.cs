﻿using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class BdLogrosResponsables
    {
        public int IdLogrosResponsables { get; set; }
        public int? IdLogro { get; set; }
        public int? IdResponsable { get; set; }
        public int? IdArea { get; set; }
    }
}
