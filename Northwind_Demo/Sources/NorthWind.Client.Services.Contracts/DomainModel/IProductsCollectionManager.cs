using System;
using System.Collections.Generic;
using BusinessFramework.Client.Contracts.DataObjects.Interfaces;
using NorthWind.Client.Contracts.BusinessObjects;


namespace NorthWind.Client.Services.Contracts.DomainModel
{
	public interface IProductsCollectionManager : IClassicCollectionManager<Products, int>
    {
    }
}