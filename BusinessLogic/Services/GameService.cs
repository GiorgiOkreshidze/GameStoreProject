using System.Text.RegularExpressions;
using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using BusinessLogic.Validations;
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.GenreDtos;
using DTOs.PlatformDtos;
using DTOs.PublisherDtos;

namespace BusinessLogic.Services;

public class GameService(IGameDbService gameDbService, IMapper gameMapper,
    IValidationsHandler validator) : IGameService
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
        
        validator.ValidateGenres(game.Genres);
        validator.ValidatePlatforms(game.Platforms);
        validator.ValidatePublisherId(game.PublisherId);

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
        
        validator.ValidateGameId(game.Id);
        validator.ValidateGenres(game.Genres);
        validator.ValidatePlatforms(game.Platforms);
        validator.ValidatePublisherId(game.PublisherId);
        
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
        var genreEntities =gameDbService.GetGenresOfGameDb(key);
        
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


    private string GenerateKeyFromName(string name)
    {
        var normalizedGameName = Regex.Replace(name, @"\s+", "").ToLower();

        var baseKey = normalizedGameName.Length > 8 ? normalizedGameName.Substring(0, 8) : normalizedGameName;

        var uniqueId = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        var uniqueKey = $"{baseKey}-{uniqueId%1000}";
        return uniqueKey;
    }
    
}