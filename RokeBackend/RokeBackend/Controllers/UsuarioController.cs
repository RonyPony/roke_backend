﻿using Microsoft.AspNetCore.Authorization;
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
        public IEnumerable<user> Get()
        {
            return _UsuarioService.GetAllUsuarios();
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public async Task<user> GetAsync(Guid id)
        {
            return await _UsuarioService.GetUsuarioById(id);
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
