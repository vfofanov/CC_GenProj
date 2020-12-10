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
    ///     Controls <see cref="OrderDetails" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class OrderDetailsApiController : AbstractApiController<OrderDetails, OrderDetailsKey, IOrderDetailsRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public OrderDetailsApiController(IOrderDetailsRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="OrderDetails"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(OrderDetailsKey key)
        {
		    if(!Security.Authorize(DomainPermissions.OrderDetails_Read)){ return GetInternalForbiddenResult(@"OrderDetails.Read(OrderDetails_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="OrderDetails"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.OrderDetails_Read)){ return GetInternalForbiddenResult(@"OrderDetails.Read(OrderDetails_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="OrderDetails"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.OrderDetails_Create)){ return GetInternalForbiddenResult(@"OrderDetails.Create(OrderDetails_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.OrderDetails.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="OrderDetails"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.OrderDetails_Update)){ return GetInternalForbiddenResult(@"OrderDetails.Update(OrderDetails_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.OrderDetails.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="OrderDetails"/> object
        /// </summary>
		public IHttpActionResult Delete(OrderDetailsKey key)
        {
		    if(!Security.Authorize(DomainPermissions.OrderDetails_Delete)){ return GetInternalForbiddenResult(@"OrderDetails.Delete(OrderDetails_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.OrderDetails.Delete);
            return InternalDelete(key);
        }
    }
}
