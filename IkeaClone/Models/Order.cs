namespace IkeaClone.Models;

public class Order
{
    public int Id { get; set; }
    public List<Product> Products { get; set; }
    public int CustomerId { get; set; }
}
