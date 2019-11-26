using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.PaymentService.Models;
using MOD.PaymentService.Repositories;

namespace MOD.PaymentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepository _repository;
        public PaymentController(IPaymentRepository repository) ///to overcome the runtime dependencies instead of using directly context class
        {
            _repository = repository;
        }
        // GET: api/Payment
        [HttpGet("GetAll")]
        public IEnumerable<Payment> Get()
        {
            return _repository.GetAll(); ;
        }

        // POST: api/Payment
        [HttpPost("Add")]
        public IActionResult Post([FromBody] Payment value)
        {
            _repository.add(value);
            return Ok("record updated");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("Delete/{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
