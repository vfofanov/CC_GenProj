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
    ///     Controls <see cref="CustomerCustomerDemo" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class CustomerCustomerDemoApiController : AbstractApiController<CustomerCustomerDemo, CustomerCustomerDemoKey, ICustomerCustomerDemoRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public CustomerCustomerDemoApiController(ICustomerCustomerDemoRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="CustomerCustomerDemo"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(CustomerCustomerDemoKey key)
        {
		    if(!Security.Authorize(DomainPermissions.CustomerCustomerDemo_Read)){ return GetInternalForbiddenResult(@"Customer customer demo.Read(CustomerCustomerDemo_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="CustomerCustomerDemo"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.CustomerCustomerDemo_Read)){ return GetInternalForbiddenResult(@"Customer customer demo.Read(CustomerCustomerDemo_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="CustomerCustomerDemo"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.CustomerCustomerDemo_Create)){ return GetInternalForbiddenResult(@"Customer customer demo.Create(CustomerCustomerDemo_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.CustomerCustomerDemo.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="CustomerCustomerDemo"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.CustomerCustomerDemo_Update)){ return GetInternalForbiddenResult(@"Customer customer demo.Update(CustomerCustomerDemo_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.CustomerCustomerDemo.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="CustomerCustomerDemo"/> object
        /// </summary>
		public IHttpActionResult Delete(CustomerCustomerDemoKey key)
        {
		    if(!Security.Authorize(DomainPermissions.CustomerCustomerDemo_Delete)){ return GetInternalForbiddenResult(@"Customer customer demo.Delete(CustomerCustomerDemo_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.CustomerCustomerDemo.Delete);
            return InternalDelete(key);
        }
    }
}
