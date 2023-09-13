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


        public IEnumerable<planning> getAllPlannings();
        public Task<planning> getPlanningByIdAsync(Guid id);
        

        /// <summary>
        /// Update a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<planning> UpdatePlanning(planning planning);

        /// <summary>
        ///  Remove a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<int> RemovePlanning(Guid id);
    
    }
}
