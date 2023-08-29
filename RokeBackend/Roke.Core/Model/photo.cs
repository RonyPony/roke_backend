using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class Photo
    {
        [Key]
        public Guid id { get; set; }

        public byte[] ticketPhoto { get; set; }
    
    }
}
