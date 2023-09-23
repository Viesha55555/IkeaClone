namespace IkeaClone.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ItemNumber { get; set; }
        public string Color { get; set; }
        public decimal Weight { get; set; }
        public string Flavor { get; set; }
    }
}
