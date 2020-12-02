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
    ///     Controls <see cref="Customer" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class CustomerApiController : AbstractApiController<Customer, int, ICustomerRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public CustomerApiController(ICustomerRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="Customer"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Customer_Read)){ return GetInternalForbiddenResult(@"Customer.Read(Customer_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="Customer"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.Customer_Read)){ return GetInternalForbiddenResult(@"Customer.Read(Customer_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="Customer"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.Customer_Create)){ return GetInternalForbiddenResult(@"Customer.Create(Customer_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Customer.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="Customer"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.Customer_Update)){ return GetInternalForbiddenResult(@"Customer.Update(Customer_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Customer.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="Customer"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Customer_Delete)){ return GetInternalForbiddenResult(@"Customer.Delete(Customer_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Customer.Delete);
            return InternalDelete(key);
        }
    }
}
