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
    public class MediaController : ControllerBase
    {
        private readonly IMediaService _MediaService;
        private readonly IConfiguration _Configuration;

        public MediaController(IMediaService LocationService, IConfiguration configuration)
        {
            _MediaService = LocationService;
            _Configuration = configuration;
        }


        // GET: api/<TicketController>
        [HttpGet]
        public IEnumerable<Media> Get()
        {
            return _MediaService.getAllMedias();
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public async Task<Media> GetAsync(Guid id)
        {
            return await _MediaService.getMediaByIdAsync(id);
        }

        /* [HttpPost("asign")]
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
        */

        // POST api/<TicketController>
        [HttpPost]
        public async Task<Media> PostAsync([FromBody] MediaDto value)
        {
            Media obj = new Media();
            obj.photo = value.photo;
            obj.uploadDate = DateTime.Now;

            return await _MediaService.CreateMedia(obj);
        }

        // PUT api/<TicketController>/5
        [HttpPut("{id}")]
        public async Task<Media> PutAsync(int id, [FromBody] Media value)
        {
            return await _MediaService.UpdateMedia(value);
        }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            int deleted = await _MediaService.RemoveMedia(id);
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
