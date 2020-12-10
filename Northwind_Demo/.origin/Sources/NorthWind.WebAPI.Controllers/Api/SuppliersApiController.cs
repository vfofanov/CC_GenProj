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
    ///     Controls <see cref="Suppliers" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class SuppliersApiController : AbstractApiController<Suppliers, int, ISuppliersRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public SuppliersApiController(ISuppliersRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="Suppliers"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Suppliers_Read)){ return GetInternalForbiddenResult(@"Suppliers.Read(Suppliers_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="Suppliers"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.Suppliers_Read)){ return GetInternalForbiddenResult(@"Suppliers.Read(Suppliers_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="Suppliers"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.Suppliers_Create)){ return GetInternalForbiddenResult(@"Suppliers.Create(Suppliers_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Suppliers.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="Suppliers"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.Suppliers_Update)){ return GetInternalForbiddenResult(@"Suppliers.Update(Suppliers_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Suppliers.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="Suppliers"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Suppliers_Delete)){ return GetInternalForbiddenResult(@"Suppliers.Delete(Suppliers_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Suppliers.Delete);
            return InternalDelete(key);
        }
    }
}
