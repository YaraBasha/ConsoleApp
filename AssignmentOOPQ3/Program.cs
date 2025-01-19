using System;



interface INotificationService
{
    void SendNotification(string recipient, string message);
}
class EmailNotificationService : INotificationService
{
    public void SendNotification(string recipient, string message) // Proper method body
    {
        Console.WriteLine($"Email sent to {recipient}: {message}");
    }
}

class SmsNotificationService : INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"SMS sent to {recipient}: {message}");
    }
}
class PushNotificationService : INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"Push notification sent to {recipient}: {message}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        INotificationService emailService = new EmailNotificationService();
        emailService.SendNotification("yara@yahoo.com", "Hello via Email!");

        INotificationService smsService = new SmsNotificationService();
        smsService.SendNotification("+0123456789", "Hello via SMS!");

        INotificationService pushService = new PushNotificationService();
        pushService.SendNotification("Yara's Device", "Hello via Push Notification!");
    }
}

//output:Email sent to yara@yahoo.com: Hello via Email!
//SMS sent to +0123456789: Hello via SMS!
//Push notification sent to Yara's Device: Hello via Push Notification! 

