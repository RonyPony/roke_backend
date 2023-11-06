using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class planningCalendar
    {
       
        public Guid id { get; set; }
        public string title { get; set; }   
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public string className { get; set; }

   








    }
}
