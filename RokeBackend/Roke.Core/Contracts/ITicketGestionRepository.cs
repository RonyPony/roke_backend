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
    public interface ITicketGestionRepository
    {

        public Task<TicketGestion> CreateGestion(TicketGestion data);
        public IEnumerable<TicketGestion> getAllTikecktGestion();
        public Task<TicketGestion> getGestionByIdAsync(Guid id);
       // public Task<brigade> GetBrigadeById(Guid id);
        
        //public Task<Form> asignBrigades(brigadeAssigne data);
        //public Task<brigadeAssigne> asignBrigadesByTemplate(brigadeAssigne data);

        public Task<TicketGestion> UpdateGestion(TicketGestion data);
        public Task<int> RemoveGestion(Guid id);
    
    }
}
