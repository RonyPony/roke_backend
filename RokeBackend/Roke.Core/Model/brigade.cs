﻿using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class brigade

    {
        [Key]
        public Guid Id { get; set; }
       
        public String Name { get; set; }     
        
     

        public Status status { get; set; }

        public DateTime createOn { get; set; }
        public DateTime lastUpdate { get; set; }








    }
}
