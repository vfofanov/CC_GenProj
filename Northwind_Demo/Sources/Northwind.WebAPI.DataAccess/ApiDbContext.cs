using BusinessFramework.WebAPI.Data;
using BusinessFramework.WebAPI.Data.ChangeTracking;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.DataAccess.Mapping;

namespace NorthWind.WebAPI.DataAccess
{
    /// <summary>
    /// Api db context
    /// </summary>
    public sealed partial class ApiDbContext : ObjectBaseDbContext, IApiDbContext
    {
        /// <summary>
        ///     Ctor
        /// </summary>
        public ApiDbContext(IDatabaseContextFactory factory, IChangeTrackingManager changeTrackingManager, string nameOrConnectionString)
            : base(factory, changeTrackingManager, ApiDbContextMapping.OnModelCreating, nameOrConnectionString)
        {
        }
    }
}