using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RokeBackend.core.Interface;
using RokeBackend.data.DTOs;
using RokeBackend.data.Services;
using RokeBackend.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RokeBackend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]

    public class userController : ControllerBase
    {

        private readonly IUserService _userService;
        private readonly IConfiguration _Configuration;
        public userController(IUserService srv, IConfiguration conf)
        {
            _userService = srv;
            _Configuration = conf;
        }

        //Login
        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto optData)
        {
            //var data = JsonConvert.DeserializeObject<dynamic>(optData.ToString());

            //string user = data.usuario.ToString();
            //string password = data.password.ToString();
            //Guid userId = await _userService.
            user user = await _userService.getUserByuser(optData.username);

            //usuario usuario = usuario.DB().Where(x => x.user == user && x.password == password).FirstOrDefault();

            if (user == null)
            {
                return Unauthorized(new
                {
                    success = false,
                    message = "Usuario no existe, favor registrate",
                    result = ""
                });
            }
            if (user.password != optData.password)
            {
                return Unauthorized(new
                {
                    success = false,
                    message = "Credenciales incorrectas",
                    result = ""
                });
            }
            var jwt = _Configuration.GetSection("Jwt").Get<jwt>();
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, jwt.Subject),
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                  new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                  new Claim("id", user.IdUser.ToString()),
                  new Claim("user", user.username)

            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));
            var signin = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                jwt.Issuer,
                jwt.Audience,
                claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: signin

               );
            return Ok(new
            {
                success = true,
                message = "Exito",
                result = new JwtSecurityTokenHandler().WriteToken(token)
            });

        }
    }

}

