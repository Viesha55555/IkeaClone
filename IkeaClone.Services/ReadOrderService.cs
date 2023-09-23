using IkeaClone.Services.Dtos;

namespace IkeaClone.Services;

public class ReadOrderService : IReadOrderService
{
    public Task<ReadOrderDto> GetOrderAsync(string orderId)
    {
        throw new NotImplementedException();
    }
}