using Roke.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roke.Data.DTOs
{
    public class MonthDTO
    {
        public Guid Id { get; set; }
        public string Month { get; set; }
       // public TicketStatus ticketStatus { get; set; }
     /*   public String contactName { get; set; }
        public String contactNumber { get; set; }
        public bool contactHasWhatsapp { get; set; }
        public Guid locationId { get; set; }
        public Guid assignedUserId { get; set; }
        public Guid photoId1 { get; set; }
        public Guid photoId2 { get; set; }
        public Guid photoId3 { get; set; }*/
    }
}
