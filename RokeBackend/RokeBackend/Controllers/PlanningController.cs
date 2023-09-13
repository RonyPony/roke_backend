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
    public class PlanningController : ControllerBase
    {
        private readonly IPlanningService _PlanningService;
        private readonly IConfiguration _Configuration;

        public PlanningController(IPlanningService PlanningService, IConfiguration configuration)
        {
            _PlanningService = PlanningService;
            _Configuration = configuration;
        }


        // GET: api/<TicketController>
        [HttpGet]
        public IEnumerable<planning> Get()
        {
          
            return _PlanningService.GetAllPlannings();

        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public async Task<planning> GetAsync(Guid id )
        {
           return await _PlanningService.GetPlanningById(id); 
        }

        // POST api/<TicketController>
        [HttpPost]
        public async Task<planning> PostAsync([FromBody] PlanningDTO value)
        {
            planning newplan = new planning();
         
            newplan.Name = value.name;
            newplan.createOn = DateTime.Now;
            newplan.lastUpdate = DateTime.Now;


            newplan.status= Status.Active;
          

            return await _PlanningService.SavePlanning(newplan);
        }

        // PUT api/<TicketController>/5
        [HttpPut("{id}")]
        public async Task PutAsync(Guid id, [FromBody] PlanningDTO value )
        {
            planning newplan = new planning();
       newplan =  await _PlanningService.GetPlanningById(id);
       newplan.Name = value.name;
       newplan.lastUpdate = DateTime.Now;



       _PlanningService.UpdatePlanning(newplan);

        





    }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            int deleted = await _PlanningService.DeletePlanning(id);
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
