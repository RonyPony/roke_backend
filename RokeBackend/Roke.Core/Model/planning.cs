using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class planning
    {
        [Key]
        public Guid Id { get; set; }
       public Guid IdPlan { get; set; }
        public String Name { get; set; }
        public Guid idMonth { get; set; }
        public Guid idTemplate { get; set; }
        public Guid idLocation { get; set; }
        public Guid idBrigade { get; set; }   
        public Status Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime finalDate { get; set; }

        public DateTime createOn { get; set; }
        public DateTime lastUpdate { get; set; }








    }
}
