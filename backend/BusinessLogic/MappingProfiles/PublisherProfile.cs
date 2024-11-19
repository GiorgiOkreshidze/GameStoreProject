using AutoMapper;
using BusinessLogic.Models;
using MongoDbAccess.Models;
#pragma warning disable IDE0005
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.PublisherDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.MappingProfiles;

public class PublisherProfile : Profile
{
    public PublisherProfile()
    {
        // PublisherDtos to PublisherModels
        CreateMap<PublisherDto, Publisher>().ReverseMap();
        CreateMap<CreatePublisherDto, Publisher>().IncludeMembers(src => src.Publisher)
            .ReverseMap();
        CreateMap<Publisher, GetPublisherDto>().ReverseMap();
        CreateMap<PublisherDtoWithId, Publisher>().ReverseMap();
        CreateMap<UpdatePublisherDto, Publisher>().IncludeMembers(src => src.Publisher).ReverseMap();

        // Models to Entities
        CreateMap<PublisherEntity, Publisher>().ReverseMap();
        CreateMap<GameEntity, Game>().ReverseMap();

        // Other
        CreateMap<Game, GetGameDto>().ReverseMap();
        CreateMap<Game, CreateGameDto>().ReverseMap();

        CreateMap<PublisherEntity, SupplierDocument>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ReverseMap()
            .ForMember(dest => dest.Id, opt => opt.Ignore());

        CreateMap<PublisherEntity, SupplierDocument>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ReverseMap()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
        CreateMap<GenreEntity, CategoryDocument>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Name))
            .ReverseMap()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CategoryName));
        CreateMap<ProductDocument, GameEntity>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ProductName))
            .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.UnitPrice))
            .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.GameKey))
            .ForMember(dest => dest.Discount, opt => opt.MapFrom(src => src.Discontinued))
            .ForMember(dest => dest.UnitInStock, opt => opt.MapFrom(src => src.UnitsInStock))
            .ForMember(dest => dest.QuantityPerUnit, opt => opt.MapFrom(src => src.QuantityPerUnit))
            .ForMember(dest => dest.UnitsOnOrder, opt => opt.MapFrom(src => src.UnitsOnOrder))
            .ForMember(dest => dest.ReorderLevel, opt => opt.MapFrom(src => src.ReorderLevel))
            .ForMember(dest => dest.Views, opt => opt.MapFrom(src => src.Views))
            .ReverseMap()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.Price))
            .ForMember(dest => dest.GameKey, opt => opt.MapFrom(src => src.Key))
            .ForMember(dest => dest.Discontinued, opt => opt.MapFrom(src => src.Discount))
            .ForMember(dest => dest.UnitsInStock, opt => opt.MapFrom(src => src.UnitInStock))
            .ForMember(dest => dest.QuantityPerUnit, opt => opt.MapFrom(src => src.QuantityPerUnit))
            .ForMember(dest => dest.UnitsOnOrder, opt => opt.MapFrom(src => src.UnitsOnOrder))
            .ForMember(dest => dest.ReorderLevel, opt => opt.MapFrom(src => src.ReorderLevel))
            .ForMember(dest => dest.Views, opt => opt.MapFrom(src => src.Views));
    }
}