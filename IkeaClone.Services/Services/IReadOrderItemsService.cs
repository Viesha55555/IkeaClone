using IkeaClone.Repository.Models;

namespace IkeaClone.Services.Services;

public interface IReadOrderItemsService
{
    public Task<Furniture> GetFurnitureByItemNumber(int? itemNumber);
    public Task<Textile> GetTextileByItemNumber(int? itemNumber);
    public Task<HotDog> GetHotDogByFlavor(string? flavor);
}
