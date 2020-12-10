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
    ///     Controls <see cref="CustomerDemographic" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class CustomerDemographicApiController : AbstractApiController<CustomerDemographic, int, ICustomerDemographicRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public CustomerDemographicApiController(ICustomerDemographicRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="CustomerDemographic"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.CustomerDemographic_Read)){ return GetInternalForbiddenResult(@"Customer demographic.Read(CustomerDemographic_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="CustomerDemographic"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.CustomerDemographic_Read)){ return GetInternalForbiddenResult(@"Customer demographic.Read(CustomerDemographic_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="CustomerDemographic"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.CustomerDemographic_Create)){ return GetInternalForbiddenResult(@"Customer demographic.Create(CustomerDemographic_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.CustomerDemographic.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="CustomerDemographic"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.CustomerDemographic_Update)){ return GetInternalForbiddenResult(@"Customer demographic.Update(CustomerDemographic_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.CustomerDemographic.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="CustomerDemographic"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.CustomerDemographic_Delete)){ return GetInternalForbiddenResult(@"Customer demographic.Delete(CustomerDemographic_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.CustomerDemographic.Delete);
            return InternalDelete(key);
        }
    }
}
