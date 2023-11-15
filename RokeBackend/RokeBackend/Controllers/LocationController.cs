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
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _LocationService;
        private readonly IConfiguration _Configuration;

        public LocationController(ILocationService LocationService, IConfiguration configuration)
        {
            _LocationService = LocationService;
            _Configuration = configuration;
        }


        // GET: api/<TicketController>
        [HttpGet]
        public IEnumerable<location> Get()
        {
            return _LocationService.GetAllLocations();
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public async Task<location> GetAsync(Guid id)
        {
            return await _LocationService.GetLocationById(id);
        }

        [HttpPost("asign")]
        public async Task<LocationMappingDTO> asign([FromBody] LocationMappingDTO value)
        {

            foreach (var item in value.idInventary)
            {
                locationMapping newplan = new locationMapping();
                newplan.idInventory = item;
                newplan.idlocation = value.idLocation;

                try
                {
                    await _LocationService.assignInvetory(newplan);
                }
                catch (Exception ex)
                {

                    throw;
                }
            }

            return value;
        }


        // POST api/<TicketController>
        [HttpPost]
        public async Task<location> PostAsync([FromBody] LocationDTO value)
        {
            location newLocation = new location();
            newLocation.sucursal = value.sucursal;
            newLocation.latitude = value.latitude;
            newLocation.longitude = value.longitude;
            newLocation.contactName = value.contactName;
            newLocation.contactNumber = value.contactNumber;
            newLocation.contactHasWhatsapp = value.contactHasWhatsapp;
            newLocation.status = LocationStatus.Active;


            return await _LocationService.SaveLocation(newLocation);
        }

        // PUT api/<TicketController>/5
        [HttpPut("{id}")]
        public async Task<location> PutAsync(int id, [FromBody] location value)
        {
            return await _LocationService.UpdateLocation(value);
        }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            int deleted = await _LocationService.DeleteLocation(id);
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
