
using RokeBackend.core.Interface;
using RokeBackend.Model;
using RokeBackend.data.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RokeBackend.core.Contracts;
using Roke.Core.Model;

namespace RokeBackend.data.Services
{
    public class PlanningService : IPlanningService
    {
        private readonly IPlanningRepository _repo;

        public PlanningService(IPlanningRepository repo)
        {
            _repo = repo;
        }

        public Task<int> DeletePlanning(Guid id)
        {
            return _repo.RemovePlanning(id);

        }

      

        public IEnumerable<planning> GetAllPlannings()
        {
            return _repo.getAllPlannings();
        }

        public Task<planning> GetPlanningById(Guid id)
        {
            return _repo.getPlanningByIdAsync(id);
        }



        public Task<planning> SavePlanning(planning planning)
        {
            return _repo.CreatePlanning(planning);
        }

        public async Task<planning> UpdatePlaninng(planning planning)
        {
            return await _repo.UpdatePlanning(planning);
        }

        public Task<planning> UpdatePlanning(planning planning)
        {
            throw new NotImplementedException();
        }
    }
}
