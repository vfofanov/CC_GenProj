﻿using System;
using System.Collections.Generic;
using System.Linq;
using BusinessFramework.Client.Common.DomainModel;
using BusinessFramework.Client.Common.DomainModel.Dao;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.Services.Contracts.DomainModel;


namespace Northwind.Client.ServerServices.DomainModel.CodeBehind
{
    /// <summary>
    /// Collection manager for <see cref="QSuppliers"/>
    /// </summary>
    public abstract class CodeBehindQSuppliersCollectionManager : ClassicWebApiCollectionManager<QSuppliers, int>
    {
	    
		/// <inheritdoc />
        protected CodeBehindQSuppliersCollectionManager(IControllerClientFactory clientFactory, IMessageBoxService messageBoxService, bool cacheEnabled = false)
		    :base(clientFactory, messageBoxService, cacheEnabled)
        {
        }	
	
	    /// <inheritdoc />
		protected CodeBehindQSuppliersCollectionManager(AbstractDao<QSuppliers, int> daoObject, bool cacheEnabled = false)
            : base(daoObject, cacheEnabled)
        {
        }
    }
}