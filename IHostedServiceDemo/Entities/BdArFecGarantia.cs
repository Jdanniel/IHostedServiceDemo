﻿using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class BdArFecGarantia
    {
        public int IdArFecGarantia { get; set; }
        public int? IdAr { get; set; }
        public string Status { get; set; }
        public string Error { get; set; }
    }
}
