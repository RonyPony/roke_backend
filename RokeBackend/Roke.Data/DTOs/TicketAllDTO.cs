using Roke.Core.Enums;
using Roke.Core.Model;
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roke.Data.DTOs
{
    public class TicketAllDTO
    {
       
        public location location { get; set; }
        public Media media { get; set; }
        public user user { get; set; }
        public Ticket Ticket { get; set; }
      
    }
}
