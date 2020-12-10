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
    ///     Controls <see cref="Region" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class RegionApiController : AbstractApiController<Region, int, IRegionRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public RegionApiController(IRegionRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="Region"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Region_Read)){ return GetInternalForbiddenResult(@"Region.Read(Region_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="Region"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.Region_Read)){ return GetInternalForbiddenResult(@"Region.Read(Region_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="Region"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.Region_Create)){ return GetInternalForbiddenResult(@"Region.Create(Region_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Region.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="Region"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.Region_Update)){ return GetInternalForbiddenResult(@"Region.Update(Region_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Region.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="Region"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Region_Delete)){ return GetInternalForbiddenResult(@"Region.Delete(Region_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Region.Delete);
            return InternalDelete(key);
        }
    }
}
