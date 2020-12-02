using System;
using System.Collections.Generic;
using System.Linq;
using BusinessFramework.Client.Common.DomainModel;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.Services.Contracts.DomainModel;
using Northwind.Contracts.DataObjects;


namespace Northwind.Client.ServerServices.DomainModel
{
    /// <inheritdoc cref="CodeBehind.CodeBehindSysOperationLockCollectionManager" />
    public sealed class SysOperationLockCollectionManager : CodeBehind.CodeBehindSysOperationLockCollectionManager, ISysOperationLockCollectionManager
    {
	    /// <inheritdoc />
        public SysOperationLockCollectionManager(IControllerClientFactory clientFactory, IMessageBoxService messageBoxService) 
		    :base(clientFactory, messageBoxService)
        {
        }		 
    }
}