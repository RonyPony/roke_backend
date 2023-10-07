
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
    public class PlanService : IPlanningService
    {
        private readonly IPlanningRepository _repo;


     


        public PlanService(IPlanningRepository repo)
        {
            _repo = repo;
        }

     
        public Task<planning> SavePlanning(planning id)
        {
            return _repo.asignplannings(id);
        }

        public Task<int> DeletePlanning(Guid id)
        {
            return _repo.RemovePlanning(id);

        }


        public IEnumerable<planning> GetAllPlannings()
        {
            return _repo.getAllPlannings();
        }

       

     


        public Task<planningDetails> GetPlanningById(Guid id)
        {
            return _repo.getPlanningByIdAsync(id);
        }


        public  Task<planning> getPlanningById(Guid id)
        {
            return _repo.getPlanningById(id);
        }




        public async Task<planning> UpdatePlanning(planning planning)
        {
            return await _repo.UpdatePlanning(planning);
        }

      
    }
}
