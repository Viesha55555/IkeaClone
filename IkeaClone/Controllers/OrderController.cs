using IkeaClone.Models;
using Microsoft.AspNetCore.Mvc;

namespace IkeaClone.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetOrder")]
        public ActionResult<Order> Get()
        {
            var order = new Order();
            return Ok(order);
        }
    }
}