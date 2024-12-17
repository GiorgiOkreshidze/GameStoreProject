namespace BusinessLogic.Strategies.NotificationStrategies;

public class SmsNotificationStrategy : INotificationStrategy
{
    public Task NotifyAsync(string recipient, string subject, string message)
    {
        // Fake SMS logic
        Console.WriteLine($"SMS to {recipient}: {message}");
        return Task.CompletedTask;
    }
}