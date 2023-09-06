using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class Inventory
    {
        [Key]
        public Guid Id { get; set; }
       
      
        public string sucursal { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public LocationStatus status { get; set; }
        public String contactName { get; set; }
        public String contactNumber { get; set; }
        public bool contactHasWhatsapp { get; set; }





    }
}
