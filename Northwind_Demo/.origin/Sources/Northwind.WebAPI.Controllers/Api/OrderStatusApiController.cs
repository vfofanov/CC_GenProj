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
    ///     Controls <see cref="OrderStatus" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class OrderStatusApiController : AbstractApiController<OrderStatus, short, IOrderStatusRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public OrderStatusApiController(IOrderStatusRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="OrderStatus"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(short key)
        {
		    if(!Security.Authorize(DomainPermissions.OrderStatus_Read)){ return GetInternalForbiddenResult(@"Order status.Read(OrderStatus_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="OrderStatus"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.OrderStatus_Read)){ return GetInternalForbiddenResult(@"Order status.Read(OrderStatus_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="OrderStatus"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.OrderStatus_Create)){ return GetInternalForbiddenResult(@"Order status.Create(OrderStatus_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.OrderStatus.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="OrderStatus"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.OrderStatus_Update)){ return GetInternalForbiddenResult(@"Order status.Update(OrderStatus_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.OrderStatus.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="OrderStatus"/> object
        /// </summary>
		public IHttpActionResult Delete(short key)
        {
		    if(!Security.Authorize(DomainPermissions.OrderStatus_Delete)){ return GetInternalForbiddenResult(@"Order status.Delete(OrderStatus_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.OrderStatus.Delete);
            return InternalDelete(key);
        }
    }
}
