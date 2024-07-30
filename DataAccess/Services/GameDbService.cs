using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;
#pragma warning disable IDE0305
public class GameDbService(GameDbContext gameDbContext) : IGameDbService
{
    public ICollection<GameEntity> GetAllGamesDb()
    {
        return gameDbContext.GameEntities.AsNoTracking().ToList();
    }

    public void CreateGameDb(GameEntity gameEntity)
    {
        gameDbContext.AttachRange(gameEntity.PlatformEntities);
        gameDbContext.AttachRange(gameEntity.GenreEntities);
        gameDbContext.GameEntities.Add(gameEntity);
        gameDbContext.SaveChanges();
    }

    public void UpdateGameDb(GameEntity gameEntity)
    {
        ClearGenresByGameId(gameEntity.Id);
        ClearPlatformsByGameId(gameEntity.Id);
        gameDbContext.AttachRange(gameEntity.PlatformEntities);
        gameDbContext.AttachRange(gameEntity.GenreEntities);
        gameDbContext.GameEntities.Update(gameEntity);
        gameDbContext.SaveChanges();
    }

    public void ClearGenresByGameId(Guid id)
    {
        var gameGenres = gameDbContext.GameGenres.Where(g => g.GameEntityId == id).ToList();

        foreach (var gameGenre in gameGenres)
        {
            gameDbContext.Remove(gameGenre);
        }

        gameDbContext.SaveChanges();
    }

    public void ClearPlatformsByGameId(Guid id)
    {
        var platforms = gameDbContext.GamePlatforms.Where(g => g.GameEntityId == id).ToList();

        foreach (var platform in platforms)
        {
            gameDbContext.Remove(platform);
        }

        gameDbContext.SaveChanges();
    }

    public void DeleteGameDb(GameEntity gameEntity)
    {
        gameDbContext.Entry(gameEntity).State = EntityState.Deleted;
        gameDbContext.SaveChanges();
    }

    public GameEntity GetGameByKeyDb(string key)
    {
        return gameDbContext.GameEntities.FirstOrDefault(t => t.Key == key);
    }

    public GameEntity GetGameByIdDb(Guid id)
    {
        return gameDbContext.GameEntities.FirstOrDefault(t => t.Id == id) ?? throw new ArgumentNullException();
    }

    public int GetGamesNumber()
    {
        return gameDbContext.GameEntities.Count();
    }

    public ICollection<GenreEntity> GetGenresOfGameDb(string key)
    {
        var entity = gameDbContext.GameEntities
            .Include(x => x.GenreEntities)
            .FirstOrDefault(t => t.Key == key) ?? throw new ArgumentNullException();

        return entity.GenreEntities;
    }

    public ICollection<PlatformEntity> GetPlatformsOfGameDb(string key)
    {
        var entity = gameDbContext.GameEntities
            .Include(x => x.PlatformEntities)
            .FirstOrDefault(t => t.Key == key) ?? throw new ArgumentNullException();

        return entity.PlatformEntities;
    }

    public PublisherEntity GetPublisherOfGameDb(string key)
    {
        var entity = gameDbContext.GameEntities
            .Include(x => x.PublisherEntity)
            .FirstOrDefault(t => t.Key == key) ?? throw new ArgumentNullException();

        return entity.PublisherEntity;
    }

    public void AddGameEntityToCartDb(GameEntity gameEntity)
    {
        OrderEntity entity;
        OrderGame orderGame;
        var newGuid = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6");

        if (gameDbContext.OrderEntities.FirstOrDefault(o => o.CustomerId == newGuid) is null)
        {
            entity = new OrderEntity();
            orderGame = new OrderGame
            {
                OrderId = entity.Id,
                ProductId = gameEntity.Id,
                Price = gameEntity.Price,
                Discount = gameEntity.Discount,
                Quantity = 0,
            };
            gameDbContext.OrderEntities.Add(entity);
            gameDbContext.OrderGames.Add(orderGame);
            gameDbContext.SaveChanges();
        }
        else
        {
            entity = gameDbContext.OrderEntities.Include(orderEntity => orderEntity.GameEntities)
                .FirstOrDefault(o => o.CustomerId == newGuid) ?? throw new ArgumentNullException();
        }

        if (entity.GameEntities.Contains(gameEntity))
        {
            orderGame = gameDbContext.OrderGames.FirstOrDefault(o => o.OrderId == entity.Id) ??
                            throw new ArgumentNullException();
            orderGame.Quantity += 1;
        }
        else
        {
            entity.GameEntities.Add(gameEntity);
        }

        gameDbContext.SaveChanges();
    }

    public void AddCommentDb(string key, CommentEntity commentEntity)
    {
        var gameEntity = gameDbContext.GameEntities.Include(gameEntity => gameEntity.CommentEntities)
            .FirstOrDefault(g => g.Key == key) ?? throw new ArgumentNullException();
        commentEntity.GameEntity = gameEntity;
        gameDbContext.CommentEntities.Add(commentEntity);
        gameDbContext.SaveChanges();
    }

    public ICollection<CommentEntity> GetCommentsDb(string key)
    {
        var entity = gameDbContext.GameEntities.Include(gameEntity => gameEntity.CommentEntities)
            .FirstOrDefault(g => g.Key == key) ?? throw new ArgumentNullException();

        return entity.CommentEntities;
    }

    public CommentEntity GetCommentById(Guid? commentId)
    {
        return gameDbContext.CommentEntities.FirstOrDefault(c => c.Id == commentId) ??
               throw new ArgumentNullException();
    }

    public Guid GetGameIdByKey(string key)
    {
        return gameDbContext.GameEntities.FirstOrDefault(g => g.Key == key).Id;
    }

    public void DeleteCommentDb(string key, Guid id)
    {
        var entity = gameDbContext.GameEntities.Include(gameEntity => gameEntity.CommentEntities)
            .FirstOrDefault(g => g.Key == key) ?? throw new ArgumentNullException();
        var commentEntity = entity.CommentEntities.FirstOrDefault(c => c.Id == id) ?? throw new ArgumentNullException();
        commentEntity.Body = "A comment/quote was deleted";
        gameDbContext.SaveChanges();
    }

    public bool NotExists(Guid id)
    {
        return !gameDbContext.GameEntities.Any(t => t.Id == id);
    }

    public bool KeyNotExists(string key)
    {
        return !gameDbContext.GameEntities.Any(t => t.Key == key);
    }
}