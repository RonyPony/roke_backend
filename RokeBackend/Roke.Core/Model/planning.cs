using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class planning
    {
        [Key]
        public Guid Id { get; set; }
        public Guid idInventario  { get; set; }
        public Guid idMonth { get; set; }

       
      




    }
}
