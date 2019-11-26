using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class demoController : ControllerBase
    {
        //public string Get()      {
        //    return "Hello World.....";
        //}
        //public IList<string> Get()
        //{
        //    return new List<string> { "Rohan", "jeson", "jon" };
        //}

        public IActionResult Get()
        {
            return Ok(new List<string> { "Rohan", "jeson", "jon" });
        }

        [Route("{id}")]
        public IActionResult Get( string id)
        {
            string s = "Hello " + id;
            return Ok(s);
        }

        [Route("{no:int}")]
        public IActionResult Get(int no)
        {
            return Ok("Return no's");
        }

        public IActionResult Post(object item)
        {
            return Ok("Resuorce Added");
        }

        public IActionResult Put(object item)
        {
            return Ok("Resuorce Updated");
        }

        public IActionResult Delete(object item)
        {
            return Ok("Resuorce Deleted");
        }

    }
}