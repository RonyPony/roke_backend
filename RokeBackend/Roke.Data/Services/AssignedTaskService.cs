
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
    public class AssignedTaskService : IAssignedTicketService
    {
        private readonly IAssignedTaskRepository _repo;

        public AssignedTaskService(IAssignedTaskRepository repo)
        {
            _repo = repo;
        }

        public Task<int> DeleteAssignedTask(Guid TicketId)
        {
            return _repo.RemoveAssignedTask(TicketId);

        }

        public Task<int> DeleteAssignedTicket(Guid TicketId)
        {
            return _repo.RemoveAssignedTask(TicketId);
        }

        public IEnumerable<Ticket> GetAllAssignedTasks()
        {
            return _repo.getAllAssignedTasks();
        }

        public IEnumerable<Ticket> GetAllAssignedTickets()
        {
            return _repo.getAllAssignedTasks();
        }

        public Task<Ticket> GetAssignedTaskById(Guid id)
        {
            return _repo.getAssignedTaskByIdAsync(id);
        }
        public Task<Ticket> GetAssignedTicketByIdUser(Guid assignedUserId)
        {
            return _repo.getAssignedTaskByIdUserAsync(assignedUserId);
        }

        public Task<Ticket> GetAssignedTicketById(Guid id)
        {
            return _repo.getAssignedTaskByIdAsync(id);
        }

        public Task<Ticket> SaveAssignedTask(Ticket Ticket)
        {
            return _repo.CreateAssignedTask(Ticket);
        }

        public Task<Ticket> SaveAssignedTicket(Ticket Ticket)
        {
            return _repo.CreateAssignedTask(Ticket);
        }

        public async Task<Ticket> UpdateAssignedTicket(Ticket Ticket)
        {
            return await _repo.UpdateAssignedTask(Ticket); 
        }

        public Task<Ticket> UpdateAssignedTask(Ticket Ticket)
        {
            throw new NotImplementedException();
        }
    }
}
