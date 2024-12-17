using DataAccess.Entities;
using DTOs.NotificationDtos;

namespace DataAccess.Contracts;

public interface INotificationsDbService
{
    public Task<List<NotificationMethodEntity>> GetNotificationMethodsDbAsync();
    
    public Task<List<NotificationMethodEntity>> GetUserNotificationMethodsDbAsync(string userName);
    
    public void UpdateUserSelectedNotificationsDb(NotificationPreferenceUpdateDto dto, string userName);

    public Task<List<string>> GetUserNotificationMethodsByIdDbAsync(Guid id);
}