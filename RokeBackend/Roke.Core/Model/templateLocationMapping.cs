using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class TemplateLocationMapping
    {
        [Key]
        public Guid Id { get; set; }
       
        public Guid TemplateId { get; set; }  
        
        public Guid LocationId { get; set; }
    }
}
