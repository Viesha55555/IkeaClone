using IkeaClone.Services.Dtos;

namespace IkeaClone.Services.Services;

public interface IWriteOrderService
{
    public Task<ReadOrderDto> CreateOrderAsync(WriteOrderDto writeOrderDto);
}
