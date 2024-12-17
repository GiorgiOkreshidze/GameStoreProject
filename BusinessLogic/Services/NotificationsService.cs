using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using BusinessLogic.Strategies.NotificationStrategies;
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.NotificationDtos;

namespace BusinessLogic.Services;

public class NotificationsService : INotificationsService
{
    private readonly INotificationsDbService _notificationsDbService;
    private readonly IUserDbService _userDbService;
    private readonly IMapper _mapper;
    private readonly Dictionary<string, INotificationStrategy> _strategies;

    public NotificationsService(
        IEnumerable<INotificationStrategy> strategies,
        IUserDbService userDbService,
        INotificationsDbService notificationsDbService,
        IMapper mapper)
    {
        _notificationsDbService = notificationsDbService;
        _userDbService = userDbService;
        _mapper = mapper;
        _strategies = strategies.ToDictionary(
            strategy => strategy.GetType().Name.Replace("NotificationStrategy", "").ToLower());
    }
    
    public async Task NotifyOrderStatusChangeAsync(Order order, string status)
    {
        var managerAndAdminEmails = await _userDbService.GetManagerAndAdminEmailsAsync();

        var userEmail = await _userDbService.GetUserEmailAsync(order.CustomerId);

        var recipientEmails = managerAndAdminEmails.Append(userEmail);

        var userNotificationPreferences = 
            await _notificationsDbService.GetUserNotificationMethodsByIdDbAsync(order.CustomerId);

        var notificationMethods = userNotificationPreferences.Any()
            ? userNotificationPreferences
            : ["email"];

        foreach (var email in recipientEmails)
        {
            await NotifyAsync(notificationMethods, email, 
                "Order Status Update", 
                $"Order {order.Id} is now {status}.");
        }
    }

    private async Task NotifyAsync(IEnumerable<string> notificationMethods, string recipient, string subject, string message)
    {
        foreach (var method in notificationMethods)
        {
            if (_strategies.TryGetValue(method.ToLower(), out var strategy))
            {
                await strategy.NotifyAsync(recipient, subject, message);
            }
            else
            {
                throw new NotSupportedException($"Notification method {method} is not supported.");
            }
        }
    }
    
    public async Task<List<string>> GetNotificationMethodsAsync()
    {
        var notificationMethodEntities = await _notificationsDbService.GetNotificationMethodsDbAsync();
        var notificationMethods =
            _mapper.Map<ICollection<NotificationMethodEntity>, ICollection<NotificationMethod>>(
                notificationMethodEntities);
        
        return notificationMethods.Select(entity => entity.Type).ToList();
    }

    public async Task<List<string>> GetUserNotificationMethodsAsync(string userName)
    {
        var notificationMethodEntities = await _notificationsDbService.GetUserNotificationMethodsDbAsync(userName);
        var notificationMethods =
            _mapper.Map<ICollection<NotificationMethodEntity>, ICollection<NotificationMethod>>(
                notificationMethodEntities);

        return notificationMethods.Select(entity => entity.Type).ToList();
    }

    public void UpdateUserSelectedNotifications(NotificationPreferenceUpdateDto dto, string userName)
    {
        _notificationsDbService.UpdateUserSelectedNotificationsDb(dto, userName);
    }
}