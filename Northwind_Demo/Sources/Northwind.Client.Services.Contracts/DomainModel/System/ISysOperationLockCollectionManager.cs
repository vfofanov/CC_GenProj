using System;
using System.Collections.Generic;
using BusinessFramework.Client.Contracts.DataObjects.Interfaces;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Contracts.DataObjects;


namespace Northwind.Client.Services.Contracts.DomainModel
{
	public interface ISysOperationLockCollectionManager : IObjectCollectionManager<SysOperationLock, SysOperationLockKey>
    {
    }
}