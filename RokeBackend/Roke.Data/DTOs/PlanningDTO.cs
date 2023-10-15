using Roke.Core.Enums;
using RokeBackend.Model;
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

        public LocationInfo[] locationInfo { get; set; }



    }
}
