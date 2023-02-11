namespace Extensibility.Learn;

public class DbMigrator
{
    private readonly ILogger _logger;

    // Dependency Injection
    public DbMigrator(ILogger logger)
    {
        _logger = logger;
    }

    public void Migrate()
    {
        _logger.LogInfo("Migrating started at : " + DateTime.Now);
        _logger.LogInfo("Migrating completed at : " + DateTime.Now);
    }
}