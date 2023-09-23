using IkeaClone.Repository.Repositories;
using IkeaClone.Services.Dtos;

namespace IkeaClone.Services;

public class ReadOrderService : IReadOrderService
{
    protected readonly IOrderRepository _orderRepository;

    public ReadOrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }
    public Task<ReadOrderDto> GetOrderAsync(int orderId)
    {
        //send order id to the repo
        //order has
        //

        var orderById = _orderRepository.FindById(orderId);
        //call to user repo to see what discounts are for this user and return
        //mapper here to map products and list of available discounts
        throw new NotImplementedException();
    }
}