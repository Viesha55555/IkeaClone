using IkeaClone.Models;
using IkeaClone.Repository.Entities;
using IkeaClone.Repository.Repositories;
using IkeaClone.Services.Dtos;

namespace IkeaClone.Services.Services;

public class ReadOrderService : IReadOrderService
{
    protected readonly IOrderRepository _orderRepository;
    protected readonly IReadOrderItemsService _readOrderItemsService;

    public ReadOrderService(IOrderRepository orderRepository, IReadOrderItemsService readOrderItemsService)
    {
        _orderRepository = orderRepository;
        _readOrderItemsService = readOrderItemsService;
    }
    public async Task<ReadOrderDto> GetOrderAsync(int orderId)
    {
        var productsInOrder = new List<IProduct>();

        var orderById = await _orderRepository.FindById(orderId);

        //call to furniture
        if (orderById.OrderItems.Any(i => i.OrderItemType == OrderItemType.Furniture))
        {
            foreach (var item in orderById.OrderItems.Where(i => i.OrderItemType == OrderItemType.Furniture))
            {
                var furnitureById = await _readOrderItemsService.GetFurnitureByItemNumber(item.OrderItemNumber);
                if (furnitureById != null)
                {
                    productsInOrder.Add(furnitureById);
                }
            }
        }

        //call to textile
        if (orderById.OrderItems.Any(i => i.OrderItemType == OrderItemType.Textile))
        {
            foreach (var item in orderById.OrderItems.Where(i => i.OrderItemType == OrderItemType.Textile))
            {
                var textileById = await _readOrderItemsService.GetTextileByItemNumber(item.OrderItemNumber);
                if (textileById != null)
                {
                    productsInOrder.Add(textileById);
                }
            }
        }

        //call to hotdog
        if (orderById.OrderItems.Any(i => i.OrderItemType == OrderItemType.HotDogs))
        {
            foreach (var item in orderById.OrderItems.Where(i => i.OrderItemType == OrderItemType.HotDogs))
            {
                var hotdogByFlavorId = await _readOrderItemsService.GetHotDogByFlavor(item.FlavorIdentifier);
                if (hotdogByFlavorId != null)
                {
                    productsInOrder.Add(hotdogByFlavorId);
                }
            }
        }

        //combine them all in one product class and map then to dto?

        //call to user repo to see what discounts are for this user and return
        //mapper here to map products and list of available discounts
        throw new NotImplementedException();
    }
}