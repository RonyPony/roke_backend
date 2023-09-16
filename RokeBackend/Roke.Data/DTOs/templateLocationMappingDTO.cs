using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class TemplateLocationMappingDTO
    {  
        public Guid TemplateId { get; set; }  
        
        public Guid[] LocationId { get; set; }
    }
}
