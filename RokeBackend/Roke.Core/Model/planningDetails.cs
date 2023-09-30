using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class planningDetails
    {
        [Key]
        public Guid Id { get; set; }
       
        public String Name { get; set; }
        public String idTemplate { get; set; }

        public List<brigade> Brigade { get; set; }
        public Status Status { get; set; }

        public DateTime createOn { get; set; }
        public DateTime lastUpdate { get; set; }








    }
}
