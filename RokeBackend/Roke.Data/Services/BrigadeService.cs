
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
    public class BrigadeService : IBrigadeService
    {
        private readonly IBrigadeRepository _repo;


     


        public BrigadeService(IBrigadeRepository repo)
        {
            _repo = repo;
        }

        public Task<brigadeAssigne> AsignBrigade(brigadeAssigne data)
        {
            return _repo.asignBrigades(data);
        }

        public Task<brigadeAssigne> asignBrigadesByTemplate(brigadeAssigne data)
        {
            throw new NotImplementedException();
        }

        public Task<brigadeAssigne> AsignBrigadez(brigadeAssigne id)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteBrigade(Guid id)
        {
            return _repo.RemoveBrigade(id);

        }

      

        public IEnumerable<brigade> GetAllBrigades()
        {
            return _repo.getAllBrigades();
        }

        public Task<brigadeDetails> getBrigadeByIdByTechAsync(Guid id)
        {
            return _repo.getBrigadeByIdByTechAsync(id);
        }
        

          public Task<brigade> GetBrigadeById(Guid id)
        {
            return _repo.GetBrigadeById(id);
        }

        public Task<brigadeDetails> GetTemplateById(Guid id)
        {
            return _repo.getBrigadeByIdByTechAsync(id);
        }



        public Task<brigade> SaveBrigade(brigade brigade)
        {
            return _repo.CreateBrigade(brigade);
        }

        public async Task<brigade> UpdateBrigade(brigade brigade)
        {
            return await _repo.UpdateBrigade(brigade);
        }

        public Task<Template> UpdateTemplate(Template Template)
        {
            throw new NotImplementedException();
        }
    }
}
