using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using BusinessFramework.WebAPI.Common.Controllers;
using BusinessFramework.WebAPI.Common.Request;
using BusinessFramework.WebAPI.Common.Security;
using BusinessFramework.WebAPI.Contracts.Data;
using BusinessFramework.WebAPI.Contracts.Files.Storage;
using BusinessFramework.WebAPI.Contracts.Services;
using BusinessFramework.WebAPI.Contracts.Validation;
using NorthWind.Contracts;
using NorthWind.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.Repositories;


namespace NorthWind.WebAPI.Controllers.Api
{
    /// <summary>
    ///     Controls <see cref="EmployeeTerritory" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class EmployeeTerritoryApiController : AbstractApiController<EmployeeTerritory, EmployeeTerritoryKey, IEmployeeTerritoryRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public EmployeeTerritoryApiController(IEmployeeTerritoryRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="EmployeeTerritory"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(EmployeeTerritoryKey key)
        {
		    if(!Security.Authorize(DomainPermissions.EmployeeTerritory_Read)){ return GetInternalForbiddenResult(@"Employee territory.Read(EmployeeTerritory_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="EmployeeTerritory"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.EmployeeTerritory_Read)){ return GetInternalForbiddenResult(@"Employee territory.Read(EmployeeTerritory_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="EmployeeTerritory"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.EmployeeTerritory_Create)){ return GetInternalForbiddenResult(@"Employee territory.Create(EmployeeTerritory_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.EmployeeTerritory.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="EmployeeTerritory"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.EmployeeTerritory_Update)){ return GetInternalForbiddenResult(@"Employee territory.Update(EmployeeTerritory_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.EmployeeTerritory.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="EmployeeTerritory"/> object
        /// </summary>
		public IHttpActionResult Delete(EmployeeTerritoryKey key)
        {
		    if(!Security.Authorize(DomainPermissions.EmployeeTerritory_Delete)){ return GetInternalForbiddenResult(@"Employee territory.Delete(EmployeeTerritory_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.EmployeeTerritory.Delete);
            return InternalDelete(key);
        }
    }
}
