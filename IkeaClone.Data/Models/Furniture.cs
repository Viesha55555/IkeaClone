using IkeaClone.Models;

namespace IkeaClone.Repository.Models
{
    public class Furniture : NonEdibles, IProduct
    {
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
    }
}
