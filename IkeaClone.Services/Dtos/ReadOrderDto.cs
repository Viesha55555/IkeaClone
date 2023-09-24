namespace IkeaClone.Services.Dtos
{
    public class ReadOrderDto
    {
        public int OrderId { get; set; }
        public IList<OrderItemDto> Products { get; set; }
        public IList<string> AppliedDiscounts { get; set; }
    }
}
