namespace IkeaClone.Data;

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
    /// Reads the item.
    /// </summary>
    /// <param name="item">
    /// The item.
    /// </param>
    void Read(T item);
}