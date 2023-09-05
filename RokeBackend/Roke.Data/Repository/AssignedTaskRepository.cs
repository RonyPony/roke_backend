using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Roke.Core.Model;
using RokeBackend.core.Contracts;
using RokeBackend.data.DataContext;
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.data.Repository
{
    public class    AssignedTaskRepository : IAssignedTaskRepository
    {
        private readonly RokeContext _context;
        public AssignedTaskRepository(RokeContext ctx)
        {
            _context = ctx;
        }
        public async Task<Ticket> CreateAssignedTask(Ticket Ticket)
        {
            Ticket finalTicket = new Ticket();
            try
            {
                _context.tickets.Add(Ticket);
                await _context.SaveChangesAsync();
                finalTicket= Ticket;
                return finalTicket;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return finalTicket;
            }
        }

      

        public IEnumerable<Ticket> getAllAssignedTasks()
        {
            try
            {
                var Tickets = _context.tickets.ToList();
                return Tickets;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Ticket> getAssignedTaskByIdAsync(Guid id)
        {
            try
            {
                Ticket Ticket = await _context.tickets.FindAsync(id);
                return Ticket;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<Ticket> getAssignedTaskByIdUserAsync(Guid assignedUserId)
        {
            try
            {
                Ticket Ticket = await _context.tickets.FindAsync(assignedUserId);
                return Ticket;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> RemoveAssignedTask(Guid TicketId)
        {
            try
            {
                try
                {
                    Ticket Ticket = await _context.tickets.FindAsync(TicketId);
                    //_context.tickets.Remove(Ticket);
                    Ticket.status = Roke.Core.Enums.TicketStatus.Deleted;
                    _context.SaveChanges();
                    return 1;
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<Ticket> UpdateAssignedTask(Ticket Ticket)
        {
            throw new NotImplementedException();
        }

    }
}
