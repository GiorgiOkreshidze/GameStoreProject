using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using DTOs.GameDtos;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using X.PagedList.Extensions;

namespace DataAccess.Services;
#pragma warning disable IDE0305
public class GameDbService(GameDbContext gameDbContext) : IGameDbService
{
    public IPagedList<GameEntity> GetGamesDb(GameFilterDto filter, GameSortDto sort, GamePaginationDto pagination)
    {
        var query = gameDbContext.GameEntities.AsQueryable();

        if (!FilterIsDefault(filter))
        {
            if (filter.GenreIds != null && filter.GenreIds.Any())
            {
                query = query.Where(g => g.GenreEntities.Any(genre => filter.GenreIds.Contains(genre.Id)));
            }

            if (filter.PlatformIds != null && filter.PlatformIds.Any())
            {
                query = query.Where(g => g.PlatformEntities.Any(platform => filter.PlatformIds.Contains(platform.Id)));
            }

            if (filter.PublisherIds != null && filter.PublisherIds.Any())
            {
                query = query.Where(g => filter.PublisherIds.Contains(g.PublisherId!.Value));
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

        if (!SortIsDefault(sort))
        {
            query = sort.SortBy switch
            {
                "Most popular" => query.OrderByDescending(g => g.Views),
                "Most commented" => query.OrderByDescending(g => g.CommentEntities.Count),
                "Price ASC" => query.OrderBy(g => g.Price),
                "Price DESC" => query.OrderByDescending(g => g.Price),
                "New" => query.OrderByDescending(g => g.PublishDate),
                _ => query,
            };
        }

        IPagedList<GameEntity> pagedResult;
        if (!PaginationIsDefault(pagination))
        {
            try
            {
                pagedResult = query.ToPagedList(pagination.PageNumber, pagination.PageSize);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while applying pagination.", ex);
            }
        }
        else
        {
            pagedResult = new StaticPagedList<GameEntity>(query.ToList(), 1, query.Count(), query.Count());
        }

        return pagedResult;
    }

    public static bool PaginationIsDefault(GamePaginationDto paginationDto) => paginationDto.PageNumber <= 0 && paginationDto.PageSize <= 0;

    public static bool FilterIsDefault(GameFilterDto filterDto) => (filterDto.GenreIds == null || !filterDto.GenreIds.Any())
                                                  && (filterDto.PlatformIds == null || !filterDto.PlatformIds.Any())
                                                  && (filterDto.PublisherIds == null || !filterDto.PublisherIds.Any())
                                                  && !filterDto.MinPrice.HasValue
                                                  && !filterDto.MaxPrice.HasValue
                                                  && string.IsNullOrEmpty(filterDto.Name)
                                                  && string.IsNullOrEmpty(filterDto.PublishDateRange);

    public static bool SortIsDefault(GameSortDto sortDto) => string.IsNullOrEmpty(sortDto.SortBy);

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
        var gameEntity = gameDbContext.GameEntities
            .Include(game => game.PlatformEntities)
            .Include(game => game.GenreEntities)
            .FirstOrDefault(t => t.Key == key) ?? throw new ArgumentNullException();

        gameEntity.Views++;

        UpdateGameDb(gameEntity);

        return gameDbContext.GameEntities.FirstOrDefault(t => t.Key == key);
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
        var deleteBody = "A comment/quote was deleted";
        var gameId = GetGameIdByKey(key);
        var commentEntity = gameDbContext.CommentEntities.FirstOrDefault(c => c.Id == id) ?? throw new ArgumentNullException();
        DeleteCommentRecursively(gameId, commentEntity, deleteBody, commentEntity.Body);
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

    private void DeleteCommentRecursively(Guid gameId, CommentEntity commentEntity, string deleteBody, string deletedCommentBody)
    {
        var childComments = gameDbContext.CommentEntities.Where(c => c.ParentCommentId == commentEntity.Id).ToList();
        if (childComments.Count == 0)
        {
            return;
        }

        foreach (var childComment in childComments)
        {
            childComment.Body = childComment.Body.Replace(deletedCommentBody + ',', deleteBody + ',');
            DeleteCommentRecursively(gameId, childComment, deleteBody, deletedCommentBody);
        }

        gameDbContext.SaveChanges();
    }
}