using IkeaClone.Models;

namespace IkeaClone.Repository.Repositories;

public class CustomerRepository : ICustomerRepository
{
    public List<Customer> customers = new()
    {
        new Customer()
        {
            Id = 1,
            Name = "John Doe",
            IsMember = true,
            DiscountedCategories = new List<string> { "Furniture", "HotDog" }
        },
        new Customer()
        {
            Id = 2,
            Name = "Jane Smith",
            IsMember = false,
            DiscountedCategories = new List<string> { "Textile" }
        },
        new Customer()
        {
            Id = 3,
            Name = "Bob Johnson",
            IsMember = true,
            DiscountedCategories = new List<string> { "Furniture" }
        },
        new Customer()
        {
            Id = 4,
            Name = "Alice Brown",
            IsMember = true,
            DiscountedCategories = new List<string> { "HotDog" }
        },
        new Customer()
        {
            Id = 5,
            Name = "Eva Williams",
            IsMember = false,
            DiscountedCategories = new List<string> { "Textile" }
        }
    };


    public void Add(Customer item)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Customer>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Customer> GetByCustomerId(int customerId)
    {
        return customers.First(x => x.Id == customerId);
    }
}
