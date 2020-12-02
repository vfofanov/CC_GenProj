using Microsoft.AspNet.OData;
using System;
using System.Linq;
using System.Web.Http;
using BusinessFramework.WebAPI.Common.Controllers;
using BusinessFramework.WebAPI.Common.Request;
using Northwind.Contracts;
using Northwind.WebAPI.Contracts;
using Northwind.WebAPI.Contracts.DataObjects;
using Northwind.WebAPI.Contracts.Repositories;


namespace Northwind.WebAPI.Controllers.OData
{
    /// <summary>
    ///     Controls <see cref="OrderStatus" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class OrderStatusController : AbstractODataController<OrderStatus, short, IOrderStatusRepository>
    {   
	    /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="requestInitializer"></param>     
        /// <param name="securityService"></param>     
        public OrderStatusController(IOrderStatusRepository repository, IRequestStorageInitializer requestInitializer, ISecurityService securityService)
		    : base(repository, requestInitializer, securityService)
		{
		    Security = securityService;
		}

		private ISecurityService Security { get; }

        /// <summary>
        /// Get all <see cref="OrderStatus"/> objects
        /// </summary>
        /// <returns></returns>        
        [HttpGet]
        [EnableQuery(MaxNodeCount = DefaultOdataSettings.MaxNodeCount)]
		public IQueryable<OrderStatus> Get()
        {
		    if(!Security.Authorize(DomainPermissions.OrderStatus_Read)){ ThrowInternalForbiddenException(@"Order status.Read(OrderStatus_Read)"); }
            return InternalGet();
        }

		/// <summary>
        /// Get <see cref="OrderStatus"/> object by key
        /// </summary>
        [HttpGet]
        [EnableQuery(MaxNodeCount = DefaultOdataSettings.MaxNodeCount)]
		public IHttpActionResult Get(short key)
        {
		    if(!Security.Authorize(DomainPermissions.OrderStatus_Read)){ ThrowInternalForbiddenException(@"Order status.Read(OrderStatus_Read)"); }
            var data = Repository.GetByKey(key);
			return data == null ? (IHttpActionResult) NotFound() : Ok(data);            
        }
    }
}