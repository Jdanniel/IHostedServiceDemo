using System;
using System.Collections.Generic;

namespace IHostedServiceDemo.Entities
{
    public partial class BdUploadEstafeta
    {
        public int IdUploadEstafeta { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
