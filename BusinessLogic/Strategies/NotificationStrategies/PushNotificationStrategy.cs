namespace BusinessLogic.Strategies.NotificationStrategies;

public class PushNotificationStrategy : INotificationStrategy
{
    public Task NotifyAsync(string recipient, string subject, string message)
    {
        // Fake Push Notification logic
        Console.WriteLine($"Push notification to {recipient}: {message}");
        return Task.CompletedTask;
    }
}