﻿using Roke.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roke.Data.DTOs
{
    public class InventoryDTO
    {
  


        public Guid sucursal { get; set; }
        public string ItemCode { get; set; }
       // public string InstallDate { get; set; }
       // public string Location_Conden { get; set; }
        public string UbicacionInterna { get; set; }
        public string Capacidad { get; set; }
        public string Marca { get; set; }
        public string refrigerante { get; set; }
        public string equipo { get; set; }
        //public string Location_Evap { get; set; }
       // public string area_supply { get; set; }
       // public string floor_Evap { get; set; }
       // public string floor_Conden { get; set; }
        //public string Model_Conden { get; set; }
        //public string Model_evap { get; set; }
       // public string item_type { get; set; }


    }
}
