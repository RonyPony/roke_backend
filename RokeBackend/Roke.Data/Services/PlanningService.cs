
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
    public class TemplateService : ITemplateService
    {
        private readonly ITemplateRepository _repo;


     


        public TemplateService(ITemplateRepository repo)
        {
            _repo = repo;
        }

        public Task<TemplateLocationMapping> AsignLocations(TemplateLocationMapping id)
        {
            return _repo.asignLocations(id);
        }

        public Task<int> DeleteTemplate(Guid id)
        {
            return _repo.RemoveTemplate(id);

        }

      

        public IEnumerable<Template> GetAllTemplates()
        {
            return _repo.getAllTemplates();
        }

        public Task<TemplateWithLocation> GetTemplateById(Guid id)
        {
            return _repo.getTemplateByIdAsync(id);
        }



        public Task<Template> SaveTemplate(Template Template)
        {
            return _repo.CreateTemplate(Template);
        }

        public async Task<Template> UpdatePlaninng(Template Template)
        {
            return await _repo.UpdateTemplate(Template);
        }

        public Task<Template> UpdateTemplate(Template Template)
        {
            throw new NotImplementedException();
        }
    }
}
