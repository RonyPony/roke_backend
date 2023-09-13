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
        public String status { get; set; }
        public DateTime createOn { get; set; }
        public DateTime lastUpdate { get; set; }

    }
}
