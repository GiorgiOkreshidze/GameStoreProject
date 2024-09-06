using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using BusinessLogic.Strategies.CommentStrategies;
using BusinessLogic.Validations;
using Microsoft.IdentityModel.Tokens;
#pragma warning disable IDE0005
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.CommentDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Services;

public class CommentService(
    ICommentDbService commentDbService,
    IMapper commentMapper,
    IGameDbService gameDbService,
    IEnumerable<ICommentStrategy> commentStrategies,
    CommentValidator commentValidator) : ICommentService
{
    public void BanUser(BanUserDto banUserDto)
    {
        commentValidator.CanBanUser(banUserDto.User);

        var bannedUser = commentMapper.Map<BanUserDto, BannedUser>(banUserDto);
        var bannedUserEntity = commentMapper.Map<BannedUser, BannedUserEntity>(bannedUser);

        commentDbService.BanUserDb(bannedUserEntity);
    }

    public void AddComment(string key, AddCommentDto addCommentDto)
    {
        commentValidator.CanAddComment(key);

        var comment = commentMapper.Map<AddCommentDto, Comment>(addCommentDto);
        comment.ParentCommentId = addCommentDto.ParentId;
        comment.Id = Guid.NewGuid();

        var commentEntity = commentMapper.Map<Comment, CommentEntity>(comment);

        commentEntity.Deleted = false;

        commentDbService.AddCommentDb(key, commentEntity);
    }

    public ICollection<GetCommentDto> GetComments(string key)
    {
        if (gameDbService.KeyNotExists(key))
        {
            return [];
        }

        var commentEntities = commentDbService.GetCommentsDb(key);

        if (commentEntities.IsNullOrEmpty())
        {
            return [];
        }

        var parentBuckets = new Dictionary<Guid, List<GetCommentDto>>();

        foreach (var commentId in commentEntities.Keys)
        {
            var commentEntity = commentEntities[commentId];
            var commentDto = new GetCommentDto
            {
                Id = commentEntity.Id,
                Name = commentEntity.Name,
                Body = ICommentStrategy.GetCommentStrategy(commentStrategies, commentEntity.Action)
                    .GetCommentBody(commentId, commentEntities, commentStrategies),
            };

            if (!parentBuckets.ContainsKey(commentId))
            {
                var commentList = new List<GetCommentDto>();
                parentBuckets.Add(commentId, commentList);
            }

            commentDto.ChildComments = parentBuckets[commentId];

            var parentId = commentEntity.ParentCommentId == null ? Guid.Empty : (Guid)commentEntity.ParentCommentId!;
            if (!parentBuckets.ContainsKey(parentId))
            {
                var commentList = new List<GetCommentDto>();
                parentBuckets.Add(parentId, commentList);
            }

            parentBuckets[parentId].Add(commentDto);
        }

        return parentBuckets[Guid.Empty];
    }

    public void DeleteComment(string key, Guid id)
    {
        commentValidator.CanDeleteComment(id);
        commentDbService.DeleteCommentDb(key, id);
    }
}