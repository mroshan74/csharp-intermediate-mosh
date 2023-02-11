namespace WorkFlowApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine();
            engine.RegisterWork(new UploadToCloud());
            engine.RegisterWork(new EncodeVideo());
            engine.RegisterWork(new SendNotification());
            engine.Run();
        }
    }
}