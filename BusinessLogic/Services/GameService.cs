using AutoMapper;
using BusinessLogic.Models;
using DataAccess.Entities;
using DataAccess.Interface;
using Gamestore.Dtos;

namespace BusinessLogic.Services;

public class GameService : IGameService
{

    private readonly Mapper _gameMapper;
    private readonly IGameDbService _gameDbService;
    private readonly IGenreDbService _genreDbService;
    private readonly IPlatformDbService _platformDbService;

    public GameService(IGameDbService gameDbService, IGenreDbService genreDbService, IPlatformDbService platformDbService)
    {
        _gameDbService = gameDbService;
        _genreDbService = genreDbService;
        _platformDbService = platformDbService;
        var _configGame = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<GameEntity, Game>().ReverseMap();
            cfg.CreateMap<Game, GetGameDto>().ReverseMap();
            cfg.CreateMap<Game, CreateGameDto>().ReverseMap();
        });
        _gameMapper = new Mapper(_configGame);

    }

    public void createGame(CreateGameDto createGameDto)
    {
        Game game = _gameMapper.Map<CreateGameDto, Game>(createGameDto);

        game.Id = Guid.NewGuid();

        GameEntity gameEntity = _gameMapper.Map<Game, GameEntity>(game);

        gameEntity.GenreEntities = new List<GenreEntity>();
        gameEntity.PlatformEntities = new List<PlatformEntity>();
        
        foreach (Guid guid in game.Genres)
        {
            gameEntity.GenreEntities.Add(_genreDbService.getGenreByGiud(guid));
        }
        
        foreach (Guid guid in game.Platforms)
        {
            gameEntity.PlatformEntities.Add(_platformDbService.getPlatformByGuid(guid));
        }

        _gameDbService.createGameDb(gameEntity);
    }

    public GetGameDto getGameByKey(string key)
    {
        var gameEntity = _gameDbService.getGameByKeyDb(key);
        
        var game = _gameMapper.Map<GameEntity, Game>(gameEntity);

        var gameDto = _gameMapper.Map<Game, GetGameDto>(game);
        
        return gameDto;
    }

    public GetGameDto getGame()
    {
        var gameEntity = _gameDbService.getGameDb();

        var game = _gameMapper.Map<GameEntity, Game>(gameEntity);

        var gameDto = _gameMapper.Map<Game, GetGameDto>(game);

        return gameDto;
    }

    
}