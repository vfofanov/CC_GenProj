using System;
using System.Collections.Generic;
using System.Linq;
using BusinessFramework.Client.Common.DomainModel;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.DomainModel;
using NorthWind.Contracts.DataObjects;


namespace NorthWind.Client.ServerServices.DomainModel
{
    /// <inheritdoc cref="CodeBehind.CodeBehindEmployeeTerritoryCollectionManager" />
    public sealed class EmployeeTerritoryCollectionManager : CodeBehind.CodeBehindEmployeeTerritoryCollectionManager, IEmployeeTerritoryCollectionManager
    {
	    /// <inheritdoc />
        public EmployeeTerritoryCollectionManager(IControllerClientFactory clientFactory, IMessageBoxService messageBoxService) 
		    :base(clientFactory, messageBoxService)
        {
        }		 
    }
}