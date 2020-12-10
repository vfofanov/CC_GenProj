using System;
using System.Collections.Generic;
using NorthWind.Client.Contracts.BusinessObjects;
using BusinessFramework.Client.Contracts.DataObjects.Interfaces;


namespace NorthWind.Client.Services.Contracts.DomainModel
{
	public interface ISysSettingCollectionManager : IClassicCollectionManager<SysSetting, int>
	{
	    IList<SysSetting> GetUserSettings(int? userId);
	}
}