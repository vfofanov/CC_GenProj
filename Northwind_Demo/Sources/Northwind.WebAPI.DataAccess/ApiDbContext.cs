using BusinessFramework.WebAPI.Data;
using BusinessFramework.WebAPI.Data.ChangeTracking;
using Northwind.WebAPI.Contracts;
using Northwind.WebAPI.DataAccess.Mapping;

namespace Northwind.WebAPI.DataAccess
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