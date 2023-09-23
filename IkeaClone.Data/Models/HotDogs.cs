using IkeaClone.Models;

namespace IkeaClone.Repository.Models
{
    internal class HotDogs : IProduct
    {
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Flavor { get; set; }
        //public int Id { get; set; }
    }
}
