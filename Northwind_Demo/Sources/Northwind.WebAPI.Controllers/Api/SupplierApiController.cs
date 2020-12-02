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
    ///     Controls <see cref="Supplier" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class SupplierApiController : AbstractApiController<Supplier, int, ISupplierRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public SupplierApiController(ISupplierRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="Supplier"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Supplier_Read)){ return GetInternalForbiddenResult(@"Supplier.Read(Supplier_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="Supplier"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.Supplier_Read)){ return GetInternalForbiddenResult(@"Supplier.Read(Supplier_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="Supplier"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.Supplier_Create)){ return GetInternalForbiddenResult(@"Supplier.Create(Supplier_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Supplier.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="Supplier"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.Supplier_Update)){ return GetInternalForbiddenResult(@"Supplier.Update(Supplier_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Supplier.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="Supplier"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Supplier_Delete)){ return GetInternalForbiddenResult(@"Supplier.Delete(Supplier_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Supplier.Delete);
            return InternalDelete(key);
        }
    }
}
