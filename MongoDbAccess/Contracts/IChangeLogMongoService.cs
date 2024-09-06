using MongoDbAccess.Models;

namespace MongoDbAccess.Contracts;

public interface IChangeLogMongoService
{
    public void LogChange<T>(string entityName, string action, T oldVersion, T newVersion);

    public List<ChangeLogDocument> GetLogs();
}