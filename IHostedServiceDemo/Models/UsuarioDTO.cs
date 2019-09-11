using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHostedServiceDemo.Models
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Username { get; set; }
    }
}
