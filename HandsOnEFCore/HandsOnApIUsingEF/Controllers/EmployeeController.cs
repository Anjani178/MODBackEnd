using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnApIUsingEF.Models;
using HandsOnApIUsingEF.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnApIUsingEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeController(IEmployeeRepository repository) ///to overcome the runtime dependencies instead of using directly context class
        {
            _repository = repository;
        }
        // GET: api/Employee/GetAll
        [HttpGet]
        [Route("GetAll")]
        public List<Employee> Get()
        {
            return _repository.GetAll(); ;
        }

        // GET: api/Employee/GetById/5
        [HttpGet("{id}", Name = "Get")]
        [Route("GetById/{id}")]
        public Employee Get(int id)
        {
            return _repository.GetById(id);
        }

        // POST: api/Employee
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody]  Employee value)
        {
            _repository.add(value);
            return Ok("record updated");
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        [Route("Update/{id}")]
        public void Put(Employee item)
        {
            _repository.Update(item);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
