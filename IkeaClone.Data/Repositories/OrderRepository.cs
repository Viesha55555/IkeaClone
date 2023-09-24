using IkeaClone.Models;
using IkeaClone.Repository.Entities;

namespace IkeaClone.Repository.Repositories;

public class OrderRepository : IOrderRepository
{
    public List<Order> orders = new List<Order>() {
        new Order()
        {
            Id = 1,
            CustomerId = 1,
            OrderItems = new List<OrderItem>
            {
                new OrderItem()
                {
                    OrderItemType = OrderItemType.Furniture,
                    Amount = 2,
                    OrderItemNumber = 1
                },
                new OrderItem()
                {
                    OrderItemType = OrderItemType.Textile,
                    Amount = 2,
                    OrderItemNumber = 26
                },
                new OrderItem()
                {
                    OrderItemType = OrderItemType.HotDogs,
                    Amount = 2,
                    FlavorIdentifier = "Kabanos"
                }
            }
        },
        new Order()
        {
            Id = 2,
            CustomerId = 5,
            OrderItems = new List<OrderItem>
            {
                new OrderItem()
                {
                    OrderItemType = OrderItemType.Furniture,
                    Amount = 2,
                    OrderItemNumber = 3
                },
                new OrderItem()
                {
                    OrderItemType = OrderItemType.Textile,
                    Amount = 2,
                    OrderItemNumber = 26
                },
                new OrderItem()
                {
                    OrderItemType = OrderItemType.HotDogs,
                    Amount = 2,
                    FlavorIdentifier = "Chili"
                }
            }
        }
    };
    public void Add(Order item)
    {
        throw new NotImplementedException();
    }

    public async Task<Order> FindById(int id)
    {
        return orders.FirstOrDefault(o => o.Id == id);
    }

    public async Task<IList<Order>> GetAll()
    {
        return orders;
    }
}
