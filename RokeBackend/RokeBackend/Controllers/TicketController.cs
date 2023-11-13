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
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _TicketService;
        private readonly IUserService _userService;
        private readonly IConfiguration _Configuration;

        public TicketController(ITicketService TicketService, IConfiguration configuration, IUserService userService)
        {
            _TicketService = TicketService;
            _Configuration = configuration;
            _userService = userService;
        }


        // GET: api/<TicketController>
        [HttpGet]
        public IEnumerable<Ticket> Get()
        {
            return _TicketService.GetAllTickets();
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public async Task<Ticket> GetAsync(Guid id)
        {
            return await _TicketService.GetTicketById(id);
        }
        [HttpGet("details")]
        public async Task<Ticket> GetAllsync(Guid id )
        {

            return await _TicketService.GetTicketById(id);
        }

        // GET api/<TicketController>/5
        [HttpGet("/assignedByUserId{userId}")]
        public async Task<IEnumerable<Ticket>> getTicketAssignedByUserIdAsync(Guid userId)
        {
            user foundUser = await _userService.GetUserById(userId);
            if (foundUser == null)
            {
         //       return await IEnumerable<Ticket>();
            }
            return  _TicketService.GetTicketAssignedByUserId(userId);
        }

        // POST api/<TicketController>
        [HttpPost]
        public async Task<Ticket> PostAsync([FromBody] TicketDTO value)
        {
            
            Ticket newTicket = new Ticket();
           
            newTicket.description = value.description;
            newTicket.contactName = value.contactName;
            newTicket.contactNumber = value.contactNumber;
            newTicket.contactHasWhatsapp = value.contactHasWhatsapp;
            newTicket.locationId = value.locationId;
            newTicket.createdOn = DateTime.Now;
            newTicket.updatedOn = DateTime.Now;
            newTicket.ticketType= value.ticketType;
            newTicket.status = TicketStatus.Pending;
            newTicket.assignedUserId = value.assignedUserId;
            newTicket.idmedia = value.idmedia;
            newTicket.brigadeId = value.brigadeId;

            return await _TicketService.SaveTicket(newTicket);
        }

        [HttpPost("AssignTicket")]
        public async Task<Ticket> PostAssignedAsync([FromBody] AssignedTaskDTO value)
        {
            Ticket newTicket = new Ticket();


            newTicket.Id = value.Id;
            newTicket.assignedUserId = value.assignedUserId;
            newTicket.status = TicketStatus.Assigned;

            return await _TicketService.SaveAssignedTicket(newTicket);
        }

        // PUT api/<TicketController>/5
        [HttpPut("{id}")]
        public async Task<Ticket> PutAsync(int id, [FromBody] Ticket value)
        {
            return await _TicketService.UpdateTicket(value);
        }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            int deleted = await _TicketService.DeleteTicket(id);
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
