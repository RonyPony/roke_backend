using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class planning
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Idlocation { get; set; }
        public string sucursal { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public UsuarioStatus status { get; set; }
      




    }
}
