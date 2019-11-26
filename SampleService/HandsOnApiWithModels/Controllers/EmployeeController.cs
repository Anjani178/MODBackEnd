using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnApiWithModels.Models;
using HandsOnApiWithModels.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnApiWithModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET: api/Employee
        EmployeeRepository Erep = new EmployeeRepository();
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Erep.GetAll());
        }

        // GET: api/Employee/5
        [Route("GetId/{id}")]

        [HttpGet("{id}", Name = "GetID")]
        public IActionResult GetID(int id) //can also give get for all
        {
            return Ok(Erep.GetById(id));
        }

        [Route("GetDes/{des}")]
        [HttpGet("{des}", Name = "GetDes")]
        
        public IActionResult GetDes(string des)
        {
            return Ok(Erep.GetByDes(des));
        }

        [Route("GetSal/{sal}")]
        [HttpGet("{sal}", Name = "Getsal")]
        public IActionResult Get(int sal)
        {
            return Ok(Erep.GetBySalary(sal));
        }

        // POST: api/Employee
        [HttpPost]
        public void Post(Employee i)
        {
            Erep.Add(i);

        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
