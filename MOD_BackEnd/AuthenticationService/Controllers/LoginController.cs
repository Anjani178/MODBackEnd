using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationService.Models;
using AuthenticationService.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.UserService.Models;

namespace AuthenticationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // GET: api/Login
        private readonly ILoginrepository _repository;

        public LoginController(ILoginrepository repository)
        {
            _repository = repository;
        }


        // GET: api/Login


        [HttpGet]
        [Route("Validate/{id}/{password}")]
        public token Get(string id, string password)
        {
            User obj = _repository.UserLogin(id, password);
            Mentor obj1 = _repository.MentorLogin(id, password);

            if (obj != null)
            {
                return new token() { message = "User", tokenval = GetToken(), username = obj.UEmail, role="User" };
            }
            else if (obj1 != null)
            {
                return new token() { message = "Mentor", tokenval = GetToken(), username = obj1.MUserName, role = "Mentor" };

            }
            else if (id == "Admin" && password == "Admin")
            {
                return new token() { message = "Admin", tokenval = GetToken(), username = "Admin",  };

            }
            else
            {
                return new token() { message = "Invalid User", tokenval = "" };

            }
        }
        public string GetToken()
        {
            return "";
        }
    }
}
