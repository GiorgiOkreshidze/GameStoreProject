#pragma warning disable IDE0005
using DTOs.CommentDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Contracts;

public interface ICommentService
{
    public void BanUser(BanUserDto banUserDto);

    public void AddComment(string key, AddCommentDto addCommentDto);

    public void DeleteComment(string key, Guid id);

    public ICollection<GetCommentDto> GetComments(string key);
}