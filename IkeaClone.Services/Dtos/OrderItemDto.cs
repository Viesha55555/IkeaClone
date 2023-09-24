namespace IkeaClone.Services.Dtos
{
    public class OrderItemDto
    {
        public string OrderItemType { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int? ItemNumber { get; set; }
        public decimal? Weight { get; set; }
        public string? Color { get; set;}
        public string? Flavor { get; set; }
    }
}