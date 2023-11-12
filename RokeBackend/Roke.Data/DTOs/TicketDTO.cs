using Roke.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roke.Data.DTOs
{
    public class TicketDTO
    {
       
        public String description { get; set; }
        public String ticketType { get; set; }

        public Guid locationId { get; set; }
        public Guid assignedUserId { get; set; }
        public string contactName { get; set; }
        public string contactNumber { get; set; }
        public bool contactHasWhatsapp { get; set; }
        public Guid idmedia { get; set; }
    }
}
