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
    /// Repository for <see cref="CodeBehindCustomerCustomerDemoRepository"/> objects
    /// </summary>
    public abstract class CodeBehindCustomerCustomerDemoRepository : EntityRepository<CustomerCustomerDemo, CustomerCustomerDemoKey, IApiDbContext>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindCustomerCustomerDemoRepository(IApiDbContext context) 
		    :base(context)
        {

        }



        /// <inheritdoc />
        public override CustomerCustomerDemo GetByKey(CustomerCustomerDemoKey key)
        {
            return Set().FirstOrDefault(entity => entity.CustomerID == key.CustomerID && entity.CustomerTypeID == key.CustomerTypeID);
        }
    
    }
}