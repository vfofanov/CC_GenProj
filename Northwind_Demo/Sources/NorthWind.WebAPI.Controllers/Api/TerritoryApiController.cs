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
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.Repositories;


namespace NorthWind.WebAPI.Controllers.Api
{
    /// <summary>
    ///     Controls <see cref="Territory" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class TerritoryApiController : AbstractApiController<Territory, int, ITerritoryRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public TerritoryApiController(ITerritoryRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="Territory"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Territory_Read)){ return GetInternalForbiddenResult(@"Territory.Read(Territory_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="Territory"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.Territory_Read)){ return GetInternalForbiddenResult(@"Territory.Read(Territory_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="Territory"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.Territory_Create)){ return GetInternalForbiddenResult(@"Territory.Create(Territory_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Territory.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="Territory"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.Territory_Update)){ return GetInternalForbiddenResult(@"Territory.Update(Territory_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Territory.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="Territory"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Territory_Delete)){ return GetInternalForbiddenResult(@"Territory.Delete(Territory_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Territory.Delete);
            return InternalDelete(key);
        }
    }
}
