using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.TechnologyService.Models;
using MOD.TechnologyService.Repositories;

namespace MOD.TechnologyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    public class SkillController : ControllerBase
    {
        private readonly ISkillRepository _repository;
        public SkillController(ISkillRepository repository) ///to overcome the runtime dependencies instead of using directly context class
        {
            _repository = repository;
        }
        // GET: api/Skill
        [HttpGet("GetAll")]
        public IEnumerable<Skill> Get()
        {
            return _repository.GetAll();
        }
        [HttpGet("GetName/{n}")]
        public Skill GetByname(string n)
        {
            return _repository.GetName(n);
        }

        // POST: api/Skill
        [HttpPost("Add")]
        public IActionResult Post([FromBody] Skill value)
        {
            _repository.add(value);
            return Ok();
        }

        // PUT: api/Skill/5
        [HttpPut("Update")]
        public IActionResult Put(Skill item)
        {
            _repository.Update(item);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(string id)
        {
            _repository.Delete(id);
            return Ok();
        }
    }
}
