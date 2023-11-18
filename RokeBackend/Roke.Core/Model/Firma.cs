using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class Firma

    {
        [Key]
        public Guid Id { get; set; }
       
        public String firma { get; set; }     
        
        public Guid IdUser { get; set; }

        public DateTime createOn { get; set; }
        public DateTime lastUpdate { get; set; }








    }
}
