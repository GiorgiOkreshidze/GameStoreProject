using System.Collections;
using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.GenreDtos;
using DTOs.PlatformDtos;

namespace BusinessLogic.Services;

public class GameService : IGameService
{

    private readonly IMapper _gameMapper;
    private readonly IGameDbService _gameDbService;
    private readonly IGenreDbService _genreDbService;
    private readonly IPlatformDbService _platformDbService;

    public GameService(IGameDbService gameDbService, IGenreDbService genreDbService, IPlatformDbService platformDbService, IMapper gameMapper)
    {
        _gameDbService = gameDbService;
        _genreDbService = genreDbService;
        _platformDbService = platformDbService;
        _gameMapper = gameMapper;
    }
    public ICollection<GetGameDto> GetAllGames()
    {
        var gameEntities = _gameDbService.GetAllGamesDb();

        var gameDtos = new List<GetGameDto>();
        
        foreach (var gameEntity in gameEntities)
        {
            var game = _gameMapper.Map<GameEntity, Game>(gameEntity);
            var gameDto = _gameMapper.Map<Game, GetGameDto>(game);
            gameDtos.Add(gameDto);
        }
        
        return gameDtos;
    }
    
    public void CreateGame(CreateGameDto createGameDto)
    {
        Game game = _gameMapper.Map<CreateGameDto, Game>(createGameDto);

        game.Id = Guid.NewGuid();

        if (string.IsNullOrWhiteSpace(game.Key))
        {
            game.Key = GenerateKeyFromName(game.Name);
        }

        GameEntity gameEntity = _gameMapper.Map<Game, GameEntity>(game);
        
        gameEntity.GenreEntities = new List<GenreEntity>();
        gameEntity.PlatformEntities = new List<PlatformEntity>();

        foreach (var genreId in game.Genres)
        {
            var stubGenre = new GenreEntity
            {
                Id = genreId
            };
            gameEntity.GenreEntities.Add(stubGenre);
        }

        foreach (var platformId in game.Platforms)
        {
            var stubPlatform = new PlatformEntity
            {
                Id = platformId
            };
            gameEntity.PlatformEntities.Add(stubPlatform);
        }
        
        /*
        gameEntity.GenreEntities = new List<GenreEntity>();
        gameEntity.PlatformEntities = new List<PlatformEntity>();
        
        foreach (Guid guid in game.Genres)
        {
            gameEntity.GenreEntities.Add(_genreDbService.GetGenreByGuid(guid));
        }
        
        foreach (Guid guid in game.Platforms)
        {
            gameEntity.PlatformEntities.Add(_platformDbService.GetPlatformByGuid(guid));
        }*/

        _gameDbService.CreateGameDb(gameEntity);
    }
    
    private string GenerateKeyFromName(string name)
    {
        var key = name.ToLowerInvariant()
            .Replace(" ", "-")
            .Replace("'", "")
            .Trim();
        return key;
    }

    public void UpdateGame(UpdateGameDto updateGameDto)
    {
        Game game = _gameMapper.Map<UpdateGameDto, Game>(updateGameDto);
        
        GameEntity gameEntity = _gameMapper.Map<Game, GameEntity>(game);
        
        gameEntity.GenreEntities = new List<GenreEntity>();
        gameEntity.PlatformEntities = new List<PlatformEntity>();
        
        foreach (var genreId in game.Genres)
        {
            var stubGenre = new GenreEntity
            {
                Id = genreId
            };
            gameEntity.GenreEntities.Add(stubGenre);
        }

        foreach (var platformId in game.Platforms)
        {
            var stubPlatform = new PlatformEntity
            {
                Id = platformId
            };
            gameEntity.PlatformEntities.Add(stubPlatform);
        }
        
        /*foreach (Guid guid in game.Genres)
        {
            gameEntity.GenreEntities.Add(_genreDbService.GetGenreByGuid(guid));
        }
        
        foreach (Guid guid in game.Platforms)
        {
            gameEntity.PlatformEntities.Add(_platformDbService.GetPlatformByGuid(guid));
        }*/

        _gameDbService.UpdateGameDb(gameEntity);
    }

    public void DeleteGame(string key)
    {
        _gameDbService.DeleteGameDb(key);
    }

    public GetGameDto GetGameByKey(string key)
    {
        var gameEntity = _gameDbService.GetGameByKeyDb(key);
        
        var game = _gameMapper.Map<GameEntity, Game>(gameEntity);
        var gameDto = _gameMapper.Map<Game, GetGameDto>(game);
        
        return gameDto;
    }

    public GetGameDto GetGameById(Guid id)
    {
        var gameEntity = _gameDbService.GetGameByIdDb(id);
        
        var game = _gameMapper.Map<GameEntity, Game>(gameEntity);
        var gameDto = _gameMapper.Map<Game, GetGameDto>(game);
        
        return gameDto;
    }

    public ICollection<GenreDto> GetGenresOfGame(string key)
    {
        var genreEntities =_gameDbService.GetGenresOfGameDb(key);
        
        var genre = _gameMapper.Map<ICollection<GenreEntity>, ICollection<Genre>>(genreEntities);
        var genreDtos = _gameMapper.Map<ICollection<Genre>, ICollection<GenreDto>>(genre);

        return genreDtos;
    }

    public ICollection<PlatformDto> GetPlatformsOfGame(string key)
    {
        var platformEntities = _gameDbService.GetPlatformsOfGameDb(key);

        var platform = _gameMapper.Map<ICollection<PlatformEntity>, ICollection<Platform>>(platformEntities);
        var platformDtos = _gameMapper.Map<ICollection<Platform>, ICollection<PlatformDto>>(platform);
        
        return platformDtos;
    }
}