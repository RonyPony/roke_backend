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
    public class BrigadeController : ControllerBase
    {
        private readonly IBrigadeService _BrigadeService;
        private readonly IConfiguration _Configuration;

        public BrigadeController(IBrigadeService BrigadeService, IConfiguration configuration)
        {
            _BrigadeService = BrigadeService;
            _Configuration = configuration;
        }


        // GET: api/<TicketController>
        [HttpGet]
        public IEnumerable<brigade> Get()
        {
          
            return _BrigadeService.GetAllBrigades();

        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public async Task<brigadeDetails> GetAsync(Guid id )
        {
           return await _BrigadeService.GetBrigadeById(id); 
        }

        // POST api/<TicketController>
        [HttpPost]
        public async Task<brigade> PostAsync([FromBody] BrigadesDTO value)
        {
            brigade tmp = new brigade();
            tmp.Name = value.Name;
            tmp.createOn = DateTime.Now;
            tmp.lastUpdate=DateTime.Now;
            tmp.status = Status.Active;
            return await _BrigadeService.SaveBrigade(tmp);
        }


        // POST api/<TicketController>
        [HttpPost("asign")]
        public async Task<BrigadesAssigneDTO> asign([FromBody] BrigadesAssigneDTO value)
        {
            BrigadesAssigneDTO finalList = new BrigadesAssigneDTO();
            foreach (var item in value.tecnicosId)
            {
                brigadeAssigne newplan = new brigadeAssigne();
                newplan.tecnicosId = item;
                newplan.brigadeId = value.brigadeId;
               
                try
                {
                   await _BrigadeService.AsignBrigade(newplan);
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
        public async Task PutAsync(Guid id, [FromBody] BrigadesDTO value )
        {
            brigade newplan = new brigade();
       newplan.Name = value.Name;
       newplan.lastUpdate = DateTime.Now;



       _BrigadeService.UpdateBrigade(newplan);

        





    }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            int deleted = await _BrigadeService.DeleteBrigade(id);
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
