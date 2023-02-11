namespace Extensibility.Learn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* DbMigrator is the actual class, so we pass the ConsoleLogger instance to the DbMigrator -> which is called dependency
            injection, ConsoleLogger is created based on ILogger interface, and DbMigrator doesn't care about logging as long as it 
            adhere to the ILogger interface
            */
            var dbMigrator1 = new DbMigrator(new ConsoleLogger());
            dbMigrator1.Migrate();
            var dbMigrator2 = new DbMigrator(new FileLogger("C:\\00 FILES\\Test\\log.txt"));
            dbMigrator2.Migrate();
        }
    }
}