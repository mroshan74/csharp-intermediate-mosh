namespace IPolymorphism.Learn;

public class SmsNotificationChannel : INotificationChannel
{
    public void SendNotification(Message message)
    {
        Console.WriteLine("SMS sent to the user...");
    }
}