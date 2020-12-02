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
    ///     Controls <see cref="OrderDetail" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class OrderDetailApiController : AbstractApiController<OrderDetail, int, IOrderDetailRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public OrderDetailApiController(IOrderDetailRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="OrderDetail"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.OrderDetail_Read)){ return GetInternalForbiddenResult(@"Order detail.Read(OrderDetail_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="OrderDetail"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.OrderDetail_Read)){ return GetInternalForbiddenResult(@"Order detail.Read(OrderDetail_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="OrderDetail"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.OrderDetail_Create)){ return GetInternalForbiddenResult(@"Order detail.Create(OrderDetail_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.OrderDetail.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="OrderDetail"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.OrderDetail_Update)){ return GetInternalForbiddenResult(@"Order detail.Update(OrderDetail_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.OrderDetail.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="OrderDetail"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.OrderDetail_Delete)){ return GetInternalForbiddenResult(@"Order detail.Delete(OrderDetail_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.OrderDetail.Delete);
            return InternalDelete(key);
        }
    }
}
