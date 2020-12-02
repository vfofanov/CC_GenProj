using System;
using System.Collections.Generic;
using Northwind.Client.Contracts.BusinessObjects;
using BusinessFramework.Client.Contracts.DataObjects.Interfaces;


namespace Northwind.Client.Services.Contracts.DomainModel
{
	public interface ISysSettingCollectionManager : IClassicCollectionManager<SysSetting, int>
	{
	    IList<SysSetting> GetUserSettings(int? userId);
	}
}