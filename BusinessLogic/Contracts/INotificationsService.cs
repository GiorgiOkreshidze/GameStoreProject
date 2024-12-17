using BusinessLogic.Models;
using DTOs.NotificationDtos;

namespace BusinessLogic.Contracts;

public interface INotificationsService
{
    public Task<List<string>> GetNotificationMethodsAsync();

    public Task<List<string>> GetUserNotificationMethodsAsync(string userName);

    public void UpdateUserSelectedNotifications(NotificationPreferenceUpdateDto dto, string userName);

    public Task NotifyOrderStatusChangeAsync(Order order, string status);
}