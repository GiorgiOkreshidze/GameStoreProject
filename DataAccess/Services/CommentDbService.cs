using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver.Linq;

namespace DataAccess.Services;

public class CommentDbService(GameDbContext gameDbContext) : ICommentDbService
{
    public void BanUserDb(BannedUserEntity bannedUserEntity)
    {
        var nameExists = gameDbContext.CommentEntities.Any(c => c.Name == bannedUserEntity.User);

        if (nameExists)
        {
            gameDbContext.BannedUserEntities.Add(bannedUserEntity);
            gameDbContext.SaveChanges();
        }
        else
        {
            throw new Exception("Name Doesn't exists");
        }
    }

    public void AddCommentDb(string key, CommentEntity commentEntity)
    {
        var gameEntity = gameDbContext.GameEntities.Include(gameEntity => gameEntity.CommentEntities)
            .FirstOrDefault(g => g.Key == key) ?? throw new ArgumentNullException();
        commentEntity.GameEntity = gameEntity;
        gameDbContext.CommentEntities.Add(commentEntity);
        gameDbContext.SaveChanges();
    }

    public IDictionary<Guid, CommentEntity> GetCommentsDb(string key)
    {
        var dictionary = gameDbContext.CommentEntities
            .Where(c => c.GameEntity.Key == key)
            .ToDictionary(key => key.Id, value => value);

        return dictionary;
    }

    public bool IsUserBanned(string name)
    {
        return gameDbContext.BannedUserEntities.Any(u => u.User == name);
    }

    public void DeleteCommentDb(string key, Guid id)
    {
        var commentEntity = gameDbContext.CommentEntities.FirstOrDefault(c => c.Id == id) ?? throw new ArgumentNullException();
        commentEntity.Deleted = true;
        gameDbContext.SaveChanges();
    }

    public CommentEntity GetCommentById(Guid commentId)
    {
        return gameDbContext.CommentEntities.FirstOrDefault(c => c.Id == commentId) ?? null;
    }
}