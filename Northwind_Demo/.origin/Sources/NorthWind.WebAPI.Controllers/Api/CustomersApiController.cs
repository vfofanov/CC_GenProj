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
    ///     Controls <see cref="Customers" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class CustomersApiController : AbstractApiController<Customers, int, ICustomersRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public CustomersApiController(ICustomersRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="Customers"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Customers_Read)){ return GetInternalForbiddenResult(@"Customers.Read(Customers_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="Customers"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.Customers_Read)){ return GetInternalForbiddenResult(@"Customers.Read(Customers_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="Customers"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.Customers_Create)){ return GetInternalForbiddenResult(@"Customers.Create(Customers_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Customers.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="Customers"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.Customers_Update)){ return GetInternalForbiddenResult(@"Customers.Update(Customers_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Customers.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="Customers"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Customers_Delete)){ return GetInternalForbiddenResult(@"Customers.Delete(Customers_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Customers.Delete);
            return InternalDelete(key);
        }
    }
}
