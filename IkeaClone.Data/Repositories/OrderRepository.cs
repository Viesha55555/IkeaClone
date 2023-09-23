using IkeaClone.Models;
using IkeaClone.Repository.Models;

namespace IkeaClone.Repository.Repositories;

public class OrderRepository : IOrderRepository
{
    public List<Order> orders = new List<Order>() {
        new Order()
        {
            Id = 1,
            CustomerId = 1,
            Products = new List<IProduct>
            {
                new Furniture()
                {
                    ItemNumber = 1,
                    Description = "Sofa",
                    Price = 20,
                    Weight = 50
                },
                new Textile()
                {
                    ItemNumber = 25,
                    Description = "Nice textile",
                    Price = 50,
                    Color = "Red"
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
        //await Task.Run(() => {
        //    var orderById = orders.FirstOrDefault(o => o.Id == id);
        //});
        //orders.FirstOrDefault(o => o.Id == id);
        return orders.FirstOrDefault(o => o.Id == id);
    }

    public void Read(Order item)
    {
        throw new NotImplementedException();
    }
}
