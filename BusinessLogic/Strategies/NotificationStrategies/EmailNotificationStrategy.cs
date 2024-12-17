using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace BusinessLogic.Strategies.NotificationStrategies;

public class EmailNotificationStrategy(IConfiguration configuration) : INotificationStrategy
{
    
    public async Task NotifyAsync(string recipient, string subject, string message)
    {
        var apiKey = configuration["SendGrid:ApiKey"];
        var client = new SendGridClient(apiKey);
        var from = new EmailAddress("noreply@gamestore.com", "Game Store");
        var to = new EmailAddress(recipient);
        var emailMessage = MailHelper.CreateSingleEmail(from, to, subject, message, message);
        await client.SendEmailAsync(emailMessage);
    }
}