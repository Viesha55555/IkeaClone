using IkeaClone.Repository.Repositories;

namespace IkeaClone.Services.Services;

public class DiscountService : IDiscountService
{
    private readonly ICustomerRepository _customerRepository;

    public DiscountService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
    public async Task<IList<string>> GetCustomerDiscounts(int customerId)
    {
        var customer = await _customerRepository.GetByCustomerId(customerId);
        return customer.DiscountedCategories;
    }
}
