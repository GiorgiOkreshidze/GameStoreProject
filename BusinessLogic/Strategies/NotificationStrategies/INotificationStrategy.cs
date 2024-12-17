namespace BusinessLogic.Strategies.NotificationStrategies;

public interface INotificationStrategy
{
    Task NotifyAsync(string recipient, string subject, string message);
}