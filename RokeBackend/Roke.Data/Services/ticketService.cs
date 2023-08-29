
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
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _repo;

        public TicketService(ITicketRepository repo)
        {
            _repo = repo;
        }

        public Task<int> DeleteTicket(Guid TicketId)
        {
            return _repo.RemoveTicket(TicketId);

        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _repo.getAllTickets();
        }

        public IEnumerable<Ticket> GetTicketAssignedByUserId(Guid userId)
        {
            return _repo.getTicketAssignedByUserId(userId);
        }

        public Task<Ticket> GetTicketById(Guid id)
        {
            return _repo.getTicketByIdAsync(id);
        }



        public Task<Ticket> SaveTicket(Ticket Ticket)
        {
            return _repo.CreateTicket(Ticket);
        }

        public async Task<Ticket> UpdateTicket(Ticket Ticket)
        {
            return await _repo.UpdateTicket(Ticket);
        }
    }
}
