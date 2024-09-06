using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using DataAccess.Enums;
using DTOs.GameDtos;
using Microsoft.EntityFrameworkCore;
using ArgumentNullException = System.ArgumentNullException;

namespace DataAccess.Services;
#pragma warning disable IDE0305
public class GameDbService(GameDbContext gameDbContext) : IGameDbService
{
    public ICollection<GameEntity> GetGamesDb(GameFilterDto filter)
    {
        var query = gameDbContext.GameEntities.AsNoTracking();

        if (!FilterIsDefault(filter))
        {
            if (filter.Genres != null && filter.Genres.Any())
            {
                query = query.Where(g => g.GenreEntities.Any(genre => filter.Genres.Contains(genre.Id)));
            }

            if (filter.Platforms != null && filter.Platforms.Any())
            {
                query = query.Where(g => g.PlatformEntities.Any(platform => filter.Platforms.Contains(platform.Id)));
            }

            if (filter.Publishers != null && filter.Publishers.Any())
            {
                query = query.Where(g => filter.Publishers.Contains(g.PublisherId!.Value));
            }

            if (filter.MinPrice.HasValue)
            {
                query = query.Where(g => g.Price >= filter.MinPrice.Value);
            }

            if (filter.MaxPrice.HasValue)
            {
                query = query.Where(g => g.Price <= filter.MaxPrice.Value);
            }

            if (!string.IsNullOrEmpty(filter.Name) && filter.Name.Length >= 3)
            {
                query = query.Where(g => g.Name.Contains(filter.Name));
            }

            if (!string.IsNullOrEmpty(filter.PublishDateRange))
            {
                var dateRange = GetDateRange(filter.PublishDateRange);
                query = query.Where(g => g.PublishDate >= dateRange.Start && g.PublishDate <= dateRange.End);
            }
        }

        return query.ToList();
    }

    public static bool FilterIsDefault(GameFilterDto filterDto) => (filterDto.Genres == null || !filterDto.Genres.Any())
                                                                   && (filterDto.Platforms == null || !filterDto.Platforms.Any())
                                                                   && (filterDto.Publishers == null || !filterDto.Publishers.Any())
                                                                   && !filterDto.MinPrice.HasValue
                                                                   && !filterDto.MaxPrice.HasValue
                                                                   && string.IsNullOrEmpty(filterDto.Name)
                                                                   && string.IsNullOrEmpty(filterDto.PublishDateRange);

    public static DateRange GetDateRange(string range)
    {
        return range switch
        {
            "last week" => new DateRange(DateTime.Now.AddDays(-7), DateTime.Now),
            "last month" => new DateRange(DateTime.Now.AddMonths(-1), DateTime.Now),
            "last year" => new DateRange(DateTime.Now.AddYears(-1), DateTime.Now),
            "2 years" => new DateRange(DateTime.Now.AddYears(-2), DateTime.Now),
            "3 years" => new DateRange(DateTime.Now.AddYears(-3), DateTime.Now),
            _ => null,
        };
    }

    public void CreateGameDb(GameEntity gameEntity)
    {
        gameDbContext.AttachRange(gameEntity.PlatformEntities);
        gameDbContext.AttachRange(gameEntity.GenreEntities);
        gameDbContext.Attach(gameEntity.PublisherEntity);
        gameDbContext.GameEntities.Add(gameEntity);
        gameDbContext.SaveChanges();

        foreach (var platformEntity in gameEntity.PlatformEntities)
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
        }

        var publisher = gameDbContext.Entry(gameEntity.PublisherEntity);
        publisher.State = EntityState.Detached;
    }

    public void UpdateGameDb(GameEntity gameEntity)
    {
        ClearGenresByGameId(gameEntity.Id);
        ClearPlatformsByGameId(gameEntity.Id);

        gameDbContext.AttachRange(gameEntity.PlatformEntities);
        gameDbContext.AttachRange(gameEntity.GenreEntities);
        gameDbContext.Attach(gameEntity.PublisherEntity);

        gameDbContext.Update(gameEntity);
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
        gameEntity.Deleted = true;
        gameDbContext.Update(gameEntity);
        gameDbContext.SaveChanges();
        gameDbContext.Entry(gameEntity).State = EntityState.Detached;
    }

    public GameEntity GetGameByKeyDb(string key)
    {
        var gameEntity = gameDbContext.GameEntities
            .Include(game => game.PlatformEntities)
            .Include(game => game.GenreEntities)
            .AsNoTracking()
            .FirstOrDefault(t => t.Key == key);

        return gameEntity;
    }

    public GameEntity GetGameByIdDb(Guid id)
    {
        var gameEntity = gameDbContext.GameEntities
                             .Include(game => game.PlatformEntities)
                             .Include(game => game.GenreEntities)
                             .FirstOrDefault(t => t.Id == id);

        return gameDbContext.GameEntities.AsNoTracking().FirstOrDefault(t => t.Id == id);
    }

    public int GetGamesNumber()
    {
        return gameDbContext.GameEntities.Count();
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
            orderGame = gameDbContext.OrderGames.FirstOrDefault(o => o.ProductId == gameEntity.Id &&
                                                                     o.OrderId == entity.Id) ??
                            throw new ArgumentNullException();
            orderGame.Quantity += 1;
        }
        else
        {
            entity.GameEntities.Add(gameEntity);
            gameDbContext.SaveChanges();
            orderGame = gameDbContext.OrderGames.FirstOrDefault(o => o.ProductId == gameEntity.Id &&
                                                                     o.OrderId == entity.Id) ?? throw new ArgumentNullException();
            orderGame.Price = gameEntity.Price;
            orderGame.Discount = gameEntity.Discount;
            orderGame.Quantity = 1;
        }

        gameDbContext.SaveChanges();
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

    public bool NotExists(Guid id)
    {
        return !gameDbContext.GameEntities.Any(t => t.Id == id);
    }

    public bool KeyNotExists(string key)
    {
        return !gameDbContext.GameEntities.AsNoTracking().Any(t => t.Key == key);
    }

    public ICollection<GameEntity> GetGamesWithoutFilterDb()
    {
        return gameDbContext.GameEntities.AsNoTracking().ToList();
    }

    public void AddCommentWithoutGameDb(CommentEntity commentEntity)
    {
        gameDbContext.CommentEntities.Add(commentEntity);
        gameDbContext.SaveChanges();
    }

    public ICollection<GameEntity> GetGamesByPlatformId(Guid id)
    {
        return gameDbContext.PlatformEntities
            .Where(t => t.Id == id)
            .SelectMany(t => t.GameEntities)
            .ToList();
    }

    public ICollection<GameEntity> GetGamesByGenreId(Guid id)
    {
        return gameDbContext.GenreEntities
            .Where(t => t.Id == id)
            .SelectMany(t => t.GameEntities)
            .ToList();
    }

    public ICollection<GameEntity> GetGamesOfPublisherDb(string companyName)
    {
        return gameDbContext.GameEntities
            .Where(t => t.PublisherEntity.CompanyName == companyName)
            .ToList();
    }

    public void IncreaseGameViews(Guid gameId)
    {
        var gameEntity = gameDbContext.GameEntities.FirstOrDefault(a => a.Id == gameId);

        gameEntity.Views++;

        gameDbContext.Update(gameEntity);

        gameDbContext.SaveChanges();

        gameDbContext.Entry(gameEntity).State = EntityState.Detached;
    }
}