using System;
using System.Data.Entity;
using System.Linq;
using BusinessFramework.Contracts;
using BusinessFramework.WebAPI.Common.Data;
using BusinessFramework.WebAPI.Contracts.Data;
using NorthWind.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.Repositories;


namespace NorthWind.WebAPI.DataAccess.Repositories.CodeBehind
{
    /// <summary>
    /// Repository for <see cref="CodeBehindEmployeeTerritoryRepository"/> objects
    /// </summary>
    public abstract class CodeBehindEmployeeTerritoryRepository : EntityRepository<EmployeeTerritory, EmployeeTerritoryKey, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindEmployeeTerritoryRepository(IApiDbContext context) 
		    :base(context)
        {

        }



        /// <inheritdoc />
        public override EmployeeTerritory GetByKey(EmployeeTerritoryKey key)
        {
            return Set().FirstOrDefault(entity => entity.EmployeeID == key.EmployeeID && entity.TerritoryID == key.TerritoryID);
        }
    
    }
}