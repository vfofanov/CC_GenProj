﻿using System;
using System.Collections.Generic;
using System.Linq;
using BusinessFramework.Client.Common.DomainModel;
using BusinessFramework.Client.Common.DomainModel.Dao;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.DomainModel;


namespace NorthWind.Client.ServerServices.DomainModel.CodeBehind
{
    /// <summary>
    /// Collection manager for <see cref="Territory"/>
    /// </summary>
    public abstract class CodeBehindTerritoryCollectionManager : ClassicWebApiCollectionManager<Territory, int>
    {
	    
		/// <inheritdoc />
        protected CodeBehindTerritoryCollectionManager(IControllerClientFactory clientFactory, IMessageBoxService messageBoxService, bool cacheEnabled = false)
		    :base(clientFactory, messageBoxService, cacheEnabled)
        {
        }	
	
	    /// <inheritdoc />
		protected CodeBehindTerritoryCollectionManager(AbstractDao<Territory, int> daoObject, bool cacheEnabled = false)
            : base(daoObject, cacheEnabled)
        {
        }
    }
}