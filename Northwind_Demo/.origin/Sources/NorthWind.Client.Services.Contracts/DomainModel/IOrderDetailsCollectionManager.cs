using System;
using System.Collections.Generic;
using BusinessFramework.Client.Contracts.DataObjects.Interfaces;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Contracts.DataObjects;


namespace NorthWind.Client.Services.Contracts.DomainModel
{
	public interface IOrderDetailsCollectionManager : IObjectCollectionManager<OrderDetails, OrderDetailsKey>
    {
    }
}