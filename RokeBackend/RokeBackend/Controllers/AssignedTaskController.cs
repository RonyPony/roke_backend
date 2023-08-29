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
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RokeBackend.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AssignedTaskController : ControllerBase
    {
        private readonly IAssignedTicketService _AssignedTicketService;
        private readonly IConfiguration _Configuration;

        public AssignedTaskController(IAssignedTicketService AssignedTicketService, IConfiguration configuration)
        {
            _AssignedTicketService = AssignedTicketService;
            _Configuration = configuration;
        }


        // GET: api/<TicketController>
        [HttpGet]
        public IEnumerable<Ticket> Get()
        {
            return _AssignedTicketService.GetAllAssignedTickets();
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public async Task<Ticket> GetAsync(Guid id)
        {
            return await _AssignedTicketService.GetAssignedTicketById(id);
        }

        [HttpGet("/Assigned/{assignedUserId}")]
        public async Task<Ticket> GetuserAsync(Guid assignedUserId)
        {
            return await _AssignedTicketService.GetAssignedTicketByIdUser(assignedUserId);
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
            newTicket.assignedUserId = value.assignedUserId;
            newTicket.photoId1 = value.photoId1;
            newTicket.photoId2 = value.photoId2;
            newTicket.photoId3 = value.photoId3;
            newTicket.createdOn = DateTime.Now;
            newTicket.updatedOn = DateTime.Now;
            newTicket.ticketType= value.ticketType;
            newTicket.status = TicketStatus.Assigned;

            return await _AssignedTicketService.SaveAssignedTicket(newTicket);
        }

        // PUT api/<TicketController>/5
        [HttpPut("{id}")]
        public async Task<Ticket> PutAsync(int id, [FromBody] Ticket value)
        {
            return await _AssignedTicketService.UpdateAssignedTicket(value);
        }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            int deleted = await _AssignedTicketService.DeleteAssignedTicket(id);
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
