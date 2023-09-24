using IkeaClone.Repository.Models;

namespace IkeaClone.Repository.Repositories;

public class TextileRepository : ITextileRepository
{
    public List<Textile> textiles = new List<Textile>
    {
        new Textile()
        {
            ItemNumber = 25,
            Description = "Nice textile",
            Price = 50,
            Color = "Red"
        },
        new Textile()
        {
            ItemNumber = 26,
            Description = "Soft cotton pillowcase",
            Price = 15,
            Color = "Blue"
        },
        new Textile()
        {
            ItemNumber = 27,
            Description = "Silk bedsheet set",
            Price = 120,
            Color = "Gold"
        },
        new Textile()
        {
            ItemNumber = 28,
            Description = "Striped beach towel",
            Price = 25,
            Color = "Green"
        },
        new Textile()
        {
            ItemNumber = 29,
            Description = "Plush bathrobe",
            Price = 35,
            Color = "White"
        }
    };
    public void Add(Textile item)
    {
        throw new NotImplementedException();
    }

    public async Task<Textile> FindByItemNumber(int? id)
    {
        return textiles.FirstOrDefault(o => o.ItemNumber == id);
    }

    public async Task<IList<Textile>> GetAll()
    {
        return textiles;
    }
}
