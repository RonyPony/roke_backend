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
    public interface IInventoryRepository
    {
        /// <summary>
        /// Register a new record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<Ticket> CreateInventory(Ticket Ticket);

        /// <summary>
        /// Register a new record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>


        public IEnumerable<Ticket> getAllPlannings();
        public Task<Ticket> getPlanningByIdAsync(Guid id);
        

        /// <summary>
        /// Update a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<Ticket> UpdatePlanning(Ticket Ticket);

        /// <summary>
        ///  Remove a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<int> RemovePlanning(Guid id);
    
    }
}
