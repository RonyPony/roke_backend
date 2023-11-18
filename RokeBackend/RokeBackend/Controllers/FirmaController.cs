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
    public class FirmaController : ControllerBase
    {
        private readonly IFirmaService _FirmaService;
        private readonly IConfiguration _Configuration;

        public FirmaController(IFirmaService FirmaService, IConfiguration configuration)
        {
            _FirmaService = FirmaService;
            _Configuration = configuration;
        }


        // GET: api/<TicketController>
        [HttpGet]
        public IEnumerable<Firma> Get()
        {
            return _FirmaService.getAllFirma();
        }

        // GET api/<TicketController>/5
        [HttpGet("id")]
        public async Task<Firma> GetAsync(Guid id)
        {
            return await _FirmaService.getFirmaByIdAsync(id);
        }

       /* [HttpGet("IdSucursal")]
        public  IEnumerable<Inventory> Getsucursal(Guid id)
        {
            return  _InventoryService.getInventoryByLocationAsync(id);
        }*/

        [HttpPost]
        public async Task<Firma> PostAsync([FromBody] FirmaDTO value)
        {
            Firma obj = new Firma();
            obj.firma = value.firma;
            obj.IdUser = value.IdUser;
            return await _FirmaService.CreateFirma(obj);
        }

        // PUT api/<TicketController>/5
         [HttpPut("{id}")]
        public async Task PutAsync(Guid id, [FromBody] FirmaDTO value)
        {
            Firma obj = new Firma();
            obj = await _FirmaService.getFirmaByIdAsync(id);
            obj.firma = value.firma;


            _FirmaService.UpdateFirma(obj);
        } 

        // DELETE api/<TicketController>/5
         [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            int deleted = await _FirmaService.RemoveFirma(id);
            if (deleted == 0)
            {
                return BadRequest("Could not delete this ticket");
            }
            else
            {
                return Ok("deleted");
            }
        } 

        // POST api/<TicketController>


        // PUT api/<TicketController>/5


        // DELETE api/<TicketController>/5

    }
}
