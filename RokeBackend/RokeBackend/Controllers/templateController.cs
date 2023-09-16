using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Roke.Core.Enums;
using Roke.Core.Model;
using Roke.Data.DTOs;
using RokeBackend.core.Interface;
using RokeBackend.data.DTOs;
using RokeBackend.data.Services;
using RokeBackend.Model;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RokeBackend.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class templateController : ControllerBase
    {
        private readonly ITemplateService _TemplateService;
        private readonly IConfiguration _Configuration;

        public templateController(ITemplateService TemplateService, IConfiguration configuration)
        {
            _TemplateService = TemplateService;
            _Configuration = configuration;
        }


        // GET: api/<TicketController>
        [HttpGet]
        public IEnumerable<Template> Get()
        {
          
            return _TemplateService.GetAllTemplates();

        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public async Task<TemplateWithLocation> GetAsync(Guid id )
        {
           return await _TemplateService.GetTemplateById(id); 
        }

        // POST api/<TicketController>
        [HttpPost]
        public async Task<Template> PostAsync([FromBody] TemplateDTO value)
        {
            Template tmp = new Template();
            tmp.Name = value.name;
            tmp.createOn = DateTime.Now;
            tmp.lastUpdate=DateTime.Now;
            tmp.status = Status.Active;
            return await _TemplateService.SaveTemplate(tmp);
        }


        // POST api/<TicketController>
        [HttpPost("asign")]
        public async Task<TemplateLocationMappingDTO> asign([FromBody] TemplateLocationMappingDTO value)
        {
            TemplateLocationMappingDTO finalList = new TemplateLocationMappingDTO();
            foreach (var item in value.LocationId)
            {
                TemplateLocationMapping newplan = new TemplateLocationMapping();
                newplan.LocationId = item;
                newplan.TemplateId = value.TemplateId;
               
                try
                {
                   await _TemplateService.AsignLocations(newplan);
                }
                catch (Exception ex)
                {

                    throw;
                }
            }

            return value;
        }

        

// PUT api/<TicketController>/5
[HttpPut("{id}")]
        public async Task PutAsync(Guid id, [FromBody] TemplateDTO value )
        {
            Template newplan = new Template();
       newplan.Name = value.name;
       newplan.lastUpdate = DateTime.Now;



       _TemplateService.UpdateTemplate(newplan);

        





    }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            int deleted = await _TemplateService.DeleteTemplate(id);
            if (deleted == 0)
            {
                return BadRequest("Could not delete this ticket");
            }
            else
            {
                return Ok("deleted");
            }
        }
    }
}
