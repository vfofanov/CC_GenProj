using System;
using System.Collections.Generic;
using System.Linq;
using BusinessFramework.Client.Common.DomainModel;
using BusinessFramework.Client.Common.DomainModel.Dao;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.Services.Contracts.DomainModel;


namespace Northwind.Client.ServerServices.DomainModel.CodeBehind
{
    /// <summary>
    /// Collection manager for <see cref="SysSettingProperty"/>
    /// </summary>
    public abstract class CodeBehindSysSettingPropertyCollectionManager : ClassicWebApiCollectionManager<SysSettingProperty, int>
    {
	    
		/// <inheritdoc />
        protected CodeBehindSysSettingPropertyCollectionManager(IControllerClientFactory clientFactory, IMessageBoxService messageBoxService, bool cacheEnabled = true)
		    :base(clientFactory, messageBoxService, cacheEnabled)
        {
        }	
	
	    /// <inheritdoc />
		protected CodeBehindSysSettingPropertyCollectionManager(AbstractDao<SysSettingProperty, int> daoObject, bool cacheEnabled = true)
            : base(daoObject, cacheEnabled)
        {
        }
    }
}