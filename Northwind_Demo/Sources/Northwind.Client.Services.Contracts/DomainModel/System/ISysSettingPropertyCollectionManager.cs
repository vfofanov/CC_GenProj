using System;
using System.Collections.Generic;
using Northwind.Client.Contracts.BusinessObjects;
using BusinessFramework.Client.Contracts.DataObjects.Interfaces;


namespace Northwind.Client.Services.Contracts.DomainModel
{
	public interface ISysSettingPropertyCollectionManager : IClassicCollectionManager<SysSettingProperty, int>
	{
	    bool TryGetSettingProperty(string settingName, out SysSettingProperty settingProperty);
	}
}