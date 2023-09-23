using IkeaClone.Services;
using IkeaClone.Services.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace IkeaClone.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IReadOrderService _readOrderService;

        public OrderController(ILogger<OrderController> logger, IReadOrderService readOrderService)
        {
            _logger = logger;
            _readOrderService = readOrderService;
        }

        [HttpGet(Name = "GetOrder")]
        public async Task<ActionResult<ReadOrderDto>> Get()
        {
            var order = await _readOrderService.GetOrderAsync("changehardcoed");
            return Ok(order);
        }
    }
}