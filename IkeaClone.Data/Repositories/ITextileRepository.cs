using IkeaClone.Repository.Models;

namespace IkeaClone.Repository.Repositories
{
    public interface ITextileRepository : IRepository<Textile>
    {
        Task<Textile> FindByItemNumber(int id);
    }
}
