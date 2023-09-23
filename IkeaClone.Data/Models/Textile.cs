using IkeaClone.Models;

namespace IkeaClone.Repository.Models
{
    internal class Textile : NonEdibles, IProduct
    {
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
    }
}
