using Roke.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace RokeBackend.Model
{
    public class BrigadesDTO
    {
        public String Name { get; set; }



        public Status status { get; set; }

        public DateTime createOn { get; set; }
        public DateTime lastUpdate { get; set; }
    }
}
