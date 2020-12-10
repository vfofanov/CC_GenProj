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
    /// Collection manager for <see cref="OrderDetails"/>
    /// </summary>
    public abstract class CodeBehindOrderDetailsCollectionManager : ObjectWebApiCollectionManager<OrderDetails, OrderDetailsKey>
    {
	    
		/// <inheritdoc />
        protected CodeBehindOrderDetailsCollectionManager(IControllerClientFactory clientFactory, IMessageBoxService messageBoxService, bool cacheEnabled = false)
		    :base(clientFactory, messageBoxService, cacheEnabled)
        {
        }	
	
	    /// <inheritdoc />
		protected CodeBehindOrderDetailsCollectionManager(AbstractDao<OrderDetails, OrderDetailsKey> daoObject, bool cacheEnabled = false)
            : base(daoObject, cacheEnabled)
        {
        }
        /// <inheritdoc />
        public override OrderDetails GetReadOnlyObjectByKey(OrderDetailsKey key)
        {
            return GetAllObjects().Where(o => o.OrderID == key.OrderID && o.ProductID == key.ProductID).FirstOrDefault();
        }
    }
}