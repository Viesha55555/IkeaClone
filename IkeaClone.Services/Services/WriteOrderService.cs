using IkeaClone.Repository.Repositories;
using IkeaClone.Services.Dtos;

namespace IkeaClone.Services.Services;

public class WriteOrderService : IWriteOrderService
{
    protected readonly IOrderRepository _orderRepository;

    public WriteOrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<ReadOrderDto> CreateOrderAsync(WriteOrderDto writeOrderDto)
    {
        if (writeOrderDto == null)
            throw new ArgumentNullException(nameof(writeOrderDto));

        var orders = await _orderRepository.GetAll();
        var getMaxOrderId = orders.Max(o => o.Id);
        getMaxOrderId++;

        //For demo purposes creation of order in table is skipped

        var createdOrderDto = new ReadOrderDto()
        {
            OrderId = getMaxOrderId,
            Products = writeOrderDto.Products,
            AppliedDiscounts = new List<string>()
        };
        return createdOrderDto;
    }
}
