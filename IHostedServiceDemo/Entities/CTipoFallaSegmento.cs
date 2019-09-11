using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class CTipoFallaSegmento
    {
        public int IdTipoFallaSegmento { get; set; }
        public int? IdCliente { get; set; }
        public int? IdSegmento { get; set; }
        public int? IdTipoFalla { get; set; }
    }
}
