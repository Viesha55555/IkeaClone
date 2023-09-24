using IkeaClone.Models;
using IkeaClone.Repository.Repositories;

namespace IkeaClone.Repository.Models
{
    public class HotDog : IProduct, IAggregateRoot
    {
        public string Flavor { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
