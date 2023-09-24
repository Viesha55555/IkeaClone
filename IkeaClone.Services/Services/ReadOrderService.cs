using AutoMapper;
using IkeaClone.Repository.Entities;
using IkeaClone.Repository.Repositories;
using IkeaClone.Services.Dtos;

namespace IkeaClone.Services.Services;

public class ReadOrderService : IReadOrderService
{
    protected readonly IOrderRepository _orderRepository;
    protected readonly IReadOrderItemsService _readOrderItemsService;
    protected readonly IDiscountService _discountService;
    protected readonly IMapper _mapper;

    public ReadOrderService(IOrderRepository orderRepository,
        IReadOrderItemsService readOrderItemsService,
        IDiscountService discountService,
        IMapper mapper)
    {
        _orderRepository = orderRepository;
        _readOrderItemsService = readOrderItemsService;
        _discountService = discountService;
        _mapper = mapper;
    }
    public async Task<ReadOrderDto> GetOrderAsync(int orderId)
    {
        var orderItemDtos = new List<OrderItemDto>();

        var orderById = await _orderRepository.FindById(orderId);

        //call to furniture
        if (orderById.OrderItems.Any(i => i.OrderItemType == OrderItemType.Furniture))
        {
            foreach (var item in orderById.OrderItems.Where(i => i.OrderItemType == OrderItemType.Furniture))
            {
                var furnitureById = await _readOrderItemsService.GetFurnitureByItemNumber(item.OrderItemNumber);
                if (furnitureById != null)
                {
                    var mappedProducts = _mapper.Map<OrderItemDto>(furnitureById);
                    if (mappedProducts != null)
                        orderItemDtos.Add(mappedProducts);
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
                    var mappedProducts = _mapper.Map<OrderItemDto>(textileById);
                    if (mappedProducts != null)
                        orderItemDtos.Add(mappedProducts);
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
                    var mappedProducts = _mapper.Map<OrderItemDto>(hotdogByFlavorId);
                    if (mappedProducts != null)
                        orderItemDtos.Add(mappedProducts);
                }
            }
        }

        //Get discounts based on customer ID
        var appliedDiscounts = await _discountService.GetCustomerDiscounts(orderById.CustomerId);

        var returnDto = new ReadOrderDto()
        {
            OrderId = orderId,
            Products = orderItemDtos,
            AppliedDiscounts = appliedDiscounts ?? new List<string>()
        };

        return returnDto;
    }
}