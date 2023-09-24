using IkeaClone.Repository.Models;
using IkeaClone.Repository.Repositories;

namespace IkeaClone.Services.Services;

public class ReadOrderItemsService : IReadOrderItemsService
{
    protected readonly IFurnitureRepository _furnitureRepository;
    protected readonly ITextileRepository _textileRepository;
    protected readonly IHotDogRepository _hotdogRepository;

    public ReadOrderItemsService(IFurnitureRepository furnitureRepository,
        ITextileRepository textileRepository,
        IHotDogRepository hotDogRepository)
    {
        _furnitureRepository = furnitureRepository;
        _textileRepository = textileRepository;
        _hotdogRepository = hotDogRepository;
    }
    public async Task<Furniture> GetFurnitureByItemNumber(int itemNumber)
    {
        return await _furnitureRepository.FindByItemNumber(itemNumber);
    }

    public async Task<Textile> GetTextileByItemNumber(int itemNumber)
    {
        return await _textileRepository.FindByItemNumber(itemNumber);
    }
    public async Task<HotDog> GetHotDogByFlavor(string flavor)
    {
        return await _hotdogRepository.FindByFlavor(flavor);
    }
}
