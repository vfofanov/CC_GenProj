using Microsoft.AspNet.OData;
using System;
using System.Linq;
using System.Web.Http;
using BusinessFramework.WebAPI.Common.Controllers;
using BusinessFramework.WebAPI.Common.Request;
using NorthWind.Contracts;
using NorthWind.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.Repositories;


namespace NorthWind.WebAPI.Controllers.OData
{
    /// <summary>
    ///     Controls <see cref="EmployeeTerritory" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class EmployeeTerritoryController : AbstractODataController<EmployeeTerritory, EmployeeTerritoryKey, IEmployeeTerritoryRepository>
    {   
	    /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="requestInitializer"></param>     
        /// <param name="securityService"></param>     
        public EmployeeTerritoryController(IEmployeeTerritoryRepository repository, IRequestStorageInitializer requestInitializer, ISecurityService securityService)
		    : base(repository, requestInitializer, securityService)
		{
		    Security = securityService;
		}

		private ISecurityService Security { get; }

        /// <summary>
        /// Get all <see cref="EmployeeTerritory"/> objects
        /// </summary>
        /// <returns></returns>        
        [HttpGet]
        [EnableQuery(MaxNodeCount = DefaultOdataSettings.MaxNodeCount)]
		public IQueryable<EmployeeTerritory> Get()
        {
		    if(!Security.Authorize(DomainPermissions.EmployeeTerritory_Read)){ ThrowInternalForbiddenException(@"Employee territory.Read(EmployeeTerritory_Read)"); }
            return InternalGet();
        }

		/// <summary>
        /// Get <see cref="EmployeeTerritory"/> object by key
        /// </summary>
        [HttpGet]
        [EnableQuery(MaxNodeCount = DefaultOdataSettings.MaxNodeCount)]
		public IHttpActionResult Get(EmployeeTerritoryKey key)
        {
		    if(!Security.Authorize(DomainPermissions.EmployeeTerritory_Read)){ ThrowInternalForbiddenException(@"Employee territory.Read(EmployeeTerritory_Read)"); }
            var data = Repository.GetByKey(key);
			return data == null ? (IHttpActionResult) NotFound() : Ok(data);            
        }
    }
}