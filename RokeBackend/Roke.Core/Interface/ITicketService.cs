
using Roke.Core.Model;
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.core.Interface
{
    public interface ITicketService
    {
        public IEnumerable<Ticket> GetAllTickets();
        public Task<Ticket> GetTicketById(Guid id);
        public Task<Ticket> SaveTicket(Ticket Ticket);
        public Task<Ticket> UpdateTicket(Ticket Ticket);
        public Task<int> DeleteTicket(Guid TicketId);
        
    }
}
