using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.UserService.Models;
using MOD.UserService.Repositories;

namespace MOD.UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public UserController(IUserRepository repository) ///to overcome the runtime dependencies instead of using directly context class
        {
            _repository = repository;
        }
        // GET: api/User
        [HttpGet("GetAll")]
        //[Route("Search/{tech}/{ts}")]
        //public IEnumerable<Mentor> GetAll(String tech,string ts)
        //{
        //    return _repository.SearchMentor(tech,ts); 
        //}

        public IEnumerable<User> GetAll() { 
                return _repository.GetAll(); 
        }

        // GET: api/User/5
        [HttpGet("Get/{id}", Name = "Get123")]
        public User GetUser(string id)
        {
            return _repository.GetById(id) ;
        }

        [HttpGet("Search/{tech}/{ts}")]
        public IEnumerable<Mentor> GetSearch(string  tech, string ts)
        {
            return _repository.SearchMentor(tech,ts);
        }

        // POST: api/User
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] User value)
        {
            _repository.add(value);
            return Ok("record updated");
        }

        [HttpPut(Name ="put1")]
        [Route("ResetPass")]
        public IActionResult ResetPass([FromBody] string e,string pass)
        {
            _repository.ResetPass(e,pass);
            return Ok("record updated");
        }

        [HttpPut(Name = "put2")]
        [Route("Block/{id}")]
        public void Bloc(string id)
        {
            _repository.Block(id);
        }

        // PUT: api/User/5
        [HttpPut("Update")]
        public void Put(User item)
        {
            _repository.Update(item);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("Delete/{id}")]
        public void Delete(string id)
        {
            _repository.Delete(id);
        }
    }
}
