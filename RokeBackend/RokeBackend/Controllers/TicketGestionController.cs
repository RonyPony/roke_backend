using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using Roke.Core.Enums;
using Roke.Core.Model;
using Roke.Data.DTOs;
using RokeBackend.core.Interface;
using RokeBackend.data.DTOs;
using RokeBackend.data.Services;
using RokeBackend.Model;
using System.Data.Entity.Core;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RokeBackend.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class TicketGestionController : ControllerBase
    {
        private readonly ITicketGestionService _TicketGestionService;
        private readonly IUserService _userService;
        private readonly IConfiguration _Configuration;

        public TicketGestionController(ITicketGestionService TicketGestionService, IConfiguration configuration, IUserService userService)
        {
            _TicketGestionService = TicketGestionService;
            _Configuration = configuration;
            _userService = userService;
        }


        // GET: api/<TicketController>
        [HttpGet]
        public IEnumerable<TicketGestion> Get()
        {
            return _TicketGestionService.getAllTicketGestion();
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public async Task<TicketGestion> GetAsync(Guid id)
        {
            return await _TicketGestionService.getGestionByIdAsync(id);
        }
   

        // GET api/<TicketController>/5
   

        // POST api/<TicketController>
        [HttpPost]
        public async Task<TicketGestion> PostAsync([FromBody] TicketGestionDTO value)
        {
            TicketGestion newTicket = new TicketGestion();
            newTicket.IdMedia = value.IdMedia;
            newTicket.IdFormulario = value.IdFormulario;
            newTicket.IdPlannig = value.IdPlannig;
            newTicket.CheckIn = DateTime.Now;
            newTicket.CheckStar = DateTime.Now;
            newTicket.CheckOut = DateTime.Now;
            newTicket.status = TicketStatus.Pending;

            return await _TicketGestionService.CreateGestion(newTicket);
        }

        // PUT api/<TicketController>/5
        [HttpPut("{id}")]
        public async Task<TicketGestion> PutAsync(int id, [FromBody] TicketGestion value)
        {
            return await _TicketGestionService.UpdateGestion(value);
        }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            int deleted = await _TicketGestionService.RemoveGestion(id);
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
