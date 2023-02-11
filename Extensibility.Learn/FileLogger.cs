namespace Extensibility.Learn;

public class FileLogger : ILogger
{
    private readonly string _filepath;

    public FileLogger(string filepath)
    {
        _filepath = filepath;
    }

    public void LogError(string message)
    {
        LogToFile(message, "ERROR");
    }

    public void LogInfo(string message)
    {
        LogToFile(message, "INFO");
    }

    private void LogToFile(string message, string messageType)
    {
        try
        {
            using var streamWriter = new StreamWriter(_filepath, true);
            streamWriter.WriteLine(messageType + ":" + message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception occurred: {ex.Message}");
        }
    }
}