namespace IkeaClone.Models;

public class Order
{
    public int Id { get; set; }
    public List<IProduct> Products { get; set; }
    public int CustomerId { get; set; }
}
