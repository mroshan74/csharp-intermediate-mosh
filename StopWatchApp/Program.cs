using StopWatchApp;

var stopwatch = new StopWatch();
string? userInput;

do
{
    Console.WriteLine("Enter \n1: To start stopwatch\n2: To stop stopwatch\nx: to exit runner ");
    userInput = Console.ReadLine() ?? string.Empty;

    try
    {
        if (!userInput.Equals("x", StringComparison.OrdinalIgnoreCase))
        {
            switch (userInput)
            {
                case "1":
                    stopwatch.Start();
                    break;
                case "2":
                    stopwatch.Stop();
                    Console.WriteLine("Total run duration is {0}",stopwatch.Duration());
                    break;
                default:
                    Console.WriteLine("The given choice is Invalid");
                    break;
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: {0}", ex.Message);
    }
    
} while (!userInput.Equals("x", StringComparison.OrdinalIgnoreCase));

Console.WriteLine("Exiting stopwatch !!");
