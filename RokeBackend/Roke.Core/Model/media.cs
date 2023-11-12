using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class Media

    {
        [Key]
        public Guid Id { get; set; }          
        
        public string photo {  get; set; }
        public DateTime uploadDate { get; set; }
        public bool isDeleted { get; set; }

    }
}
