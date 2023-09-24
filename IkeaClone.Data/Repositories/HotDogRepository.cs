using IkeaClone.Repository.Models;

namespace IkeaClone.Repository.Repositories;

public class HotDogRepository : IHotDogRepository
{
    public List<HotDog> hotDogs = new()
    {
        new HotDog()
        {
            Flavor = "Kabanos",
            Price = 3.99M,
            Description = "Spicy kabanos hotdog"
        },
        new HotDog()
        {
            Flavor = "Classic",
            Price = 2.99M,
            Description = "Classic beef hotdog"
        },
        new HotDog()
        {
            Flavor = "Veggie",
            Price = 3.49M,
            Description = "Vegetarian hotdog"
        },
        new HotDog()
        {
            Flavor = "Chili",
            Price = 4.49M,
            Description = "Chili cheese hotdog"
        },
        new HotDog()
        {
            Flavor = "Bratwurst",
            Price = 3.79M,
            Description = "Savory bratwurst hotdog"
        }
    };
    public void Add(HotDog item)
    {
        throw new NotImplementedException();
    }

    public async Task<HotDog> FindByFlavor(string flavor)
    {
        return hotDogs.FirstOrDefault(o => o.Flavor == flavor);
    }

    public async Task<IList<HotDog>> GetAll()
    {
        return hotDogs;
    }
}
