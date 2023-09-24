using IkeaClone.Models;
using IkeaClone.Repository.Entities;
using IkeaClone.Repository.Models;

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
    
    };
    public void Add(Order item)
    {
        throw new NotImplementedException();
    }

    public async Task<Order> FindById(int id)
    {
        return orders.FirstOrDefault(o => o.Id == id);
    }

    public IList<Order> GetAll()
    {
        throw new NotImplementedException();
    }
}
