using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class user
    {
        [Key]
        public Guid Id { get; set; }
        public int IdUser { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }
     
        public UsuarioStatus Statusuario { get; set; }
        public string contacto { get; set; }    
        public string username { get; set; }
        public string password { get; set; }
        public string rol { get; set; }
       

    }
}
