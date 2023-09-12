
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
        public IEnumerable<Inventory> GetAllPlannings();
        public Task<Inventory> GetPlanningById(Guid id);
      
        public Task<Inventory> SavePlanning(Inventory Inventory);
        public Task<Inventory> UpdatePlanning(Inventory Inventory);
        public Task<int> DeletePlanning(Guid Id);
        
    }
}
