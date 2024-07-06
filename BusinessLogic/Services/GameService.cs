using System.Collections;
using System.Text.RegularExpressions;
using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Exceptions;
using BusinessLogic.Models;
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.GenreDtos;
using DTOs.PlatformDtos;

namespace BusinessLogic.Services;

public class GameService(IGameDbService gameDbService, IMapper gameMapper, IGenreDbService genreDbService, IPlatformDbService platformDbService) : IGameService
{
    public ICollection<GetGameDto> GetAllGames()
    {
        var gameEntities = gameDbService.GetAllGamesDb();

        var gameDtos = new List<GetGameDto>();
        
        foreach (var gameEntity in gameEntities)
        {
            var game = gameMapper.Map<GameEntity, Game>(gameEntity);
            var gameDto = gameMapper.Map<Game, GetGameDto>(game);
            gameDtos.Add(gameDto);
        }
        
        return gameDtos;
    }
    
    public void CreateGame(CreateGameDto createGameDto)
    {
        Game game = gameMapper.Map<CreateGameDto, Game>(createGameDto);

        game.Id = Guid.NewGuid();

        if (string.IsNullOrWhiteSpace(game.Key))
        {
            game.Key = GenerateKeyFromName(game.Name);
        }
        
        ValidateGenres(game);
        ValidatePlatforms(game);

        GameEntity gameEntity = gameMapper.Map<Game, GameEntity>(game);
        
        
        
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

            var stubPlatform = new PlatformEntity()
            {
                Id = platformId
            };
            
            gameEntity.PlatformEntities.Add(stubPlatform);
        }

        gameDbService.CreateGameDb(gameEntity);
    }

    public void UpdateGame(UpdateGameDto updateGameDto)
    {
        Game game = gameMapper.Map<UpdateGameDto, Game>(updateGameDto);
        
        ValidateGameId(game.Id);
        ValidateGenres(game);
        ValidatePlatforms(game);
        
        GameEntity gameEntity = gameMapper.Map<Game, GameEntity>(game);

        
        
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

            var stubPlatform = new PlatformEntity()
            {
                Id = platformId
            };
            
            gameEntity.PlatformEntities.Add(stubPlatform);
        }
        
        gameDbService.ClearGenresByGameId(gameEntity.Id);
        gameDbService.ClearPlatformsByGameId(gameEntity.Id);
        gameDbService.UpdateGameDb(gameEntity);
    }

    public void DeleteGame(string key)
    {
        ValidateGameKey(key);
        var entity = gameDbService.GetGameByKeyDb(key);
        gameDbService.DeleteGameDb(entity);
    }

    public GetGameDto GetGameByKey(string key)
    {
        ValidateGameKey(key);
        var gameEntity = gameDbService.GetGameByKeyDb(key);
        
        var game = gameMapper.Map<GameEntity, Game>(gameEntity);
        var gameDto = gameMapper.Map<Game, GetGameDto>(game);
        
        return gameDto;
    }

    public GetGameDto GetGameById(Guid id)
    {
        ValidateGameId(id);
        var gameEntity = gameDbService.GetGameByIdDb(id);
        
        var game = gameMapper.Map<GameEntity, Game>(gameEntity);
        var gameDto = gameMapper.Map<Game, GetGameDto>(game);
        
        return gameDto;
    }

    public ICollection<GenreDto> GetGenresOfGame(string key)
    {
        ValidateGameKey(key);
        var genreEntities =gameDbService.GetGenresOfGameDb(key);
        
        var genres = gameMapper.Map<ICollection<GenreEntity>, ICollection<Genre>>(genreEntities);
        var genreDtos = gameMapper.Map<ICollection<Genre>, ICollection<GenreDto>>(genres);

        return genreDtos;
    }

    public ICollection<PlatformDto> GetPlatformsOfGame(string key)
    {
        ValidateGameKey(key);
        var platformEntities = gameDbService.GetPlatformsOfGameDb(key);

        var platform = gameMapper.Map<ICollection<PlatformEntity>, ICollection<Platform>>(platformEntities);
        var platformDtos = gameMapper.Map<ICollection<Platform>, ICollection<PlatformDto>>(platform);
        
        return platformDtos;
    }
    
    
    
    
    private string GenerateKeyFromName(string name)
    {
        var normalizedGameName = Regex.Replace(name, @"\s+", "").ToLower();

        var baseKey = normalizedGameName.Length > 8 ? normalizedGameName.Substring(0, 8) : normalizedGameName;

        var uniqueId = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        var uniqueKey = $"{baseKey}-{uniqueId%1000}";
        return uniqueKey;
    }
    
    
    
    
    private void ValidateGenres(Game game)
    {
        foreach (var genreId in game.Genres)
        {
            if (genreDbService.NotExists(genreId))
            {
                throw new GenreNotExistsException("Genre with genreId not exists");
            }
        }
    }

    private void ValidatePlatforms(Game game)
    {
        foreach (var platformId in game.Platforms)
        {
            if (platformDbService.NotExists(platformId))
            {
                throw new PlatformNotExistsException("Platform with platformId not exists");
            }
        }
    }
    
    private void ValidateGameId(Guid id)
    {
        if (gameDbService.NotExists(id))
        {
            throw new GameNotExistsException("Game not exists");
        }
    }

    private void ValidateGameKey(string key)
    {
        if (gameDbService.KeyNotExists(key))
        {
            throw new KeyNotFoundException();
        }
    }
}