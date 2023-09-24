using IkeaClone.Services.Dtos;

namespace IkeaClone.Services.Services;

public interface IReadOrderService
{
    public Task<ReadOrderDto> GetOrderAsync(int orderId);
}
