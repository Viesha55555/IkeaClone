using IkeaClone.Models;

namespace IkeaClone.Repository.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<Order> FindById(int id);
    }
}
