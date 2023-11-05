using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class locationMapping
    {
        [Key]
        public Guid Id { get; set; }
       
        public Guid idlocation { get; set; }
        public Guid idInventory { get; set; }





    }
}
