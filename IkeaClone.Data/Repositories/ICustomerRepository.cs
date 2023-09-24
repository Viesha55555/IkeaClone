using IkeaClone.Models;

namespace IkeaClone.Repository.Repositories;

public interface ICustomerRepository : IRepository<Customer>
{
    public Task<Customer> GetByCustomerId(int customerId);
}
