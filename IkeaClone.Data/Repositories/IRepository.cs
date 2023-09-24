namespace IkeaClone.Repository.Repositories;

public interface IRepository<T> where T : IAggregateRoot
{
    /// <summary>
    /// Adds the specified item.
    /// </summary>
    /// <param name="item">
    /// The item.
    /// </param>
    void Add(T item);

    /// <summary>
    /// Gets all items.
    /// </summary>
    /// <param name="item">
    /// The item.
    /// </param>
    Task<IList<T>> GetAll();
}