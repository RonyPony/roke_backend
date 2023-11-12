using Roke.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roke.Core.Model
{
    public class TicketGestion
    {
        [Key]
        public Guid Id { get; set; }
       
        public TicketStatus status { get; set; }

        public Guid IdPlannig { get; set; }
        public Guid IdMedia { get; set; }
        public Guid IdTecnico { get; set; }
        public Guid IdFormulario { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public DateTime CheckStar { get; set; }


    }
}
