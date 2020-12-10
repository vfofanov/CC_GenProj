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
    ///     Controls <see cref="Orders" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class OrdersApiController : AbstractApiController<Orders, int, IOrdersRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public OrdersApiController(IOrdersRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="Orders"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Orders_Read)){ return GetInternalForbiddenResult(@"Orders.Read(Orders_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="Orders"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.Orders_Read)){ return GetInternalForbiddenResult(@"Orders.Read(Orders_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="Orders"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.Orders_Create)){ return GetInternalForbiddenResult(@"Orders.Create(Orders_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Orders.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="Orders"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.Orders_Update)){ return GetInternalForbiddenResult(@"Orders.Update(Orders_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Orders.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="Orders"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Orders_Delete)){ return GetInternalForbiddenResult(@"Orders.Delete(Orders_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Orders.Delete);
            return InternalDelete(key);
        }
    }
}
