
using Roke.Core.Model;
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.core.Interface
{
    public interface IAssignedTicketService
    {
        public IEnumerable<Ticket> GetAllAssignedTickets();
        public Task<Ticket> GetAssignedTicketById(Guid id);
        public Task<Ticket> GetAssignedTicketByIdUser(Guid assignedUserId);
        public Task<Ticket> SaveAssignedTicket(Ticket Ticket);
        public Task<Ticket> UpdateAssignedTicket(Ticket Ticket);
        public Task<int> DeleteAssignedTicket(Guid Id);
        
    }
}
