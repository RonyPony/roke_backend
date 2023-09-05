using Roke.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roke.Core.Model
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public TicketStatus status { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime updatedOn { get; set; }
        public String description { get; set; }
        public String ticketType { get; set;}
       
        public Guid locationId { get; set; }
        public Guid assignedUserId { get; set; }
        public Guid photoId1 { get; set; }
        public Guid photoId2 { get; set; }
        public Guid photoId3 { get; set; }

    }
}
