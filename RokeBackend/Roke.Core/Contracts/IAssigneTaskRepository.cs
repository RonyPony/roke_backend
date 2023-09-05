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
    public interface IAssignedTaskRepository
    {
        /// <summary>
        /// Register a new record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<Ticket> CreateAssignedTask(Ticket Ticket);

        /// <summary>
        /// Register a new record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>


        public IEnumerable<Ticket> getAllAssignedTasks();
        public Task<Ticket> getAssignedTaskByIdAsync(Guid id);
        public Task<Ticket> getAssignedTaskByIdUserAsync(Guid assignedUserId);

        /// <summary>
        /// Update a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<Ticket> UpdateAssignedTask(Ticket Ticket);

        /// <summary>
        ///  Remove a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<int> RemoveAssignedTask(Guid id);
    
    }
}
