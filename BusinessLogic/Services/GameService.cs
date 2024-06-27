using System.Collections;
using System.Text.RegularExpressions;
using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.GenreDtos;
using DTOs.PlatformDtos;

namespace BusinessLogic.Services;

public class GameService(IGameDbService gameDbService, IMapper gameMapper) : IGameService
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
            var stubPlatform = new PlatformEntity
            {
                Id = platformId
            };
            gameEntity.PlatformEntities.Add(stubPlatform);
        }

        gameDbService.CreateGameDb(gameEntity);
    }
    
    private string GenerateKeyFromName(string name)
    {
        var normalizedGameName = Regex.Replace(name, @"\s+", "").ToLower();

        var baseKey = normalizedGameName.Length > 8 ? normalizedGameName.Substring(0, 8) : normalizedGameName;

        var uniqueId = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        var uniqueKey = $"{baseKey}-{uniqueId%1000}";
        return uniqueKey;
    }

    public void UpdateGame(UpdateGameDto updateGameDto)
    {
        Game game = gameMapper.Map<UpdateGameDto, Game>(updateGameDto);
        
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
            var stubPlatform = new PlatformEntity
            {
                Id = platformId
            };
            gameEntity.PlatformEntities.Add(stubPlatform);
        }

        gameDbService.UpdateGameDb(gameEntity);
    }

    public void DeleteGame(string key)
    {
        gameDbService.DeleteGameDb(key);
    }

    public GetGameDto GetGameByKey(string key)
    {
        var gameEntity = gameDbService.GetGameByKeyDb(key);
        
        var game = gameMapper.Map<GameEntity, Game>(gameEntity);
        var gameDto = gameMapper.Map<Game, GetGameDto>(game);
        
        return gameDto;
    }

    public GetGameDto GetGameById(Guid id)
    {
        var gameEntity = gameDbService.GetGameByIdDb(id);
        
        var game = gameMapper.Map<GameEntity, Game>(gameEntity);
        var gameDto = gameMapper.Map<Game, GetGameDto>(game);
        
        return gameDto;
    }

    public ICollection<GenreDto> GetGenresOfGame(string key)
    {
        var genreEntities =gameDbService.GetGenresOfGameDb(key);
        
        var genre = gameMapper.Map<ICollection<GenreEntity>, ICollection<Genre>>(genreEntities);
        var genreDtos = gameMapper.Map<ICollection<Genre>, ICollection<GenreDto>>(genre);

        return genreDtos;
    }

    public ICollection<PlatformDto> GetPlatformsOfGame(string key)
    {
        var platformEntities = gameDbService.GetPlatformsOfGameDb(key);

        var platform = gameMapper.Map<ICollection<PlatformEntity>, ICollection<Platform>>(platformEntities);
        var platformDtos = gameMapper.Map<ICollection<Platform>, ICollection<PlatformDto>>(platform);
        
        return platformDtos;
    }
}