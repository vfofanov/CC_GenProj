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
    ///     Controls <see cref="Shippers" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class ShippersApiController : AbstractApiController<Shippers, int, IShippersRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public ShippersApiController(IShippersRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="Shippers"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Shippers_Read)){ return GetInternalForbiddenResult(@"Shippers.Read(Shippers_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="Shippers"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.Shippers_Read)){ return GetInternalForbiddenResult(@"Shippers.Read(Shippers_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="Shippers"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.Shippers_Create)){ return GetInternalForbiddenResult(@"Shippers.Create(Shippers_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Shippers.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="Shippers"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.Shippers_Update)){ return GetInternalForbiddenResult(@"Shippers.Update(Shippers_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Shippers.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="Shippers"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Shippers_Delete)){ return GetInternalForbiddenResult(@"Shippers.Delete(Shippers_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Shippers.Delete);
            return InternalDelete(key);
        }
    }
}
