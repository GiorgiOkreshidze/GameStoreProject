using AutoMapper;
using BusinessLogic.Models;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.OrderDtos;
using DTOs.PaymentMethodDtos;

namespace BusinessLogic.MappingProfiles;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<GameEntity, Game>().ReverseMap();
        CreateMap<Game, GetGameDto>().ReverseMap();
        CreateMap<Game, CreateGameDto>().ReverseMap();
        CreateMap<Order, OrderEntity>().ReverseMap();
        CreateMap<GetOrderDto, Order>().ReverseMap();
        CreateMap<OrderGameModel, OrderGame>().ReverseMap();
        CreateMap<OrderGameModel, GetOrderDetailsDto>().ReverseMap();
        CreateMap<PaymentMethodModel, PaymentMethod>().ReverseMap();
        CreateMap<PaymentMethodModel, GetPaymentMethodDto>().ReverseMap();
    }
}