
using Roke.Core.Model;
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.core.Interface
{
    public interface IBrigadeService
    {
        public IEnumerable<brigade> GetAllBrigades();
        public Task<brigadeDetails> getBrigadeByIdByTechAsync(Guid id);
        public Task<brigade> GetBrigadeById(Guid id);
        public Task<brigadeAssigne> AsignBrigade(brigadeAssigne id);
        public Task<brigadeAssigne> asignBrigadesByTemplate(brigadeAssigne data);
        public Task<brigade> SaveBrigade(brigade brigade);
        public Task<brigade> UpdateBrigade(brigade brigade);
        public Task<int> DeleteBrigade(Guid Id);
        
    }
}
