using IkeaClone.Services.Dtos;
using IkeaClone.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace IkeaClone.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IReadOrderService _readOrderService;
        private readonly IWriteOrderService _writeOrderService;

        public OrderController(ILogger<OrderController> logger,
            IReadOrderService readOrderService,
            IWriteOrderService writeOrderService)
        {
            _logger = logger;
            _readOrderService = readOrderService;
            _writeOrderService = writeOrderService;
        }

        [HttpGet("{id}/orders", Name = "GetOrder")]
        public async Task<ActionResult<ReadOrderDto>> Get(int id)
        {
            var order = await _readOrderService.GetOrderAsync(id); //change from hardcoded
            return Ok(order);
        }

        [HttpPost]
        public async Task<ActionResult<ReadOrderDto>> Post([FromBody]WriteOrderDto writeOrderDto)
        {
            var createdOrder = await _writeOrderService.CreateOrderAsync(writeOrderDto);
            return Created("GetOrder", createdOrder);
        }
    }
}