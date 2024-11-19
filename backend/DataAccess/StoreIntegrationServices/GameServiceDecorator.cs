using AutoMapper;
using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.StoreIntegrationContracts;
using DataAccess.ValueObjects;
using DTOs.GameDtos;
using MongoDbAccess.Contracts;
using MongoDbAccess.Models;
#pragma warning disable IDE0005
using MongoDbAccess.MongoDTOs;
#pragma warning restore IDE0005

namespace DataAccess.StoreIntegrationServices;

public class GameServiceDecorator(IGameDbService gameDbService,
    IDatabasesSyncDbService databasesSyncDbService,
    IProductMongoService productMongoService,
    IPublisherDbService publisherDbService,
    IMapper mapper,
    ICategoryMongoService categoryMongoService,
    ISupplierMongoService supplierMongoService,
    IGenreServiceDecorator genreServiceDecorator,
    IPublisherServiceDecorator publisherServiceDecorator) : IGameDbService, IGameServiceDecorator
{
    public ICollection<GameEntity> GetGamesDb(GameFilterDto filter)
    {
        var gameEntities = gameDbService.GetGamesDb(filter);

        var collection = databasesSyncDbService.GetExcludeMongoIds(DatabaseObjectType.Game);

        var mongoFilter = mapper.Map<GameFilterDto, ProductMongoFilter>(filter);

        if (filter.PublishDateRange != null || filter.Platforms != null)
        {
            return null;
        }

        mongoFilter.ExcludeProducts = collection;
        if (filter.Genres != null)
        {
            mongoFilter.Categories = databasesSyncDbService.GetExcludeMongoIds(DatabaseObjectType.Genre);
        }

        if (filter.Publishers != null)
        {
            mongoFilter.Suppliers = databasesSyncDbService.GetExcludeMongoIds(DatabaseObjectType.Publisher);
        }

        var productDocuments = productMongoService.GetAllMongo(mongoFilter);

        foreach (var productDocument in productDocuments)
        {
            gameEntities.Add(MapGameEntity(productDocument));
        }

        return gameEntities;
    }

    public void CreateGameDb(GameEntity gameEntity)
    {
        foreach (var genre in gameEntity.GenreEntities)
        {
            genreServiceDecorator.TransferCategoryToDatabase(genre.Id);
        }

        if (gameEntity.PublisherId is not null)
        {
            publisherServiceDecorator.TransferPublisherToDatabase((Guid)gameEntity.PublisherId);
        }

        gameDbService.CreateGameDb(gameEntity);
    }

    public void UpdateGameDb(GameEntity gameEntity)
    {
        if (databasesSyncDbService.CanSyncObject(gameEntity.Id))
        {
            CreateGameDb(gameEntity);

            databasesSyncDbService.MarkObjectAsSynced(gameEntity.Id);
        }
        else
        {
            foreach (var genreEntity in gameEntity.GenreEntities)
            {
                genreServiceDecorator.TransferCategoryToDatabase(genreEntity.Id);
            }

            PublisherEntity publisherEntity = gameEntity.PublisherEntity;
            publisherServiceDecorator.TransferPublisherToDatabase(publisherEntity.Id);

            gameDbService.UpdateGameDb(gameEntity);
        }
    }

    public void DeleteGameDb(GameEntity gameEntity)
    {
        if (databasesSyncDbService.CanSyncObject(gameEntity.Id))
        {
            /*databasesSyncDbService.MarkObjectAsSynced(gameEntity.Id);*/
            databasesSyncDbService.MarkAsDeleted(gameEntity.Id);
        }
        else
        {
            gameDbService.DeleteGameDb(gameEntity);
        }
    }

    public GameEntity GetGameByKeyDb(string key)
    {
        var game = gameDbService.GetGameByKeyDb(key);

        if (game == null)
        {
            game = MapGameEntity(productMongoService.GetProductByGameKey(key));
            if (game != null && !databasesSyncDbService.CanSyncObject(game.Id))
            {
                game = null;
            }
        }

        return game;
    }

    public GameEntity GetGameByIdDb(Guid id)
    {
        var game = gameDbService.GetGameByIdDb(id);

        if (game == null)
        {
            string mongoId = databasesSyncDbService.GetMongoId(id);
            game = MapGameEntity(productMongoService.GetProductByIdMongo(mongoId));
        }

        return game;
    }

    public int GetGamesNumber()
    {
        return gameDbService.GetGamesNumber();
    }

    public void AddGameEntityToCartDb(GameEntity gameEntity)
    {
        TransferGameFromMongoToDb(gameEntity);
        gameDbService.AddGameEntityToCartDb(gameEntity);
    }

    public Guid GetGameIdByKey(string key)
    {
        return GetGameByKeyDb(key).Id;
    }

    public bool NotExists(Guid id)
    {
        bool notExists = gameDbService.NotExists(id);

        if (notExists && databasesSyncDbService.CanSyncObject(id))
        {
            var game = GetGameByIdDb(id);
            notExists = game == null;
        }

        return notExists;
    }

    public bool KeyNotExists(string key)
    {
        var mongoDocument = productMongoService.GetProductByGameKey(key);
        Guid id = Guid.Empty;
        if (mongoDocument != null)
        {
            id = databasesSyncDbService.TransferMongoIdToDb(mongoDocument.Id);
        }

        return gameDbService.KeyNotExists(key) && (productMongoService.KeyNotExists(key) || !databasesSyncDbService.CanSyncObject(id));
    }

    public ICollection<GameEntity> GetGamesWithoutFilterDb()
    {
        return GetGamesDb(new GameFilterDto());
    }

    public ICollection<GameEntity> GetGamesByPlatformId(Guid id)
    {
        return gameDbService.GetGamesByPlatformId(id);
    }

    public ICollection<GameEntity> GetGamesByGenreId(Guid id)
    {/*validator.ValidateGenre(id);*/
        ICollection<GameEntity> games = gameDbService.GetGamesByGenreId(id);

        if (databasesSyncDbService.ExistsInIdsSet(id))
        {
            string categoryMongoId = databasesSyncDbService.GetMongoId(id);
            var categoryMongo = categoryMongoService.GetCategoryByIdMongo(categoryMongoId);

            ICollection<string> mongoIds = databasesSyncDbService.GetExcludeMongoIds(DatabaseObjectType.Game);

            var mongoGameDocs = categoryMongoService.GetProductsByCategoryIdFiltered(categoryMongo.CategoryID, mongoIds);

            foreach (var product in mongoGameDocs)
            {
                games.Add(MapGameEntity(product));
            }
        }

        return games;
    }

    public ICollection<GameEntity> GetGamesOfPublisherDb(string companyName)
    {
        var publisher = publisherDbService.GetPublisherByCompanyNameDb(companyName);

        var gameEntities = gameDbService.GetGamesOfPublisherDb(publisher.CompanyName);

        if (!supplierMongoService.CompanyNameNotExists(companyName))
        {
            var supplierDocument = supplierMongoService.GetSupplierByCompanyName(companyName);

            ICollection<string> collection =
                databasesSyncDbService.GetExcludeMongoIds(DatabaseObjectType.Game);

            var productDocuments =
                supplierMongoService.GetProductsBySupplierIdFiltered(supplierDocument.SupplierID, collection);

            foreach (var productDocument in productDocuments)
            {
                gameEntities.Add(MapGameEntity(productDocument));
            }
        }

        return gameEntities;
    }

    public void IncreaseGameViews(Guid gameId)
    {
        if (databasesSyncDbService.CanSyncObject(gameId))
        {
            databasesSyncDbService.IncreaseObjectViews(gameId);
        }
        else
        {
            gameDbService.IncreaseGameViews(gameId);
        }
    }

    public void TransferGameFromMongoToDb(string key)
    {
        var gameEntity = gameDbService.GetGameByKeyDb(key);
        TransferGameFromMongoToDb(gameEntity);
    }

    public void TransferGameFromMongoToDb(GameEntity gameEntity)
    {
        if (databasesSyncDbService.CanSyncObject(gameEntity.Id))
        {
            gameDbService.CreateGameDb(gameEntity);
            databasesSyncDbService.MarkObjectAsSynced(gameEntity.Id);
        }
    }

    private GameEntity MapGameEntity(ProductDocument productDocument, bool mapFields = true)
    {
        GameEntity gameEntity = mapper.Map<ProductDocument, GameEntity>(productDocument);

        var gameId = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);

        gameEntity.Views = databasesSyncDbService.GetObjectViews(gameId);

        if (mapFields)
        {
            var publisher = publisherServiceDecorator.GetPublisherBySupplierId(productDocument.SupplierID) ?? new PublisherEntity();
            var genre = genreServiceDecorator.GetGenreByMongoId(productDocument.CategoryID);
            gameEntity.PublisherId = publisher.Id;
            gameEntity.GenreEntities = genre == null ? [] : [genre];
            gameEntity.PublisherEntity = publisher;
        }

        gameEntity.Id = gameId;
        gameEntity.PlatformEntities = [];

        return gameEntity;
    }
}