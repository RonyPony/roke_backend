using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class LocationInfo
    {
        [Key]
    
        public Guid idLocation { get; set; }
        public Guid idBrigade { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime finalDate { get; set; }


      








    }
}
