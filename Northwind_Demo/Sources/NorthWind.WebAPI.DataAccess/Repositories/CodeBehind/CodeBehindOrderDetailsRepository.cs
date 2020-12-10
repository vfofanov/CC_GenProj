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
    /// Repository for <see cref="CodeBehindOrderDetailsRepository"/> objects
    /// </summary>
    public abstract class CodeBehindOrderDetailsRepository : EntityRepository<OrderDetails, OrderDetailsKey, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindOrderDetailsRepository(IApiDbContext context) 
		    :base(context)
        {

        }



        /// <inheritdoc />
        public override OrderDetails GetByKey(OrderDetailsKey key)
        {
            return Set().FirstOrDefault(entity => entity.OrderID == key.OrderID && entity.ProductID == key.ProductID);
        }
    
    }
}