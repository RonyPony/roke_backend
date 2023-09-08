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
    public class MonthController : ControllerBase
    {
        private readonly IMonthService _MonthService;
        private readonly IConfiguration _Configuration;

        public MonthController(IMonthService MonthService, IConfiguration configuration)
        {
            _MonthService = MonthService;
            _Configuration = configuration;
        }


        // GET: api/<TicketController>
        [HttpGet]
        public IEnumerable<month> Get()
        {
            return _MonthService.GetAllMonths();
        }

        // GET api/<TicketController>/5
        [HttpGet("month")]
        public async Task<month> GetAsync(string value)
        {
            return await _MonthService.GetMonthById(value);
        }

      

        // POST api/<TicketController>
     

        // PUT api/<TicketController>/5
      

        // DELETE api/<TicketController>/5
    
    }
}
