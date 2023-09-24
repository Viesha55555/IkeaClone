using IkeaClone.Models;
using IkeaClone.Repository.Repositories;

namespace IkeaClone.Repository.Models
{
    public class Furniture : Relational, IProduct, IAggregateRoot
    {
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
    }
}
