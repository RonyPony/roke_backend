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
    public interface ITicketRepository
    {
        /// <summary>
        /// Register a new record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<Ticket> CreateTicket(Ticket Ticket);

        public Task<Ticket> CreateAssignedTask(Ticket Ticket);

        /// <summary>
        /// Register a new record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>


        public IEnumerable<Ticket> getAllTickets();


        public Task<Ticket> getTicketByIdAsync(Guid id);

        public IEnumerable<Ticket> getTicketAssignedByUserId(Guid userId);

        /// <summary>
        /// Update a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<Ticket> UpdateTicket(Ticket Ticket);

        /// <summary>
        ///  Remove a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<int> RemoveTicket(Guid TicketId);
    
    }
}
