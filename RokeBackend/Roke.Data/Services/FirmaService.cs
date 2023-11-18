
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
    public class FirmaService : IFirmaService
    {
        private readonly IFirmaRepository _repo;


     


        public FirmaService(IFirmaRepository repo)
        {
            _repo = repo;
        }

        public Task<Firma> CreateFirma(Firma data)
        {
            return _repo.CreateFirma(data);
        }

         public IEnumerable<Firma> getAllFirma()
          {
              return _repo.getAllFirma();
          }

        public Task<int> RemoveFirma(Guid id)
        {
            return _repo.RemoveFirma(id);

        }

        public Task<Firma> getFirmaByIdAsync(Guid id)
        {
            return _repo.getFirmaByIdAsync(id);
        }
        


        public async Task<Firma> UpdateFirma(Firma data)
        {
            return await _repo.UpdateFirma(data);
        }

      
    }
}
