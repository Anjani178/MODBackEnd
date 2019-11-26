using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MOD.AuthenticateServic.Models;
using MOD.AuthenticateService.Models;
using MOD.AuthenticateService.Repositories;

namespace MOD.AuthenticateService.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    [EnableCors("AllowMyOrigin")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _repository;

        public LoginController(ILoginRepository repository)
        {
            _repository = repository;
        }


        // GET: api/Login


        [HttpGet]
        [Route("Validate/{id}/{password}")]
        public Token Get(string id, string password)
        {
            User obj = _repository.UserLogin(id, password);
            Mentor obj1 = _repository.MentorLogin(id, password);

            if (obj != null)
            {
                return new Token() { message = "User", token = GetToken(), username = obj.UEmail ,role="User", active=obj.Active };
            }
            else if (obj1 != null)
            {
                return new Token() { message = "Mentor", token = GetToken(), username = obj1.MUserName,role="Mentor", active = obj1.Active };

            }
            else if (id == "Admin" && password == "Admin")
            {
                return new Token() { message = "Admin", token = GetToken(), username = "Admin" };

            }
            else
            {
                return new Token() { message = "Invalid User", token = "" };

            }
        }
        public string GetToken()
        {
            var _config = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json").Build();
            var issuer = _config["Jwt:Issuer"];
            var audience = _config["Jwt:Audience"];
            var expiry = DateTime.Now.AddMinutes(120);
            var securityKey = new SymmetricSecurityKey
        (Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials
        (securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(issuer: issuer,
        audience: audience,
        expires: DateTime.Now.AddMinutes(120),
        signingCredentials: credentials);

            var tokenHandler = new JwtSecurityTokenHandler();
            var stringToken = tokenHandler.WriteToken(token);
            return stringToken;
        }
    }
}
