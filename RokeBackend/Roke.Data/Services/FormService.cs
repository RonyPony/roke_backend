
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
    public class FormService : IFormService
    {
        private readonly IFormRepository _repo;


     


        public FormService(IFormRepository repo)
        {
            _repo = repo;
        }

        public Task<Form> CreateForm(Form data)
        {
            return _repo.CreateForm(data);
        }

   

        public Task<int> RemoveForm(Guid id)
        {
            return _repo.RemoveForm(id);

        }

      

       /* public IEnumerable<brigade> GetAllBrigades()
        {
            return _repo.getAllBrigades();
        }*/

        public Task<Form> getFormByIdAsync(Guid id)
        {
            return _repo.getFormByIdAsync(id);
        }
        


        public async Task<Form> UpdateForm(Form data)
        {
            return await _repo.UpdateForm(data);
        }

      
    }
}
