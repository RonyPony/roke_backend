using Roke.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roke.Data.DTOs
{
    public class PlanningDTO
    {
        public String name { get; set; }

        public String idMoth { get; set; }
        public String idTemplate { get; set; }

        public Guid[] idBrigade { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime finalDate { get; set; }

    }
}
