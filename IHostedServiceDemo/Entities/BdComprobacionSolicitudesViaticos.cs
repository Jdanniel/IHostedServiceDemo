using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class BdComprobacionSolicitudesViaticos
    {
        public int IdComprobacionSolicitudesViaticos { get; set; }
        public int IdUsuarioSolicitado { get; set; }
        public decimal? MontoComprobado { get; set; }
        public DateTime FecCorteSolicitudesViaticos { get; set; }
        public string Status { get; set; }
    }
}
