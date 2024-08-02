using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using DataAccess.Entities;
#pragma warning disable IDE0005
using DataAccess.Contracts;
using DTOs.CommentDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Services;

public class CommentService(ICommentDbService commentDbService, IMapper commentMapper) : ICommentService
{
    public void BanUser(BanUserDto banUserDto)
    {
        var bannedUser = commentMapper.Map<BanUserDto, BannedUser>(banUserDto);
        var bannedUserEntity = commentMapper.Map<BannedUser, BannedUserEntity>(bannedUser);

        commentDbService.BanUserDb(bannedUserEntity);
    }
}