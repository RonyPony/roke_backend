﻿using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class Inventory
    {
        [Key]
        public Guid Id { get; set; }
       
      
        public string sucursal { get; set; }
        public string ItemCode { get; set; }
        public string InstallDate { get; set; }
        public string Location_Conden { get; set; }
        public bool Status { get; set; }
        public string Serial { get; set; }
        public string Location_Evap { get; set; }
        public string Área_supply { get; set; }
        public string floor_Evap { get; set; }
        public string floor_Conden { get; set; }
        public string Model_Conden { get; set; }
        public string Model_evap { get; set; }
        public string item_type { get; set; }






    }
}
