namespace FashionWeek_Library;

public static class DataLayer
{
    private static ISessionFactory? _factory = null;
    private static readonly object _lock = new object();

    private static ISessionFactory? CreateSession()
    {
        try
        {
            var config = OracleManagedDataClientConfiguration.Oracle10
                .ConnectionString(str =>
                str.Is("DATA SOURCE=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;PERSIST SECURITY INFO=True;USER ID=S18981;Password=S18981"));
            return Fluently.Configure()
                .Database(config)
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .BuildSessionFactory();
        }
        catch (Exception ex)
        {
            //logerror
            return null;
        }
    }

    public static ISession? GetSession()
    {
        if (_factory == null)
        {
            lock (_lock)
            {
                _factory ??= CreateSession();
            }
        }
        return _factory?.OpenSession();
    }
}
