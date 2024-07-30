using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
#pragma warning disable IDE0005
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.CommentDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Services;

public class CommentService(ICommentDbService commentDbService, IMapper commentMapper) : ICommentService
{
    public ICollection<BanDurationDto> GetBanDurations()
    {
        var banDurations = commentDbService.GetBanDurationsDb();
        var banDurationModels = commentMapper.Map<ICollection<BanEntity>, ICollection<BanModel>>(banDurations);
        var banDurationDtos = commentMapper.Map<ICollection<BanModel>, ICollection<BanDurationDto>>(banDurationModels);

        return banDurationDtos;
    }

    public void BanUser(BanUserDto banUserDto)
    {
        throw new NotImplementedException();
    }
}