using IkeaClone.Repository.Models;

namespace IkeaClone.Repository.Repositories
{
    public interface IFurnitureRepository : IRepository<Furniture>
    {
        Task<Furniture> FindByItemNumber(int id);
    }
}
