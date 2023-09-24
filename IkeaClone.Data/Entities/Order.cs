using IkeaClone.Repository.Entities;
using IkeaClone.Repository.Repositories;

namespace IkeaClone.Models;

public class Order : IAggregateRoot
{
    public int Id { get; set; }
    public IList<OrderItem> OrderItems { get; set; }
    public int CustomerId { get; set; }
}
