
using Roke.Core.Model;
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.core.Interface
{
    public interface IPlanningService
    {
        public Task<planningDetails> GetAllPlannings();
        public Task<planningDetails> GetPlanningById(Guid id);
  

        public Task<planning> SavePlanning(planning planning);

        public Task<planning> getPlanningById(Guid id);
        public Task<planning> UpdatePlanning(planning planning);
        public Task<int> DeletePlanning(Guid Id);
        
    }
}
