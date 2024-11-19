using AutoMapper;
using BusinessLogic.Models;
using MongoDbAccess.Models;
using MongoDbAccess.MongoDTOs;
#pragma warning disable IDE0005
using DataAccess.Entities;
using DTOs.CommentDtos;
using DTOs.GameDtos;
using DTOs.GenreDtos;
using DTOs.PlatformDtos;
using DTOs.PublisherDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.MappingProfiles;

public class GameProfile : Profile
{
    public GameProfile()
    {
        // GameDtos to GameModels
        CreateMap<GameDto, Game>().ReverseMap();
        CreateMap<CreateGameDto, Game>().IncludeMembers(src => src.Game)
            .ReverseMap();
        CreateMap<GameDtoWithId, Game>()
            .ForMember(dest => dest.ReorderLevel, opt => opt.MapFrom(src => src.ReorderLevel))
            .ForMember(dest => dest.UnitsOnOrder, opt => opt.MapFrom(src => src.UnitsOnOrder))
            .ForMember(dest => dest.QuantityPerUnit, opt => opt.MapFrom(src => src.QuantityPerUnit))
            .ReverseMap()
            .ForMember(dest => dest.QuantityPerUnit, opt => opt.MapFrom(src => src.QuantityPerUnit))
            .ForMember(dest => dest.UnitsOnOrder, opt => opt.MapFrom(src => src.UnitsOnOrder))
            .ForMember(dest => dest.ReorderLevel, opt => opt.MapFrom(src => src.ReorderLevel));
        CreateMap<UpdateGameDto, Game>().IncludeMembers(src => src.Game)
            .ForMember(dest => dest.PublisherId, opt => opt.MapFrom(src => src.Publisher))
            .ReverseMap()
            .ForMember(dest => dest.Publisher, opt => opt.MapFrom(src => src.PublisherId));
        CreateMap<Game, GetGameDto>().ReverseMap();

        // Models to entities
        CreateMap<GameEntity, Game>().ReverseMap();
        CreateMap<GenreEntity, Genre>().ReverseMap();
        CreateMap<PlatformEntity, Platform>().ReverseMap();
        CreateMap<PublisherEntity, Publisher>().ReverseMap();
        CreateMap<Comment, CommentEntity>().ReverseMap();

        // Other
        CreateMap<Genre, GenreDto>().ReverseMap();
        CreateMap<Platform, PlatformDto>().ReverseMap();
        CreateMap<Publisher, GetPublisherDto>().ReverseMap();
        CreateMap<CommentDto, Comment>().ReverseMap();
        CreateMap<AddCommentDto, Comment>().IncludeMembers(src => src.Comment)
            .ReverseMap();
        CreateMap<GameFilterDto, ProductMongoFilter>()
            .ForMember(dest => dest.ExcludeProducts, opt => opt.Ignore())
            .ForMember(dest => dest.Categories, opt => opt.Ignore())
            .ForMember(dest => dest.Suppliers, opt => opt.Ignore())
            .ReverseMap();

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