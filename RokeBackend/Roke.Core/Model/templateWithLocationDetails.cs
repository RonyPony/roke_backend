using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class templateWithLocationDetails
    {
        [Key]
        public Guid Id { get; set; }
       
        public String Name { get; set; }     
        
        public List<location> location { get; set; }

        public Status status { get; set; }

        public DateTime createOn { get; set; }
        public DateTime lastUpdate { get; set; }








    }
}
