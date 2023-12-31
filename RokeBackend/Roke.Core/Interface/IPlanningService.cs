﻿
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
        public Task<List<List<planning>>> GetAllPlannings();
        public Task<planningDetails> GetPlanningById(Guid id);
        public Task<IEnumerable<planningCalendar>> getAllPlanningforCalendar();

        public Task<planning> SavePlanning(planning planning);

       // public Task<planning> getPlanningByIdMonthAsync(Guid id);
        public Task<planning> getPlanningById(Guid id);
        public Task<planning> UpdatePlanning(planning planning);
        public Task<int> DeletePlanning(Guid Id);
        
    }
}
