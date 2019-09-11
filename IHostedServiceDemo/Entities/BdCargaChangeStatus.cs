using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class BdCargaChangeStatus
    {
        public int IdCarga { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
