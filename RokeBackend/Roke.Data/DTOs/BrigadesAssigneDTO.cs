using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class BrigadesAssigneDTO
    {  
        public Guid brigadeId { get; set; }  
        
        public Guid[] tecnicosId { get; set; }
    }
}
