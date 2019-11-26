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
    public class MentorController : ControllerBase
    {
        private readonly IMentorRepository _repository;
        public MentorController(IMentorRepository repository) ///to overcome the runtime dependencies instead of using directly context class
        {
            _repository = repository;
        }
        // GET: api/Mentor
        [HttpGet]
        [Route("GetallM")]
        public IEnumerable<Mentor> GetAll()
        {
            return _repository.GetAll();
        }

        // GET: api/Mentor/5
        [HttpGet("getM/{id}", Name = "Get11")]
        public Mentor GetMentors(string id)
        {
            return _repository.GetById(id);
        }

        // POST: api/Mentor
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Mentor value)
        {
            _repository.add(value);
            return Ok("record updated");
        }

        [Route("ResetPass")]
        [HttpPut]
        public IActionResult ResetPass([FromBody] string e, string pass)
        {
            _repository.ResetPass(e, pass);
            return Ok("record updated");
        }

        [HttpPut(Name = "putBM")]
        [Route("Block/{id}")]
        public void Bloc(string id)
        {
            _repository.Block(id);
        }

        [HttpPut("Update")]
        public void Put(Mentor item)
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
