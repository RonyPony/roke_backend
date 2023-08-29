using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Roke.Core.Model;
using RokeBackend.core.Contracts;
using RokeBackend.data.DataContext;
using RokeBackend.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.data.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private readonly RokeContext _context;
        public TicketRepository(RokeContext ctx)
        {
            _context = ctx;
        }
        public async Task<Ticket> CreateTicket(Ticket Ticket)
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

      

        public IEnumerable<Ticket> getAllTickets()
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

        public IEnumerable<Ticket> getTicketAssignedByUserId(Guid userId)
        {
            IEnumerable<Ticket> tickets = _context.tickets.ToList().Where(e=>e.assignedUserId==userId);
            return tickets;
        }

        public async Task<Ticket> getTicketByIdAsync(Guid id)
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
        

        public async Task<int> RemoveTicket(Guid TicketId)
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

        public Task<Ticket> UpdateTicket(Ticket Ticket)
        {
            throw new NotImplementedException();
        }

    }
}
