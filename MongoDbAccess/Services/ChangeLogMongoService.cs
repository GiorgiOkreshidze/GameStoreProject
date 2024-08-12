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

    public void LogChange<T>(string entityName, string action, string user, T oldVersion, T newVersion)
    {
        var logEntry = new ChangeLogDocument()
        {
            EntityName = entityName,
            Action = action,
            User = user,
            Timestamp = DateTime.UtcNow,
            OldVersion = (oldVersion != null ? JsonConvert.SerializeObject(oldVersion) : null) ?? throw new InvalidOperationException(),
            NewVersion = (newVersion != null ? JsonConvert.SerializeObject(newVersion) : null) ?? throw new InvalidOperationException(),
        };

        _changeLogCollection.InsertOne(logEntry);
    }

    public List<ChangeLogDocument> GetLogs()
    {
        return _changeLogCollection.Find(log => true).ToList();
    }
}