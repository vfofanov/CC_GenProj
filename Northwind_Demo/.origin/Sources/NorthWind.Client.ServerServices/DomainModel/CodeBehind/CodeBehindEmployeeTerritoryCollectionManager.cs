using System;
using System.Collections.Generic;
using System.Linq;
using BusinessFramework.Client.Common.DomainModel;
using BusinessFramework.Client.Common.DomainModel.Dao;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.DomainModel;
using NorthWind.Contracts.DataObjects;


namespace NorthWind.Client.ServerServices.DomainModel.CodeBehind
{
    /// <summary>
    /// Collection manager for <see cref="EmployeeTerritory"/>
    /// </summary>
    public abstract class CodeBehindEmployeeTerritoryCollectionManager : ObjectWebApiCollectionManager<EmployeeTerritory, EmployeeTerritoryKey>
    {
	    
		/// <inheritdoc />
        protected CodeBehindEmployeeTerritoryCollectionManager(IControllerClientFactory clientFactory, IMessageBoxService messageBoxService, bool cacheEnabled = false)
		    :base(clientFactory, messageBoxService, cacheEnabled)
        {
        }	
	
	    /// <inheritdoc />
		protected CodeBehindEmployeeTerritoryCollectionManager(AbstractDao<EmployeeTerritory, EmployeeTerritoryKey> daoObject, bool cacheEnabled = false)
            : base(daoObject, cacheEnabled)
        {
        }
        /// <inheritdoc />
        public override EmployeeTerritory GetReadOnlyObjectByKey(EmployeeTerritoryKey key)
        {
            return GetAllObjects().Where(o => o.EmployeeID == key.EmployeeID && o.TerritoryID == key.TerritoryID).FirstOrDefault();
        }
    }
}