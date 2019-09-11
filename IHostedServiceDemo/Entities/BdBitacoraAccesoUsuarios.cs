﻿using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class BdBitacoraAccesoUsuarios
    {
        public int IdBitacoraAccesoUsuario { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public DateTime? Fecha { get; set; }
        public string IpMachine { get; set; }
        public int? IsAccess { get; set; }
    }
}
