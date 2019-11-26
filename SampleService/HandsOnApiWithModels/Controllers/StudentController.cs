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
    public class StudentController : ControllerBase
    {
        //create repository object

        // this is api read write template

        StudentRepository rep = new StudentRepository();
        // GET: api/Student
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(rep.GetAll());
        }

        // GET: api/Student/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Student
        [HttpPost]
        public void Post(Student i)
        {
            rep.Add(i);
        }

        // PUT: api/Student/5
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
