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
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _UsuarioService;
        private readonly IConfiguration _Configuration;

        public UsuarioController(IUsuarioService UsuarioService, IConfiguration configuration)
        {
            _UsuarioService = UsuarioService;
            _Configuration = configuration;
        }


        // GET: api/<TicketController>
        [HttpGet]
        public IEnumerable<UserDTO> Get()
        {
            IEnumerable<user> values2 = _UsuarioService.GetAllUsuarios();
            List<user> valueList2 = values2.ToList();
            List<UserDTO>  dtoList = new List<UserDTO>();
            foreach (user value in valueList2)
            {
                dtoList.Add(new UserDTO {id = value.Id, nombre = value.nombre, apellido = value.apellido, cedula = value.cedula, contacto = value.contacto ,rol=value.rol,status=value.Statusuario.ToString(),username=value.username});
            }
            return dtoList;
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public async Task<UserDTO> GetAsync(Guid id )
        {
            user value = await _UsuarioService.GetUsuarioById(id);
            UserDTO user =new UserDTO {id = value.Id,nombre = value.nombre, apellido = value.apellido, cedula = value.cedula, contacto = value.contacto, rol = value.rol, status = value.Statusuario.ToString(), username = value.username };            
            return user;
        }

        // POST api/<TicketController>
        [HttpPost]
        public async Task<user> PostAsync([FromBody] UsuarioDTO value)
        {
            user newUser = new user();
            newUser.nombre = value.nombre;
            newUser.apellido = value.apellido;
            newUser.cedula = value.cedula;
            newUser.contacto = value.contacto;
            newUser.username = value.username;
            newUser.password = value.password;
            newUser.rol = value.rol;
            newUser.Statusuario= UsuarioStatus.Active;
          

            return await _UsuarioService.SaveUsuario(newUser);
        }

        // PUT api/<TicketController>/5
        [HttpPut("{id}")]
        public async Task PutAsync(Guid id, [FromBody] UsuarioDTO value)
        {
            user user = new user();
            user =  await _UsuarioService.GetUsuarioById(id);
            user.nombre = value.nombre;
            user.apellido = value.apellido;
            user.cedula = value.cedula;
            user.contacto = value.contacto;
            user.username = value.username; 
           user.password = value.password;  
            user.rol = value.rol;
            
                
            _UsuarioService.UpdateUsuario(user);
            
        }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            int deleted = await _UsuarioService.DeleteUsuario(id);
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
