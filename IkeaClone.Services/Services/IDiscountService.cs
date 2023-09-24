namespace IkeaClone.Services.Services;

public interface IDiscountService
{
    public Task<IList<string>> GetCustomerDiscounts(int customerId);
}
