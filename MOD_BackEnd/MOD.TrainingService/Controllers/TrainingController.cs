using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.TrainingService.Models;
using MOD.TrainingService.Repositories;

namespace MOD.TrainingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    public class TrainingController : ControllerBase
    {
        // GET: api/Training
        private readonly ITrainingRepository _repository;
        public TrainingController(ITrainingRepository repository) ///to overcome the runtime dependencies instead of using directly context class
        {
            _repository = repository;
        }
        [HttpGet("GetAll")]
        public IEnumerable<Training> Get()
        {
            return _repository.GetAll(); 
        }

        // POST: api/Training
        [HttpPost("Add")]
        public IActionResult Post([FromBody] Training value)
        {
            _repository.add(value);
            return Ok("record updated");
        }

        // PUT: api/Training/5
        [HttpPut("Update")]
        public void Put(Training item)
        {
            _repository.UpdateR(item);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("Delete/{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
