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
    ///     Controls <see cref="Order" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class OrderApiController : AbstractApiController<Order, int, IOrderRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public OrderApiController(IOrderRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="Order"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Order_Read)){ return GetInternalForbiddenResult(@"Order.Read(Order_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="Order"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.Order_Read)){ return GetInternalForbiddenResult(@"Order.Read(Order_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="Order"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.Order_Create)){ return GetInternalForbiddenResult(@"Order.Create(Order_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Order.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="Order"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.Order_Update)){ return GetInternalForbiddenResult(@"Order.Update(Order_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Order.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="Order"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Order_Delete)){ return GetInternalForbiddenResult(@"Order.Delete(Order_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Order.Delete);
            return InternalDelete(key);
        }
    }
}
