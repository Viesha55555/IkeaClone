using IkeaClone.Repository.Models;

namespace IkeaClone.Repository.Repositories
{
    public interface IHotDogRepository : IRepository<HotDog>
    {
        Task<HotDog> FindByFlavor(string flavor);
    }
}
