using AutoMapper;
using BusinessLogic.Models;
#pragma warning disable IDE0005
using DataAccess.Entities;
#pragma warning restore IDE0005
using DTOs.GameDtos;
using DTOs.OrderDtos;
using DTOs.PaymentMethodDtos;
#pragma warning disable IDE0005
using MongoDbAccess.Models;
#pragma warning restore IDE0005

namespace BusinessLogic.MappingProfiles;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<GameEntity, Game>().ReverseMap();
        CreateMap<Game, GetGameDto>().ReverseMap();
        CreateMap<Game, CreateGameDto>().ReverseMap();
        CreateMap<Order, OrderEntity>().ReverseMap();
        CreateMap<CombinedOrderModel, OrderEntity>().ReverseMap();
        CreateMap<CombinedOrderModel, OrderDocument>()
            .ForMember(
                dest => dest.OrderDate,
                opt => opt.MapFrom(src => src.Date))
            .ReverseMap()
            .ForMember(
                dest => dest.Date,
                opt => opt.MapFrom(src => src.OrderDate));
        CreateMap<GetOrderDto, Order>().ReverseMap();
        CreateMap<OrderDto, CombinedOrderModel>().ReverseMap();
        CreateMap<OrderGameModel, OrderGame>().ReverseMap();
        CreateMap<OrderGameModel, GetOrderDetailsDto>().ReverseMap();
        CreateMap<PaymentMethodModel, PaymentMethod>().ReverseMap();
        CreateMap<PaymentMethodModel, PaymentMethods>().ReverseMap();

        CreateMap<OrderEntity, OrderDocument>()
            .ForMember(
                dest => dest.Id,
                opt => opt.Ignore())
            .ForMember(
                dest => dest.OrderDate,
                opt => opt.MapFrom(src => src.Date))
            .ForMember(
                dest => dest.CustomerID,
                opt => opt.Ignore())
            .ReverseMap()
            .ForMember(
                dest => dest.Id,
                opt => opt.Ignore())
            .ForMember(
                dest => dest.CustomerId,
                opt => opt.Ignore())
            .ForMember(
                dest => dest.Date,
                opt => opt.MapFrom(src => src.OrderDate));

        CreateMap<OrderDetailsDocument, OrderGame>()
            .ForMember(dest => dest.ProductId, opt => opt.Ignore())
            .ForMember(dest => dest.OrderId, opt => opt.Ignore())
            .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.UnitPrice))
            .ReverseMap()
            .ForMember(dest => dest.ProductID, opt => opt.Ignore())
            .ForMember(dest => dest.OrderID, opt => opt.Ignore())
            .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.Price));
    }
}