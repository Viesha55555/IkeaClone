using IkeaClone.Models;
using IkeaClone.Repository.Repositories;

namespace IkeaClone.Repository.Models
{
    public class Textile : Relational, IProduct, IAggregateRoot
    {
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
    }
}
