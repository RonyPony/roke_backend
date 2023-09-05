using Roke.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roke.Data.DTOs
{
    public class UsuarioDTO
    {

        public String nombre { get; set; }
        public String apellido { get; set; }
        public String cedula { get; set; }
        public String contacto { get; set; }
        public String rol { get; set; }
        public String status { get; set; }
        public string username { get; set; }
        
    }
}
