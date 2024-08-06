using System.Globalization;
using System.Text.RegularExpressions;
using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using BusinessLogic.Validations;
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.CommentDtos;
using DTOs.GameDtos;
using DTOs.GenreDtos;
using DTOs.PlatformDtos;
using DTOs.PublisherDtos;
using X.PagedList;

namespace BusinessLogic.Services;

public class GameService(IGameDbService gameDbService, IMapper gameMapper,
    IValidationsHandler validator) : IGameService
{
    private static readonly Regex MyRegex = new(@"\s+", RegexOptions.Compiled);

    public IPagedList<GetPagedGameDto> GetGames(GameFilterDto filter, GameSortDto sort, GamePaginationDto pagination)
    {
        IPagedList<GameEntity> gameEntities = gameDbService.GetGamesDb(filter, sort, pagination);

        var gameDtosWithId = gameEntities.Select(game => new GameDtoWithId
        {
            Id = game.Id,
            Name = game.Name,
            Key = game.Key,
            Description = game.Description,
            Price = game.Price,
            UnitInStock = game.UnitInStock,
            Discount = game.Discount,
        }).ToList();

        var getGameDto = new GetPagedGameDto
        {
            Games = new StaticPagedList<GameDtoWithId>(gameDtosWithId, gameEntities.PageNumber, gameEntities.PageSize, gameEntities.TotalItemCount),
            TotalPages = gameEntities.PageCount,
            CurrentPage = gameEntities.PageNumber,
        };

        StaticPagedList<GetPagedGameDto> result = !PaginationIsDefault(pagination)
            ? new StaticPagedList<GetPagedGameDto>([getGameDto], pagination.PageNumber, pagination.PageSize, gameEntities.TotalItemCount)
            : new StaticPagedList<GetPagedGameDto>([getGameDto], 1, getGameDto.Games.Count, getGameDto.Games.Count);
        return result;
    }

    public static bool PaginationIsDefault(GamePaginationDto paginationDto) => paginationDto.PageNumber <= 0 && paginationDto.PageSize <= 0;

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

        validator.ValidateGenres(game.Genres);
        validator.ValidatePlatforms(game.Platforms);
        validator.ValidatePublisherId(game.PublisherId);

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

        gameDbService.CreateGameDb(gameEntity);
    }

    public void UpdateGame(UpdateGameDto updateGameDto)
    {
        var game = gameMapper.Map<UpdateGameDto, Game>(updateGameDto);

        validator.ValidateGameId(game.Id);
        validator.ValidateGenres(game.Genres);
        validator.ValidatePlatforms(game.Platforms);
        validator.ValidatePublisherId(game.PublisherId);

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
        validator.ValidateGameKey(key);
        var gameEntity = gameDbService.GetGameByKeyDb(key);

        var game = gameMapper.Map<GameEntity, Game>(gameEntity);
        var gameDto = gameMapper.Map<Game, GetGameDto>(game);

        return gameDto;
    }

    public GetGameDto GetGameById(Guid id)
    {
        validator.ValidateGameId(id);
        var gameEntity = gameDbService.GetGameByIdDb(id);

        var game = gameMapper.Map<GameEntity, Game>(gameEntity);
        var gameDto = gameMapper.Map<Game, GetGameDto>(game);

        return gameDto;
    }

    public ICollection<GenreDto> GetGenresOfGame(string key)
    {
        validator.ValidateGameKey(key);
        var genreEntities = gameDbService.GetGenresOfGameDb(key);

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
        validator.ValidateGameKey(key);
        var publisherEntity = gameDbService.GetPublisherOfGameDb(key);

        var publisher = gameMapper.Map<PublisherEntity, Publisher>(publisherEntity);
        var publisherDto = gameMapper.Map<Publisher, GetPublisherDto>(publisher);

        return publisherDto;
    }

    public void AddGameInCart(string key)
    {
        validator.ValidateGameKey(key);
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
        validator.ValidateGameKey(key);
        if (gameDbService.IsUserBanned(addCommentDto.Comment.Name))
        {
            throw new Exception("User is banned.");
        }

        var gameId = gameDbService.GetGameIdByKey(key);
        var comment = gameMapper.Map<AddCommentDto, Comment>(addCommentDto);
        comment.Id = Guid.NewGuid();
        comment.GameId = gameId;

        var commentEntity = gameMapper.Map<Comment, CommentEntity>(comment);

        gameDbService.AddCommentDb(key, commentEntity);
    }

    public ICollection<GetCommentDto> GetComments(string key)
    {
        validator.ValidateGameKey(key);
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
}