using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDbAccess.Contracts;
using MongoDbAccess.Models;
using Newtonsoft.Json;

namespace MongoDbAccess.Services;

public class ChangeLogMongoService : IChangeLogMongoService
{
    private readonly IMongoCollection<ChangeLogDocument> _changeLogCollection;

    public ChangeLogMongoService(IOptions<MongoDbSettings> dbSettings)
    {
        var mongoClient = new MongoClient(dbSettings.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(dbSettings.Value.DatabaseName);
        _changeLogCollection = mongoDatabase.GetCollection<ChangeLogDocument>(dbSettings.Value.ChangeLogCollectionName);
    }

    public void LogChange<T>(string entityName, string action, T oldVersion, T newVersion)
    {
        var settings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
        };

        var logEntry = new ChangeLogDocument()
        {
            EntityName = entityName,
            Action = action,
            Timestamp = DateTime.UtcNow,
            OldVersion = JsonConvert.SerializeObject(oldVersion, settings),
            NewVersion = JsonConvert.SerializeObject(newVersion, settings),
        };

        _changeLogCollection.InsertOne(logEntry);
    }

    public List<ChangeLogDocument> GetLogs()
    {
        return _changeLogCollection.Find(log => true).ToList();
    }
}