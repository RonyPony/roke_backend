
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
using Roke.Data.DTOs;
using RokeBackend.data.Repository;

namespace RokeBackend.data.Services
{
    public class TicketGestionService : ITicketGestionService
    {
        private readonly TicketGestionRepository _repo;
        


        public TicketGestionService(TicketGestionRepository repo)
        {
            _repo = repo;
        }

        public Task<int> RemoveGestion(Guid TicketId)
        {
            return _repo.RemoveGestion(TicketId);

        }

        public IEnumerable<TicketGestion> getAllTicketGestion()
        {
            return _repo.getAllTikecktGestion();
        }

        public async Task<TicketGestion> getGestionByIdAsync(Guid id)
        {
          
            return await _repo.getGestionByIdAsync(id);
        }



        public Task<TicketGestion> CreateGestion(TicketGestion Ticket)
        {
            return _repo.CreateGestion(Ticket);
        }
     

        public async Task<TicketGestion> UpdateGestion(TicketGestion Ticket)
        {
            return await _repo.UpdateGestion(Ticket);
        }

 
    }
}
