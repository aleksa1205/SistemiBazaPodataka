using FashionWeek.Mapiranja;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek;

public class DataLayer
{
    private static ISessionFactory _factory = null!;
    private static object _lock = new object();

    private static ISessionFactory CreateSession()
    {
        try
        {
            var config = OracleManagedDataClientConfiguration.Oracle10
                .ConnectionString(str => 
                str.Is("DATA SOURCE=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;PERSIST SECURITY INFO=True;USER ID=S18981;Password=S18981"));
            return Fluently.Configure()
                .Database(config)
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<OsobaMapiranje>())
                .BuildSessionFactory();
        }
        catch(Exception ex)
        {
            System.Windows.Forms.MessageBox.Show(ex.Message);
            return null!;
        }
    }

    public static ISession GetSession()
    {
        if(_factory == null)
        {
            lock( _lock )
            {
                if(_factory == null)
                {
                    _factory = CreateSession();
                }
            }
        }
        return _factory.OpenSession();
    }
}
