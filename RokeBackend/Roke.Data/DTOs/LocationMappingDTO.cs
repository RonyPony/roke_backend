using Roke.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roke.Data.DTOs
{
    public class LocationMappingDTO
    {
        public Guid idLocation {  get; set; }
        public Guid[] idInventary { get; set; }
     
    }
}
