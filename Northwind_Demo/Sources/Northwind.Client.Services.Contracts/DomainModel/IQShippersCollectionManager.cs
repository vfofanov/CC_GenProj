using System;
using System.Collections.Generic;
using BusinessFramework.Client.Contracts.DataObjects.Interfaces;
using Northwind.Client.Contracts.BusinessObjects;


namespace Northwind.Client.Services.Contracts.DomainModel
{
	public interface IQShippersCollectionManager : IClassicCollectionManager<QShippers, int>
    {
    }
}