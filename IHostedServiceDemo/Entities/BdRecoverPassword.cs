﻿using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class BdRecoverPassword
    {
        public int IdRecoveryPassword { get; set; }
        public int? IdUsuario { get; set; }
        public string TemporaryPassword { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}