namespace IkeaClone.Models;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsMember { get; set; }
    public List<string> DiscountedCategories { get; set; }
}
