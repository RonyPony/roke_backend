using Roke.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roke.Data.DTOs
{
    public class LocationDTO
    {
        
        public String sucursal { get; set; }
        public String latitude { get; set; }
        public String longitude { get; set; }
        public String status { get; set; }
    }
}
