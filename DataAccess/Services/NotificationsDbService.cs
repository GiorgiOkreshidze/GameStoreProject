using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using DTOs.NotificationDtos;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;

public class NotificationsDbService(GameDbContext context) : INotificationsDbService
{
    public async Task<List<NotificationMethodEntity>> GetNotificationMethodsDbAsync()
    {
        return await context.NotificationMethodEntities.AsNoTracking().ToListAsync();
    }

    public async Task<List<NotificationMethodEntity>> GetUserNotificationMethodsDbAsync(string userName)
    {
        var user = await context.UserEntities
            .AsNoTracking()
            .Include(u => u.NotificationPreferences)
            .FirstOrDefaultAsync(u => u.Name == userName);
        return user.NotificationPreferences.ToList();
    }

    public void UpdateUserSelectedNotificationsDb(NotificationPreferenceUpdateDto dto, string userName)
    {
        var user = context.UserEntities
            .Include(user => user.NotificationPreferences)
            .FirstOrDefault(user => user.Name == userName);
        
        if (user == null)
        {
            throw new KeyNotFoundException($"User with name '{userName}' not found.");
        }

        var allNotificationMethods = context.NotificationMethodEntities.ToList();

        var selectedNotificationMethods = allNotificationMethods
            .Where(method => dto.Notifications.Contains(method.Type, StringComparer.OrdinalIgnoreCase))
            .ToList();

        if (selectedNotificationMethods.Count != dto.Notifications.Count)
        {
            throw new ArgumentException("Some notification types in the request are invalid.");
        }

        user.NotificationPreferences.Clear();
        foreach (var notificationMethod in selectedNotificationMethods)
        {
            user.NotificationPreferences.Add(notificationMethod);
        }

        context.SaveChanges();
    }

    public async Task<List<string>> GetUserNotificationMethodsByIdDbAsync(Guid id)
    {
        return await context.UserEntities
            .AsNoTracking()
            .Where(u => u.Id == id)
            .SelectMany(u => u.NotificationPreferences.Select(n => n.Type))
            .ToListAsync();
    }
}