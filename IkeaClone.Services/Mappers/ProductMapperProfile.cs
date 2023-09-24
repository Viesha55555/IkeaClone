using AutoMapper;
using IkeaClone.Repository.Entities;
using IkeaClone.Repository.Models;
using IkeaClone.Services.Dtos;

namespace IkeaClone.Services.Mappers;

internal class ProductMapperProfile : Profile
{
    public ProductMapperProfile()
    {
        CreateMap<Furniture, OrderItemDto>()
            .ForMember(dest => dest.OrderItemType, o => o.MapFrom(map => OrderItemType.Furniture.ToString()))
            .ForMember(dest => dest.Color, o => o.Ignore())
            .ForMember(dest => dest.Flavor, o => o.Ignore());

        CreateMap<Textile, OrderItemDto>()
            .ForMember(dest => dest.OrderItemType, o => o.MapFrom(map => OrderItemType.Textile.ToString()))
            .ForMember(dest => dest.Weight, o => o.Ignore())
            .ForMember(dest => dest.Flavor, o => o.Ignore());

        CreateMap<HotDog, OrderItemDto>()
            .ForMember(dest => dest.OrderItemType, o => o.MapFrom(map => OrderItemType.HotDogs.ToString()))
            .ForMember(dest => dest.ItemNumber, o => o.Ignore())
            .ForMember(dest => dest.Weight, o => o.Ignore())
            .ForMember(dest => dest.Color, o => o.Ignore());         
    }
}
