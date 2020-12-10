using System;
using System.Collections.Generic;
using System.Linq;
using BusinessFramework.Client.Common.DomainModel;
using BusinessFramework.Client.Common.DomainModel.Dao;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.DomainModel;
using NorthWind.Contracts.DataObjects;


namespace NorthWind.Client.ServerServices.DomainModel.CodeBehind
{
    /// <summary>
    /// Collection manager for <see cref="CustomerCustomerDemo"/>
    /// </summary>
    public abstract class CodeBehindCustomerCustomerDemoCollectionManager : ObjectWebApiCollectionManager<CustomerCustomerDemo, CustomerCustomerDemoKey>
    {
	    
		/// <inheritdoc />
        protected CodeBehindCustomerCustomerDemoCollectionManager(IControllerClientFactory clientFactory, IMessageBoxService messageBoxService, bool cacheEnabled = false)
		    :base(clientFactory, messageBoxService, cacheEnabled)
        {
        }	
	
	    /// <inheritdoc />
		protected CodeBehindCustomerCustomerDemoCollectionManager(AbstractDao<CustomerCustomerDemo, CustomerCustomerDemoKey> daoObject, bool cacheEnabled = false)
            : base(daoObject, cacheEnabled)
        {
        }
        /// <inheritdoc />
        public override CustomerCustomerDemo GetReadOnlyObjectByKey(CustomerCustomerDemoKey key)
        {
            return GetAllObjects().Where(o => o.CustomerID == key.CustomerID && o.CustomerTypeID == key.CustomerTypeID).FirstOrDefault();
        }
    }
}