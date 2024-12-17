using AutoMapper;
using BusinessLogic.Models;
using DataAccess.Entities;

namespace BusinessLogic.MappingProfiles;

public class NotificationMethodProfile : Profile
{
    public NotificationMethodProfile()
    {
        CreateMap<NotificationMethodEntity, NotificationMethod>().ReverseMap();
    }
}