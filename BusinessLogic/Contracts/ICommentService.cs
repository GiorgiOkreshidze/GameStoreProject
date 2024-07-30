#pragma warning disable IDE0005
using DTOs.CommentDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Contracts;

public interface ICommentService
{
    public ICollection<BanDurationDto> GetBanDurations();

    public void BanUser(BanUserDto banUserDto);
}