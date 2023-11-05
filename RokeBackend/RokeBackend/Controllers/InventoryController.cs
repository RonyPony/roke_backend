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
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _InventoryService;
        private readonly IConfiguration _Configuration;

        public InventoryController(IInventoryService InventoryService, IConfiguration configuration)
        {
            _InventoryService = InventoryService;
            _Configuration = configuration;
        }


        // GET: api/<TicketController>
        [HttpGet]
        public IEnumerable<Inventory> Get()
        {
            return _InventoryService.GetAllInventorys();
        }

        // GET api/<TicketController>/5
        [HttpGet("Inventory")]
        public async Task<Inventory> GetAsync(Guid id)
        {
            return await _InventoryService.GetInventoryById(id);
        }

        [HttpGet("IdSucursal")]
        public  IEnumerable<Inventory> Getsucursal(Guid id)
        {
            return  _InventoryService.getInventoryByLocationAsync(id);
        }

        [HttpPost]
        public async Task<Inventory> PostAsync([FromBody] InventoryDTO value)
        {
            Inventory newIn = new Inventory();
            newIn.sucursal = value.sucursal;
            newIn.ItemCode = value.ItemCode;
            newIn.InstallDate = value.InstallDate;
            newIn.Location_Conden = value.Location_Conden;
            newIn.Status = Status.Active;
            newIn.Serial = value.Serial;
            newIn.Location_Evap = value.Location_Evap;
            newIn.area_supply = value.area_supply;
            newIn.floor_Conden = value.floor_Conden;
            newIn.floor_Evap = value.floor_Evap;
            newIn.Model_Conden = value.Model_Conden;
            newIn.Model_evap = value.Model_evap;
            newIn.item_type = value.item_type;



            return await _InventoryService.SaveInventory(newIn);
        }

        // PUT api/<TicketController>/5
        [HttpPut("{id}")]
        public async Task PutAsync(Guid id, [FromBody] InventoryDTO value)
        {
            Inventory newIn = new Inventory();
            newIn = await _InventoryService.GetInventoryById(id);
            newIn.sucursal = value.sucursal;
            newIn.ItemCode = value.ItemCode;
            newIn.InstallDate = value.InstallDate;
            newIn.Location_Conden = value.Location_Conden;
            newIn.Status = Status.Active;
            newIn.Serial = value.Serial;
            newIn.Location_Evap = value.Location_Evap;
            newIn.area_supply = value.area_supply;
            newIn.floor_Conden = value.floor_Conden;
            newIn.floor_Evap = value.floor_Evap;
            newIn.Model_Conden = value.Model_Conden;
            newIn.Model_evap = value.Model_evap;
            newIn.item_type = value.item_type;



            _InventoryService.UpdateInventory(newIn);
        }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            int deleted = await _InventoryService.DeleteInventory(id);
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
