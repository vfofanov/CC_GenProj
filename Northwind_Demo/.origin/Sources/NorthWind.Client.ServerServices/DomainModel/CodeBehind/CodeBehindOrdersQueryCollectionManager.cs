﻿using System;
using System.Collections.Generic;
using System.Linq;
using BusinessFramework.Client.Common.DomainModel;
using BusinessFramework.Client.Common.DomainModel.Dao;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.DomainModel;


namespace NorthWind.Client.ServerServices.DomainModel.CodeBehind
{
    /// <summary>
    /// Collection manager for <see cref="OrdersQuery"/>
    /// </summary>
    public abstract class CodeBehindOrdersQueryCollectionManager : ClassicWebApiCollectionManager<OrdersQuery, int>
    {
	    
		/// <inheritdoc />
        protected CodeBehindOrdersQueryCollectionManager(IControllerClientFactory clientFactory, IMessageBoxService messageBoxService, bool cacheEnabled = false)
		    :base(clientFactory, messageBoxService, cacheEnabled)
        {
        }	
	
	    /// <inheritdoc />
		protected CodeBehindOrdersQueryCollectionManager(AbstractDao<OrdersQuery, int> daoObject, bool cacheEnabled = false)
            : base(daoObject, cacheEnabled)
        {
        }
    }
}