using MongoDbAccess.Models;

namespace MongoDbAccess.Contracts;

public interface IChangeLogMongoService
{
    public void LogChange(string entityName, string action, string user, string details);

    public List<ChangeLogDocument> GetLogs();
}