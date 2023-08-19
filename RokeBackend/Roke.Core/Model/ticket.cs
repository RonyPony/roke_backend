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
        public Guid ticketTypeId { get; set;}
        public String contactName { get; set; }
        public String contactNumber { get; set; }
        public bool contactHasWhatsapp { get; set; }
    }
}
