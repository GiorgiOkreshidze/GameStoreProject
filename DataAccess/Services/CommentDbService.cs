using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;

#pragma warning disable IDE0305
public class CommentDbService(GameDbContext gameDbContext) : ICommentDbService
{
    public ICollection<BanEntity> GetBanDurationsDb()
    {
        return gameDbContext.BanEntities.AsNoTracking().ToList();
    }
}