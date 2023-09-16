using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Roke.Core.Model;
using RokeBackend.core.Contracts;
using RokeBackend.data.DataContext;
using RokeBackend.Model;
using RokeBackend.data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roke.Data.DTOs;

namespace RokeBackend.data.Repository
{
    public class TemplateRepository : ITemplateRepository
    {
        private readonly RokeContext _context;
        public TemplateRepository(RokeContext ctx)
        {
            _context = ctx;

        }

        public async Task<TemplateLocationMapping> asignLocations(TemplateLocationMapping data)
        {
            try
            {
                _context.templateLocationMapping.Add(data);
                await _context.SaveChangesAsync();
                return data;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return data;
            }
        }

        public async Task<Template> CreateTemplate(Template Template)
        {
            Template plan = new Template();
            try
            {
                _context.template.Add(Template);
                await _context.SaveChangesAsync();
                plan = Template;
                return plan;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return plan;
            }
        }


        public IEnumerable<Template> getAllTemplates()
        {
            try
            {
                var Template = _context.template.ToList();
                return Template;
            }
            catch (Exception)
            {

                throw;
            }
        }

       

        public async Task<TemplateWithLocation> getTemplateByIdAsync(Guid id)
        {
            try
            {
                Template plan = await _context.template.FindAsync(id);
                TemplateWithLocation twl = new TemplateWithLocation();
                List<TemplateLocationMapping> x =  _context.templateLocationMapping.Where((e)=>e.TemplateId == id).ToList();

                twl.location = x;
                
                return twl;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<int> RemoveTemplate(Guid id)
        {
            try
            {
                try
                {
                    Template plan = await _context.template.FindAsync(id);
                    //_context.tickets.Remove(Ticket);
                    plan.status = Roke.Core.Enums.Status.Deleted;
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

    

      

  

     
      

     public async Task<Template> UpdateTemplate(Template Template)
        {
            try
            {
                
                 _context.template.Update(Template);
                await _context.SaveChangesAsync();
                return Template;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                return Template;
            }


        }

    }
}
