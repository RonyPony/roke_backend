
using Roke.Core.Model;
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.core.Interface
{
    public interface ITemplateService
    {
        public IEnumerable<Template> GetAllTemplates();
        public Task<templateWithLocationDetails> GetTemplateById(Guid id);
        public Task<TemplateLocationMapping> AsignLocations(TemplateLocationMapping id);

        public Task<Template> SaveTemplate(Template Template);
        public Task<Template> UpdateTemplate(Template Template);
        public Task<int> DeleteTemplate(Guid Id);
        
    }
}
