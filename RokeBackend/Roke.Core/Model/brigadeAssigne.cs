using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class brigadeAssigne
    {
        [Key]
        public Guid Id { get; set; }
       
        public Guid brigadeId { get; set; }  
        
        public Guid tecnicosId { get; set; }
    }
}
