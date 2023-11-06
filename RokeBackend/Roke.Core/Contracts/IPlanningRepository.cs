using Microsoft.AspNetCore.Mvc;
using Roke.Core.Model;
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.core.Contracts
{
    public interface IPlanningRepository
    {
        /// <summary>
        /// Register a new record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<planning> CreatePlanning(planning planning);

        /// <summary>
        /// Register a new record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>

        public Task<List<List<planning>>> getAllPlannings();
        public IEnumerable<planning> getAllPlanningforCalendar();
        public Task<planningDetails> getPlanningByIdAsync(Guid id);
        public Task<planning> getPlanningById(Guid id);
        public Task<planning> asignplannings(planning data);
        

        /// <summary>
        /// Update a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<planning> UpdatePlanning(planning brigade);

        /// <summary>
        ///  Remove a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<int> RemovePlanning(Guid id);
    
    }
}
