using dotnetwithmongo.Entities;
using dotnetwithmongo.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace dotnetwithmongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentController(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        [HttpGet("GetAllPayment")]
        public ActionResult<List<Payment>> GetAllPayment()
        {
            return _paymentRepository.GetAllPayment();
        }

        [HttpGet("GetPaymentById")]
        public ActionResult<Payment> GetPaymentById(string id)
        {
            return _paymentRepository.GetPaymentById(id);
        }

        [HttpPost("InsertPayment")]
        public ActionResult<Payment> InsertPayment([FromBody] Payment payment)
        {
            _paymentRepository.Create(payment);
            return CreatedAtAction("GetPaymentById", new { id = payment.Id }, payment);
        }
    }
}
