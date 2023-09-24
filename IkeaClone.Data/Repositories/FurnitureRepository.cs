using IkeaClone.Models;
using IkeaClone.Repository.Models;

namespace IkeaClone.Repository.Repositories;

public class FurnitureRepository : IFurnitureRepository
{
    public List<Furniture> furniture = new List<Furniture>() {
        new Furniture()
        {
            ItemNumber = 1,
            Description = "Sofa",
            Price = 50,
            Weight = 50
        },
        new Furniture()
        {
            ItemNumber = 2,
            Description = "Chair",
            Price = 20,
            Weight = 15
        },
        new Furniture()
        {
            ItemNumber = 3,
            Description = "Table",
            Price = 35,
            Weight = 35
        }
    };

    public void Add(Furniture item)
    {
        throw new NotImplementedException();
    }

    public async Task<Furniture> FindByItemNumber(int? id)
    {
        return furniture.FirstOrDefault(o => o.ItemNumber == id);
    }

    public IList<Furniture> GetAll()
    {
        return furniture;
    }
}
