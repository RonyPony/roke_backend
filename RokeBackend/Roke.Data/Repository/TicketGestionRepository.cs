using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Roke.Core.Model;
using RokeBackend.core.Contracts;
using RokeBackend.data.DataContext;
using RokeBackend.core;
using RokeBackend.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roke.Core.Enums;

namespace RokeBackend.data.Repository
{
    public class TicketGestionRepository : ITicektGestionRepository
    {
        private readonly RokeContext _context;
        public TicketGestionRepository(RokeContext ctx)
        {
            _context = ctx;
        }
        public async Task<TicketGestion> CreateGestion(TicketGestion Ticket)
        {
            TicketGestion finalTicket = new TicketGestion();
            try
            {
                _context.ticketGestions.Add(Ticket);
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



        public IEnumerable<TicketGestion> getAllTikecktGestion()
        {
            try
            {
                var Tickets = _context.ticketGestions.ToList();
                return Tickets;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /*
        public IEnumerable<Ticket> getTicketAssignedByUserId(Guid userId)
        {
            IEnumerable<Ticket> tickets = _context.tickets.ToList().Where(e=>e.assignedUserId==userId);
            return tickets;
        }
        */
        public async Task<TicketGestion> getGestionByIdAsync(Guid id)
        {
            try
            {
                TicketGestion Ticket = await _context.ticketGestions.FindAsync(id);
                return Ticket;
            }
            catch (Exception)
            {

                throw;
            }
        }
        

        public async Task<int> RemoveGestion(Guid TicketId)
        {
            try
            {
                try
                {
                    TicketGestion Ticket = await _context.ticketGestions.FindAsync(TicketId);
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

        public async Task<TicketGestion> UpdateGestion(TicketGestion data)
        {
            try
            {

                _context.ticketGestions.Update(data);
                await _context.SaveChangesAsync();
                return data;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return data;
            }

        }

     
    }
}
