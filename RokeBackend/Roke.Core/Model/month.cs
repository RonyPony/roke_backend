using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class month
    {
        [Key]
        public Guid id { get; set; }
        public string Month { get; set; }
    
    }
}
