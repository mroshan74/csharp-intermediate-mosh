namespace IPolymorphism.Learn;

public class MailNotificationChannel : INotificationChannel
{
    public void SendNotification(Message message)
    {
        Console.WriteLine("Email sent to the user...");
    }
}