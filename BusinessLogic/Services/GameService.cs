using System.Globalization;
using System.Text.RegularExpressions;
using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using BusinessLogic.Validations;
#pragma warning disable IDE0005
using DataAccess.Contracts;
using DataAccess.Entities;
#pragma warning restore IDE0005
using DTOs.CommentDtos;
using DTOs.GameDtos;
using DTOs.GenreDtos;
using DTOs.PlatformDtos;
using DTOs.PublisherDtos;
using Microsoft.IdentityModel.Tokens;
using MongoDbAccess.Contracts;
using MongoDbAccess.Models;
using X.PagedList;
using X.PagedList.Extensions;
using DateRange = DataAccess.Entities.DateRange;

namespace BusinessLogic.Services;

public class GameService(IGameDbService gameDbService, IMapper gameMapper,
    IValidationsHandler validator, IDatabasesSyncDbService databasesSyncDbService, IProductMongoService productMongoService,
    IPublisherDbService publisherDbService, IGenreDbService genreDbService,
    ISupplierMongoService supplierMongoService, ICategoryMongoService categoryMongoService) : IGameService
{
    private static readonly Regex MyRegex = new(@"\s+", RegexOptions.Compiled);

    public GetPagedGameDto GetGames(GameFilterDto filter, GameSortDto sort, GamePaginationDto pagination)
    {
        var gameEntities = gameDbService.GetGamesDb();
        var productDocuments = productMongoService.GetAllMongo();

        foreach (var productDocument in productDocuments)
        {
            var supplierDocument = productMongoService.GetSupplierOfProduct(productDocument.SupplierID);
            var supplierId = databasesSyncDbService.TransferMongoIdToDb(supplierDocument.Id);
            PublisherEntity publisherEntity;
            if (publisherDbService.PublisherNotExists(supplierId))
            {
                publisherEntity = gameMapper.Map<SupplierDocument, PublisherEntity>(supplierDocument);
                publisherEntity.Id = supplierId;
            }
            else
            {
                publisherEntity = publisherDbService.GetPublisherByCompanyNameDb(supplierDocument.CompanyName);
            }

            var categoryDocument = productMongoService.GetCategoryOfProduct(productDocument.CategoryID);
            var categoryId = databasesSyncDbService.TransferMongoIdToDb(categoryDocument.Id);
            GenreEntity genreEntity;
            if (genreDbService.NotExists(categoryId))
            {
                genreEntity = gameMapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
                genreEntity.Id = categoryId;
            }
            else
            {
                genreEntity = genreDbService.GetGenreByGuid(categoryId);
            }

            var id = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
            var gameEntity = gameMapper.Map<ProductDocument, GameEntity>(productDocument);
            if (productDocument.GameKey.IsNullOrEmpty())
            {
                var gameKey = GenerateKeyFromName(productDocument.ProductName);
                productDocument.GameKey = gameKey;
                productMongoService.UpdateProduct(productDocument);
            }

            gameEntity.Id = id;
            gameEntity.PublisherEntity = publisherEntity;
            gameEntity.PublisherId = publisherEntity.Id;
            gameEntity.GenreEntities = [genreEntity];
            if (gameEntities.All(p => p.Id != id))
            {
                gameEntities.Add(gameEntity);
            }
        }

        var query = gameEntities.AsQueryable();

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
            query = sort.Sort switch
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
            pagedResult = new StaticPagedList<GameEntity>([.. query], 1, query.Count(), query.Count());
        }

        var games = gameMapper.Map<ICollection<GameEntity>, ICollection<Game>>([.. pagedResult]);

        var gameDtosWithId = gameMapper.Map<ICollection<Game>, ICollection<GameDtoWithId>>(games);

        var getGameDto = new GetPagedGameDto
        {
            Games = new StaticPagedList<GameDtoWithId>(gameDtosWithId, pagedResult.PageNumber, pagedResult.PageSize, pagedResult.TotalItemCount),
            TotalPages = pagedResult.PageCount,
            CurrentPage = pagedResult.PageNumber,
        };

        return getGameDto;
    }

    public static bool PaginationIsDefault(GamePaginationDto paginationDto) => paginationDto is { PageNumber: <= 1, PageSize: <= 0 };

    public static bool FilterIsDefault(GameFilterDto filterDto) => (filterDto.GenreIds == null || !filterDto.GenreIds.Any())
                                                                   && (filterDto.PlatformIds == null || !filterDto.PlatformIds.Any())
                                                                   && (filterDto.PublisherIds == null || !filterDto.PublisherIds.Any())
                                                                   && !filterDto.MinPrice.HasValue
                                                                   && !filterDto.MaxPrice.HasValue
                                                                   && string.IsNullOrEmpty(filterDto.Name)
                                                                   && string.IsNullOrEmpty(filterDto.PublishDateRange);

    public static bool SortIsDefault(GameSortDto sortDto) => string.IsNullOrEmpty(sortDto.Sort);

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

    public void CreateGame(CreateGameDto createGameDto)
    {
        var game = gameMapper.Map<GameDto, Game>(createGameDto.Game);
        game.Platforms = createGameDto.Platforms;
        game.Genres = createGameDto.Genres;
        game.PublisherId = createGameDto.Publisher;

        game.Id = Guid.NewGuid();

        if (string.IsNullOrWhiteSpace(game.Key))
        {
            game.Key = GenerateKeyFromName(game.Name);
        }

        /*validator.ValidateGenres(game.Genres);
        validator.ValidatePlatforms(game.Platforms);
        validator.ValidatePublisherId(game.PublisherId);*/

        var gameEntity = gameMapper.Map<Game, GameEntity>(game);

        gameEntity.GenreEntities = [];
        gameEntity.PlatformEntities = [];

        foreach (var genreId in game.Genres)
        {
            GenreEntity transferedGenreEntity = new();
            if (genreDbService.NotExists(genreId) && databasesSyncDbService.ExistsInIdsSet(genreId))
            {
                var mongoId = databasesSyncDbService.GetMongoId(genreId);
                var categoryDocument = categoryMongoService.GetCategoryByIdMongo(mongoId);
                transferedGenreEntity = gameMapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
                transferedGenreEntity.Id = genreId;
                genreDbService.CreateGenreDb(transferedGenreEntity);
            }

            gameEntity.GenreEntities.Add(transferedGenreEntity);
        }

        foreach (var platformId in game.Platforms)
        {
            var stubPlatform = new PlatformEntity()
            {
                Id = platformId,
            };

            gameEntity.PlatformEntities.Add(stubPlatform);
        }

        if (gameEntity.PublisherId is not null)
        {
            if (publisherDbService.PublisherNotExists((Guid)gameEntity.PublisherId) && databasesSyncDbService.ExistsInIdsSet((Guid)gameEntity.PublisherId))
            {
                var mongoId = databasesSyncDbService.GetMongoId((Guid)gameEntity.PublisherId);
                var supplierDocument = supplierMongoService.GetSupplierByIdMongo(mongoId);
                var transferedPublisherEntity = gameMapper.Map<SupplierDocument, PublisherEntity>(supplierDocument);
                transferedPublisherEntity.Id = (Guid)gameEntity.PublisherId;
                publisherDbService.CreatePublisherDb(transferedPublisherEntity);
            }
        }

        gameDbService.CreateGameDb(gameEntity);
    }

    public void UpdateGame(UpdateGameDto updateGameDto)
    {
        var game = gameMapper.Map<UpdateGameDto, Game>(updateGameDto);

        /*validator.ValidateGameId(game.Id);
        validator.ValidateGenres(game.Genres);
        validator.ValidatePlatforms(game.Platforms);
        validator.ValidatePublisherId(game.PublisherId);*/

        var gameEntity = gameMapper.Map<Game, GameEntity>(game);

        gameEntity.GenreEntities = [];
        gameEntity.PlatformEntities = [];

        foreach (var genreId in game.Genres)
        {
            var stubGenre = new GenreEntity
            {
                Id = genreId,
            };
            gameEntity.GenreEntities.Add(stubGenre);
        }

        foreach (var platformId in game.Platforms)
        {
            var stubPlatform = new PlatformEntity()
            {
                Id = platformId,
            };

            gameEntity.PlatformEntities.Add(stubPlatform);
        }

        CreateGameFromProduct(gameEntity.Id);

        gameDbService.UpdateGameDb(gameEntity);
    }

    public void DeleteGame(string key)
    {
        validator.ValidateGameKey(key);
        var entity = gameDbService.GetGameByKeyDb(key);
        gameDbService.DeleteGameDb(entity);
    }

    public GetGameDto GetGameByKey(string key)
    {
        /*validator.ValidateGameKey(key);*/
        GameEntity gameEntity;
        if (gameDbService.KeyNotExists(key))
        {
            if (productMongoService.KeyNotExists(key))
            {
                throw new Exception($"this {key} gamekey not exists");
            }

            var productDocument = productMongoService.GetProductByGameKey(key);
            var dbId = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
            gameEntity = gameMapper.Map<ProductDocument, GameEntity>(productDocument);
            gameEntity.Id = dbId;
        }
        else
        {
            gameEntity = gameDbService.GetGameByKeyDb(key);
        }

        var game = gameMapper.Map<GameEntity, Game>(gameEntity);
        var gameDto = gameMapper.Map<Game, GetGameDto>(game);

        return gameDto;
    }

    public GetGameDto GetGameById(Guid id)
    {
        /*validator.ValidateGameId(id);*/
        GameEntity gameEntity;
        if (gameDbService.NotExists(id))
        {
            if (databasesSyncDbService.ExistsInIdsSet(id))
            {
                var mongoId = databasesSyncDbService.GetMongoId(id);
                var productDocument = productMongoService.GetProductByIdMongo(mongoId);
                if (productDocument.GameKey.IsNullOrEmpty())
                {
                    var gameKey = GenerateKeyFromName(productDocument.ProductName);
                    productDocument.GameKey = gameKey;
                    productMongoService.UpdateProduct(productDocument);
                }

                gameEntity = gameMapper.Map<ProductDocument, GameEntity>(productDocument);
                gameEntity.Id = id;
            }
            else
            {
                throw new Exception("Id doesn't exists");
            }
        }
        else
        {
            gameEntity = gameDbService.GetGameByIdDb(id);
        }

        var game = gameMapper.Map<GameEntity, Game>(gameEntity);
        var gameDto = gameMapper.Map<Game, GetGameDto>(game);

        return gameDto;
    }

    public ICollection<GenreDto> GetGenresOfGame(string key)
    {
        /*validator.ValidateGameKey(key);*/
        ICollection<GenreEntity> genreEntities = [];
        if (gameDbService.KeyNotExists(key))
        {
            if (productMongoService.KeyNotExists(key))
            {
                throw new Exception($"this {key} gameKey not exists");
            }
            else
            {
                var productDocument = productMongoService.GetProductByGameKey(key);
                var dbId = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
                var categoryDocument = productMongoService.GetCategoryOfProduct(productDocument.CategoryID);
                var categorydbId = databasesSyncDbService.TransferMongoIdToDb(categoryDocument.Id);
                var genreEntity = gameMapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
                genreEntity.Id = categorydbId;
                if (genreEntities.All(p => p.Id != categorydbId))
                {
                    genreEntities.Add(genreEntity);
                }
            }
        }
        else
        {
            genreEntities = gameDbService.GetGenresOfGameDb(key);

            if (productMongoService.KeyNotExists(key))
            {
                throw new Exception($"this {key} gameKey not exists");
            }
            else
            {
                var productDocument = productMongoService.GetProductByGameKey(key);
                var dbId = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
                var categoryDocument = productMongoService.GetCategoryOfProduct(productDocument.CategoryID);
                var categorydbId = databasesSyncDbService.TransferMongoIdToDb(categoryDocument.Id);
                var genreEntity = gameMapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
                genreEntity.Id = categorydbId;
                if (genreEntities.All(p => p.Id != categorydbId))
                {
                    genreEntities.Add(genreEntity);
                }
            }
        }

        var genres = gameMapper.Map<ICollection<GenreEntity>, ICollection<Genre>>(genreEntities);
        var genreDtos = gameMapper.Map<ICollection<Genre>, ICollection<GenreDto>>(genres);

        return genreDtos;
    }

    public ICollection<PlatformDto> GetPlatformsOfGame(string key)
    {
        validator.ValidateGameKey(key);
        var platformEntities = gameDbService.GetPlatformsOfGameDb(key);

        var platform = gameMapper.Map<ICollection<PlatformEntity>, ICollection<Platform>>(platformEntities);
        var platformDtos = gameMapper.Map<ICollection<Platform>, ICollection<PlatformDto>>(platform);

        return platformDtos;
    }

    public GetPublisherDto GetPublisherOfGame(string key)
    {
        /*validator.ValidateGameKey(key);*/
        PublisherEntity publisherEntity;
        if (gameDbService.KeyNotExists(key))
        {
            if (productMongoService.KeyNotExists(key))
            {
                throw new Exception("$this {key} gameKey not exists");
            }
            else
            {
                var productDocument = productMongoService.GetProductByGameKey(key);
                _ = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
                var supplierDocument = productMongoService.GetSupplierOfProduct(productDocument.SupplierID);
                var supplierdbId = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
                publisherEntity = gameMapper.Map<SupplierDocument, PublisherEntity>(supplierDocument);
                publisherEntity.Id = supplierdbId;
            }
        }
        else
        {
            publisherEntity = gameDbService.GetPublisherOfGameDb(key);
        }

        var publisher = gameMapper.Map<PublisherEntity, Publisher>(publisherEntity);
        var publisherDto = gameMapper.Map<Publisher, GetPublisherDto>(publisher);

        return publisherDto;
    }

    public void AddGameInCart(string key)
    {
        /*validator.ValidateGameKey(key);*/
        if (gameDbService.KeyNotExists(key))
        {
            if (productMongoService.KeyNotExists(key))
            {
                throw new Exception("$this {key} gameKey not exists");
            }

            var productDocument = productMongoService.GetProductByGameKey(key);
            var gameId = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
            CreateGameFromProduct(gameId);
        }

        var gameEntity = gameDbService.GetGameByKeyDb(key);
        if (gameEntity.UnitInStock <= 0)
        {
            throw new InvalidOperationException("Unit in stock is less then one");
        }

        gameDbService.AddGameEntityToCartDb(gameEntity);
    }

    public void AddCommentAsQuote(string key, AddCommentDto addCommentDto)
    {
        validator.ValidateGameKey(key);
        if (gameDbService.IsUserBanned(addCommentDto.Comment.Name))
        {
            throw new Exception("User is banned.");
        }

        var parentComment = gameDbService.GetCommentById(addCommentDto.ParentId);
        var gameId = gameDbService.GetGameIdByKey(key);
        var comment = new Comment
        {
            Id = Guid.NewGuid(),
            Name = addCommentDto.Comment.Name,
            Body = $"{parentComment.Body}, {addCommentDto.Comment.Body}",
            GameId = gameId,
            ParentCommentId = addCommentDto.ParentId,
        };

        var commentEntity = gameMapper.Map<Comment, CommentEntity>(comment);

        gameDbService.AddCommentDb(key, commentEntity);
    }

    public void AddCommentAsReply(string key, AddCommentDto addCommentDto)
    {
        validator.ValidateGameKey(key);
        if (gameDbService.IsUserBanned(addCommentDto.Comment.Name))
        {
            throw new Exception("User is banned.");
        }

        var parentComment = gameDbService.GetCommentById(addCommentDto.ParentId);
        var gameId = gameDbService.GetGameIdByKey(key);
        var comment = new Comment
        {
            Id = Guid.NewGuid(),
            Name = addCommentDto.Comment.Name,
            Body = $"{parentComment.Name}, {addCommentDto.Comment.Body}",
            GameId = gameId,
            ParentCommentId = addCommentDto.ParentId,
        };

        var commentEntity = gameMapper.Map<Comment, CommentEntity>(comment);

        gameDbService.AddCommentDb(key, commentEntity);
    }

    public void AddComment(string key, AddCommentDto addCommentDto)
    {
        /*validator.ValidateGameKey(key);*/
        if (gameDbService.IsUserBanned(addCommentDto.Comment.Name))
        {
            throw new Exception("User is banned.");
        }

        if (gameDbService.KeyNotExists(key))
        {
            if (productMongoService.KeyNotExists(key))
            {
                throw new Exception("$this {key} gameKey not exists");
            }

            var productDocument = productMongoService.GetProductByGameKey(key);
            var gameId = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
            CreateGameFromProduct(gameId);
            var comment = gameMapper.Map<AddCommentDto, Comment>(addCommentDto);
            comment.Id = Guid.NewGuid();
            comment.GameId = gameId;

            var commentEntity = gameMapper.Map<Comment, CommentEntity>(comment);
            gameDbService.AddCommentDb(key, commentEntity);
        }
        else
        {
            var gameId = gameDbService.GetGameIdByKey(key);
            var comment = gameMapper.Map<AddCommentDto, Comment>(addCommentDto);
            comment.Id = Guid.NewGuid();
            comment.GameId = gameId;

            var commentEntity = gameMapper.Map<Comment, CommentEntity>(comment);

            gameDbService.AddCommentDb(key, commentEntity);
        }
    }

    public ICollection<GetCommentDto> GetComments(string key)
    {
        /*validator.ValidateGameKey(key);*/
        if (gameDbService.KeyNotExists(key))
        {
            return [];
        }

        var commentEntities = gameDbService.GetCommentsDb(key);

        var commentDtos = commentEntities
            .Where(entity => entity.ParentCommentId == null)
            .Select(entity => MapCommentDto(entity, commentEntities))
            .ToList();

        return commentDtos;
    }

    public void DeleteComment(string key, Guid id)
    {
        gameDbService.DeleteCommentDb(key, id);
    }

    private static GetCommentDto MapCommentDto(CommentEntity entity, ICollection<CommentEntity> allEntities)
    {
        var commentDto = new GetCommentDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Body = entity.Body,
            ChildComments = [],
        };

        var childEntities = allEntities.Where(e => e.ParentCommentId == entity.Id);
        foreach (var childEntity in childEntities)
        {
            var childDto = MapCommentDto(childEntity, allEntities);
            commentDto.ChildComments.Add(childDto);
        }

        return commentDto;
    }

    private static string GenerateKeyFromName(string name)
    {
        var normalizedGameName = MyRegex.Replace(name, string.Empty).ToLower(CultureInfo.CurrentCulture);

        var baseKey = normalizedGameName.Length > 8 ? normalizedGameName[..8] : normalizedGameName;

        var uniqueId = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        var uniqueKey = $"{baseKey}-{uniqueId % 1000}";
        return uniqueKey;
    }

    private void CreateGameFromProduct(Guid id)
    {
        if (databasesSyncDbService.ExistsInIdsSet(id) && gameDbService.NotExists(id))
        {
            var mongoId = databasesSyncDbService.GetMongoId(id);
            var productDocument = productMongoService.GetProductByIdMongo(mongoId);
            var categoryDocument = productMongoService.GetCategoryOfProduct(productDocument.CategoryID);
            var supplierDocument = productMongoService.GetSupplierOfProduct(productDocument.SupplierID);

            var categoryDbId = databasesSyncDbService.TransferMongoIdToDb(categoryDocument.Id);
            var createGenreEntity = gameMapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
            createGenreEntity.Id = categoryDbId;
            if (genreDbService.NotExists(createGenreEntity.Id))
            {
                genreDbService.CreateGenreDb(createGenreEntity);
            }

            var supplierDbId = databasesSyncDbService.TransferMongoIdToDb(supplierDocument.Id);
            var createPublisherEntity = gameMapper.Map<SupplierDocument, PublisherEntity>(supplierDocument);
            createPublisherEntity.Id = supplierDbId;
            if (publisherDbService.PublisherNotExists(createPublisherEntity.Id))
            {
                publisherDbService.CreatePublisherDb(createPublisherEntity);
            }

            var dbId = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
            var createGameEntity = gameMapper.Map<ProductDocument, GameEntity>(productDocument);
            createGameEntity.Id = dbId;
            createGameEntity.GenreEntities = [];
            createGameEntity.PlatformEntities = [];
            createGameEntity.GenreEntities.Add(createGenreEntity);
            createGameEntity.PublisherId = createPublisherEntity.Id;

            gameDbService.CreateGameDb(createGameEntity);
        }
    }
}