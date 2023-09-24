namespace IkeaClone.Repository.Entities
{
    public class OrderItem
    {
        public OrderItemType OrderItemType { get; set; }
        public int Amount { get; set; }
        public int? OrderItemNumber { get; set; }
        public string? FlavorIdentifier { get; set;}
    }
}
