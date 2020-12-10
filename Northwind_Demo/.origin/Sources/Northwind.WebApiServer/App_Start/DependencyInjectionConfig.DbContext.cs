using BusinessFramework.WebAPI.Contracts.Data;
using BusinessFramework.WebAPI.Data;
using BusinessFramework.WebAPI.Data.ChangeTracking;
using BusinessFramework.WebAPI.Data.EntityFramework;
using FutureTechnologies.DI.Contracts;
using MySql.Data.Entity;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.DataAccess;
using Oracle.ManagedDataAccess.EntityFramework;


namespace NorthWind.WebApiServer
{
    internal static partial class DependencyInjectionConfig
    {
        public static void ConfigureDbContext(IServerContainerRegistrator registrator)
        {
#pragma warning disable 168
            MySqlConnectionFactory mySqlConnectionFactory;
#pragma warning restore 168
#pragma warning disable 168
            OracleConnectionFactory oracleConnectionFactory;
#pragma warning restore 168

            registrator.Singleton<IDatabaseContextFactory, DatabaseContextFactory>();
            
            registrator.PerRequest<IDbContext, IApiDbContext, IEntityManager, IApiEntityManager, ApiDbContext>(new Parameter("nameOrConnectionString", "Default"));
            registrator.PerRequest<IChangeTrackingManager, ChangeTrackingManager>();
        }
    }
}