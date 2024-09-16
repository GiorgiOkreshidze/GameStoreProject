using System.Globalization;
using System.Security.Claims;
using System.Text.RegularExpressions;
using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using BusinessLogic.Validations;
#pragma warning disable IDE0005
using DataAccess.Contracts;
using DataAccess.Entities;
#pragma warning restore IDE0005
using DTOs.GameDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using X.PagedList;
using X.PagedList.Extensions;

namespace BusinessLogic.Services;

public class GameService(IGameDbService gameDbService,
    IMapper gameMapper,
    IHttpContextAccessor accessor,
    GameValidator gameValidator) : IGameService
{
    private static readonly Regex MyRegex = new(@"\s+", RegexOptions.Compiled);

    public GetPagedGameDto GetGames(
        GameFilterDto filter,
        GameSortDto sort,
        GamePaginationDto pagination)
    {
        var gameEntities = gameDbService.GetGamesDb(filter);

        var query = gameEntities.AsEnumerable();

        var claims = accessor.HttpContext.User.Claims;
        var canSeeDeletedGames = CanSeeDeletedGames(claims);
        /*var token = GetToken();
        var canSeeDeletedGames = CanSeeDeletedGames(token);*/

        if (!canSeeDeletedGames)
        {
            query = query.Where(g => !g.Deleted);
        }

        if (query.IsNullOrEmpty())
        {
            return new GetPagedGameDto();
        }

        if (!SortIsDefault(sort) && !query.IsNullOrEmpty())
        {
            query = sort.Sort switch
            {
                "Most popular" => query.OrderByDescending(g => g.Views),
                "Most commented" => query.OrderByDescending(g => g.CommentEntities != null ? g.CommentEntities.Count : 0),
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
            pagedResult = new StaticPagedList<GameEntity>([.. query], 1, !query.Any() ? 1 : query.Count(), query.Count());
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

    public static bool SortIsDefault(GameSortDto sortDto) => string.IsNullOrEmpty(sortDto.Sort);

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

        var gameEntity = gameMapper.Map<Game, GameEntity>(game);

        gameEntity.GenreEntities = [];
        gameEntity.PlatformEntities = [];

        foreach (var genreId in game.Genres)
        {
            GenreEntity transferedGenreEntity = new()
            {
                Id = genreId,
            };

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

        gameEntity.PublisherEntity = new PublisherEntity()
        {
            Id = gameEntity.PublisherId ?? Guid.Empty,
        };

        gameDbService.CreateGameDb(gameEntity);
    }

    public void UpdateGame(UpdateGameDto updateGameDto)
    {
        gameValidator.UpdateGame(updateGameDto.Game.Key);
        var game = gameMapper.Map<UpdateGameDto, Game>(updateGameDto);

        game.PublisherId = updateGameDto.Publisher;

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

        gameEntity.PublisherEntity = new PublisherEntity()
        {
            Id = gameEntity.PublisherId ?? Guid.Empty,
        };

        gameDbService.UpdateGameDb(gameEntity);
    }

    public void DeleteGame(string key)
    {
        gameValidator.DeleteGame(key);
        var entity = gameDbService.GetGameByKeyDb(key);
        gameDbService.DeleteGameDb(entity);
    }

    public GetGameDto GetGameByKey(string key, bool countView = false)
    {
        /*validator.ValidateGameKey(key);*/
        GameEntity gameEntity = gameDbService.GetGameByKeyDb(key);

        if (!countView)
        {
            gameDbService.IncreaseGameViews(gameEntity.Id);
        }

        var game = gameMapper.Map<GameEntity, Game>(gameEntity);
        var gameDto = gameMapper.Map<Game, GetGameDto>(game);

        return gameDto;
    }

    public GetGameDto GetGameById(Guid id, bool countView = false)
    {
        /*validator.ValidateGameId(id);*/
        GameEntity gameEntity = gameDbService.GetGameByIdDb(id);

        if (!countView)
        {
            gameDbService.IncreaseGameViews(id);
        }

        var game = gameMapper.Map<GameEntity, Game>(gameEntity);
        var gameDto = gameMapper.Map<Game, GetGameDto>(game);

        return gameDto;
    }

    public void AddGameInCart(string key)
    {
        var gameEntity = gameDbService.GetGameByKeyDb(key);
        if (gameEntity.UnitInStock <= 0)
        {
            throw new InvalidOperationException("Unit in stock is less then one");
        }

        gameDbService.AddGameEntityToCartDb(gameEntity);
    }

    public ICollection<GetGameDto> GetAllGames()
    {
        var gameEntities = gameDbService.GetGamesWithoutFilterDb();
        var games = gameMapper.Map<ICollection<GameEntity>, ICollection<Game>>(gameEntities);
        var gameDtos = gameMapper.Map<ICollection<Game>, ICollection<GetGameDto>>(games);

        return gameDtos;
    }

    public ICollection<GetGameDto> GetGamesByPlatformId(Guid id)
    {
        var gameEntities = gameDbService.GetGamesByPlatformId(id);

        var game = gameMapper.Map<ICollection<GameEntity>, ICollection<Game>>(gameEntities);

        var claims = accessor.HttpContext.User.Claims;
        var canSeeDeletedGames = CanSeeDeletedGames(claims);
        /*
        var token = GetToken();
        var canSeeDeletedGames = CanSeeDeletedGames(token);*/

        if (!canSeeDeletedGames)
        {
            game = [.. game.AsQueryable().Where(g => !g.Deleted)];
        }

        var gameDtos = gameMapper.Map<ICollection<Game>, ICollection<GetGameDto>>(game);

        return gameDtos;
    }

    public ICollection<GetGameDto> GetGamesByGenreId(Guid id)
    {
        var gameEntities = gameDbService.GetGamesByGenreId(id);

        var game = gameMapper.Map<ICollection<GameEntity>, ICollection<Game>>(gameEntities);

        var claims = accessor.HttpContext.User.Claims;
        var canSeeDeletedGames = CanSeeDeletedGames(claims);
        /*
        var token = GetToken();
        var canSeeDeletedGames = CanSeeDeletedGames(token);*/

        if (!canSeeDeletedGames)
        {
            game = [.. game.AsQueryable().Where(g => !g.Deleted)];
        }

        var gameDtos = gameMapper.Map<ICollection<Game>, ICollection<GetGameDto>>(game);

        return gameDtos;
    }

    public ICollection<GetGameDto> GetGamesOfPublisher(string companyName)
    {
        ICollection<GameEntity> gameEntities = gameDbService.GetGamesOfPublisherDb(companyName);

        var games = gameMapper.Map<ICollection<GameEntity>, ICollection<Game>>(gameEntities);

        var claims = accessor.HttpContext.User.Claims;
        var canSeeDeletedGames = CanSeeDeletedGames(claims);
        /*
        var token = GetToken();
        var canSeeDeletedGames = CanSeeDeletedGames(token);*/

        if (!canSeeDeletedGames)
        {
            games = [.. games.AsQueryable().Where(g => !g.Deleted)];
        }

        var gameDtos = gameMapper.Map<ICollection<Game>, ICollection<GetGameDto>>(games);

        return gameDtos;
    }

    private static string GenerateKeyFromName(string name)
    {
        var normalizedGameName = MyRegex.Replace(name, string.Empty).ToLower(CultureInfo.CurrentCulture);

        var baseKey = normalizedGameName.Length > 8 ? normalizedGameName[..8] : normalizedGameName;

        var uniqueId = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        var uniqueKey = $"{baseKey}-{uniqueId % 1000}";
        return uniqueKey;
    }

    /*private string GetToken()
    {
        var token = accessor.HttpContext.Request.Headers["Authorization"].ToString();
        return token.Replace("bearer ", string.Empty);
    }

    private static bool CanSeeDeletedGames(string token)
    {
        var handler = new JwtSecurityTokenHandler();
        var jwtToken = handler.ReadJwtToken(token);

        var permission = jwtToken.Claims
            .Where(claim => claim.Type == "Permission")
            .Any(claim => claim.Value == "SeeDeletedGames");

        return permission;
    }*/

    private static bool CanSeeDeletedGames(IEnumerable<Claim> claims)
    {
        var permission = claims.Where(claim => claim.Type == "Permission")
            .Any(claim => claim.Value == "CanSeeDeletedGames");

        return permission;
    }
}