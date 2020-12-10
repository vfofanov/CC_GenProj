using System;
using System.Collections.Generic;
using System.Linq;
using BusinessFramework.Client.Common.DomainModel;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.DomainModel;


namespace NorthWind.Client.ServerServices.DomainModel
{
    /// <inheritdoc cref="CodeBehind.CodeBehindCustomerQueryCollectionManager" />
    public sealed class CustomerQueryCollectionManager : CodeBehind.CodeBehindCustomerQueryCollectionManager, ICustomerQueryCollectionManager
    {
	    /// <inheritdoc />
        public CustomerQueryCollectionManager(IControllerClientFactory clientFactory, IMessageBoxService messageBoxService) 
		    :base(clientFactory, messageBoxService)
        {
        }		 
    }
}