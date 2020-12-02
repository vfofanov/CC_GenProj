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
using Northwind.Contracts;
using Northwind.WebAPI.Contracts;
using Northwind.WebAPI.Contracts.DataObjects;
using Northwind.WebAPI.Contracts.Repositories;


namespace Northwind.WebAPI.Controllers.Api
{
    /// <summary>
    ///     Controls <see cref="Shipper" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class ShipperApiController : AbstractApiController<Shipper, int, IShipperRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public ShipperApiController(IShipperRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="Shipper"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Shipper_Read)){ return GetInternalForbiddenResult(@"Shipper.Read(Shipper_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="Shipper"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.Shipper_Read)){ return GetInternalForbiddenResult(@"Shipper.Read(Shipper_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="Shipper"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.Shipper_Create)){ return GetInternalForbiddenResult(@"Shipper.Create(Shipper_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Shipper.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="Shipper"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.Shipper_Update)){ return GetInternalForbiddenResult(@"Shipper.Update(Shipper_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Shipper.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="Shipper"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Shipper_Delete)){ return GetInternalForbiddenResult(@"Shipper.Delete(Shipper_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Shipper.Delete);
            return InternalDelete(key);
        }
    }
}
