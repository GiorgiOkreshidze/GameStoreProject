using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using DataAccess.Enums;
using Microsoft.EntityFrameworkCore;
using ArgumentNullException = System.ArgumentNullException;

namespace DataAccess.Services;
#pragma warning disable IDE0305
public class GameDbService(GameDbContext gameDbContext) : IGameDbService
{
    public ICollection<GameEntity> GetGamesDb()
    {
        return gameDbContext.GameEntities.AsNoTracking().ToList();
    }

    public void CreateGameDb(GameEntity gameEntity)
    {
        gameDbContext.AttachRange(gameEntity.PlatformEntities);
        gameDbContext.AttachRange(gameEntity.GenreEntities);
        gameDbContext.GameEntities.Add(gameEntity);
        gameDbContext.SaveChanges();
        /*foreach (var platformEntity in gameEntity.PlatformEntities)
        {
            var entry = gameDbContext.Entry(platformEntity);
            entry.State = EntityState.Detached;
        }

        foreach (var genreEntity in gameEntity.GenreEntities)
        {
            var entry = gameDbContext.Entry(genreEntity);
            entry.State = EntityState.Detached;
        }

        var gameEntry = gameDbContext.Entry(gameEntity);
        if (gameEntry.State != EntityState.Detached)
        {
            gameDbContext.Attach(gameEntity);
            gameEntry.State = EntityState.Detached;
        }*/
    }

    public void UpdateGameDb(GameEntity gameEntity)
    {
        ClearGenresByGameId(gameEntity.Id);
        ClearPlatformsByGameId(gameEntity.Id);

        // Attach platform entities only if they are not already tracked
        foreach (var platformEntity in gameEntity.PlatformEntities)
        {
            var trackedEntity = gameDbContext.ChangeTracker.Entries<PlatformEntity>()
                .FirstOrDefault(e => e.Entity.Id == platformEntity.Id);

            if (trackedEntity == null)
            {
                gameDbContext.Attach(platformEntity);
            }
            else
            {
                trackedEntity.State = EntityState.Unchanged;
            }
        }

        // Attach genre entities only if they are not already tracked
        foreach (var genreEntity in gameEntity.GenreEntities)
        {
            var trackedEntity = gameDbContext.ChangeTracker.Entries<GenreEntity>()
                .FirstOrDefault(e => e.Entity.Id == genreEntity.Id);

            if (trackedEntity == null)
            {
                gameDbContext.Attach(genreEntity);
            }
            else
            {
                trackedEntity.State = EntityState.Unchanged;
            }
        }

        // Track and update the game entity
        var trackedGameEntity = gameDbContext.GameEntities.Local
            .FirstOrDefault(e => e.Id == gameEntity.Id);

        if (trackedGameEntity == null)
        {
            gameDbContext.Attach(gameEntity);
        }
        else
        {
            gameDbContext.Entry(trackedGameEntity).CurrentValues.SetValues(gameEntity);
        }

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
        var gameEntity = gameDbContext.GameEntities
            .Include(game => game.PlatformEntities)
            .Include(game => game.GenreEntities)
            .FirstOrDefault(t => t.Key == key) ?? throw new ArgumentNullException();

        gameEntity.Views++;

        gameDbContext.SaveChanges();

        return gameEntity;
    }

    public GameEntity GetGameByIdDb(Guid id)
    {
        var gameEntity = gameDbContext.GameEntities
                             .Include(game => game.PlatformEntities)
                             .Include(game => game.GenreEntities)
                             .FirstOrDefault(t => t.Id == id) ?? throw new ArgumentNullException();

        gameEntity.Views++;

        UpdateGameDb(gameEntity);

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
        GameEntity entity;
        if (KeyNotExists(key))
        {
            return null;
        }
        else
        {
            entity = gameDbContext.GameEntities
                .Include(x => x.PlatformEntities)
                .FirstOrDefault(t => t.Key == key);
        }

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

        if (gameDbContext.OrderEntities.FirstOrDefault(o => o.CustomerId == newGuid && o.Status == OrderStatus.Open) is null)
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
                .FirstOrDefault(o => o.CustomerId == newGuid && o.Status == OrderStatus.Open) ?? throw new ArgumentNullException();
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
            gameDbContext.SaveChanges();
            orderGame = gameDbContext.OrderGames.FirstOrDefault(o => o.ProductId == gameEntity.Id) ?? throw new ArgumentNullException();
            orderGame.Price = gameEntity.Price;
            orderGame.Discount = gameEntity.Discount;
            orderGame.Quantity = 1;
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
        var deleteBody = "A comment/quote was deleted";
        var gameId = GetGameIdByKey(key);
        var commentEntity = gameDbContext.CommentEntities.FirstOrDefault(c => c.Id == id) ?? throw new ArgumentNullException();
        int commas = CountCommas(commentEntity.Body);
        DeleteCommentRecursively(gameId, commentEntity, deleteBody, commentEntity.Body, commas);
        commentEntity.Body = deleteBody;
        gameDbContext.SaveChanges();
    }

    public bool IsUserBanned(string name)
    {
        return gameDbContext.BannedUserEntities.Any(u => u.User == name);
    }

    public bool NotExists(Guid id)
    {
        return !gameDbContext.GameEntities.Any(t => t.Id == id);
    }

    public bool KeyNotExists(string key)
    {
        return !gameDbContext.GameEntities.Any(t => t.Key == key);
    }

    public void AddCommentWithoutGameDb(CommentEntity commentEntity)
    {
        gameDbContext.CommentEntities.Add(commentEntity);
        gameDbContext.SaveChanges();
    }

    private void DeleteCommentRecursively(Guid gameId, CommentEntity commentEntity, string deleteBody, string deletedCommentBody, int commas)
    {
        var childComments = gameDbContext.CommentEntities.Where(c => c.ParentCommentId == commentEntity.Id).ToList();
        if (childComments.Count == 0)
        {
            return;
        }

        foreach (var childComment in childComments)
        {
            var split = childComment.Body.Split(',');

            var arrays = SplitArray(split, commas + 1);

            var head = string.Join(',', arrays[0]);

            head = deleteBody;

            var tail = string.Join(',', arrays[1]);

            var body = head + "," + tail;

            childComment.Body = body;

            DeleteCommentRecursively(gameId, childComment, deleteBody, deletedCommentBody, commas);
        }

        gameDbContext.SaveChanges();
    }

    private static int CountCommas(string input)
    {
        return input == null ? throw new ArgumentNullException(nameof(input)) : input.Count(c => c == ',');
    }

    private static List<T[]> SplitArray<T>(T[] array, int subArrayLength)
    {
        var result = new List<T[]>();

        var head = new T[subArrayLength];
        var tail = new T[array.Length - subArrayLength];

        for (int i = 0; i < array.Length; i++)
        {
            if (i < subArrayLength)
            {
                head[i] = array[i];
            }
            else
            {
                tail[i - subArrayLength] = array[i];
            }
        }

        result.Add(head);
        result.Add(tail);
        return result;
    }
}