using System;
using System.Collections.Generic;
using System.Linq;
using BusinessFramework.Client.Common.DomainModel;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.Services.Contracts.DomainModel;


namespace Northwind.Client.ServerServices.DomainModel
{
    /// <inheritdoc cref="CodeBehind.CodeBehindQProductsCollectionManager" />
    public sealed class QProductsCollectionManager : CodeBehind.CodeBehindQProductsCollectionManager, IQProductsCollectionManager
    {
	    /// <inheritdoc />
        public QProductsCollectionManager(IControllerClientFactory clientFactory, IMessageBoxService messageBoxService) 
		    :base(clientFactory, messageBoxService)
        {
        }		 
    }
}