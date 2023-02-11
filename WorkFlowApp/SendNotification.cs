namespace WorkFlowApp;

public class SendNotification : IWork
{
    public void Execute()
    {
        Console.WriteLine("Email sent to uploaded user ...");
    }
}