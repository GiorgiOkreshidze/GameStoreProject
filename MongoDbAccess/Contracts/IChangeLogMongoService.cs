using MongoDbAccess.Models;

namespace MongoDbAccess.Contracts;

public interface IChangeLogMongoService
{
    public void LogChange<T>(string entityName, string action, string user, T oldVersion, T newVersion);

    public List<ChangeLogDocument> GetLogs();
}