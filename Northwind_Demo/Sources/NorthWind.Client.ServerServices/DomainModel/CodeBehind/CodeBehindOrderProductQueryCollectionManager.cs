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
    /// Collection manager for <see cref="OrderProductQuery"/>
    /// </summary>
    public abstract class CodeBehindOrderProductQueryCollectionManager : ObjectWebApiCollectionManager<OrderProductQuery, OrderProductQueryKey>
    {
	    
		/// <inheritdoc />
        protected CodeBehindOrderProductQueryCollectionManager(IControllerClientFactory clientFactory, IMessageBoxService messageBoxService, bool cacheEnabled = false)
		    :base(clientFactory, messageBoxService, cacheEnabled)
        {
        }	
	
	    /// <inheritdoc />
		protected CodeBehindOrderProductQueryCollectionManager(AbstractDao<OrderProductQuery, OrderProductQueryKey> daoObject, bool cacheEnabled = false)
            : base(daoObject, cacheEnabled)
        {
        }
        /// <inheritdoc />
        public override OrderProductQuery GetReadOnlyObjectByKey(OrderProductQueryKey key)
        {
            return GetAllObjects().Where(o => o.Id == key.Id && o.OrderID == key.OrderID && o.ProductID == key.ProductID).FirstOrDefault();
        }
    }
}