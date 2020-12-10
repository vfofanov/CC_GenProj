using Microsoft.AspNet.OData;
using System;
using System.Linq;
using System.Web.Http;
using BusinessFramework.WebAPI.Common.Controllers;
using BusinessFramework.WebAPI.Common.Request;
using NorthWind.Contracts;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.Repositories;


namespace NorthWind.WebAPI.Controllers.OData
{
    /// <summary>
    ///     Controls <see cref="OrdersQuery" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class OrdersQueryController : AbstractODataController<OrdersQuery, int, IOrdersQueryRepository>
    {   
	    /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="requestInitializer"></param>     
        /// <param name="securityService"></param>     
        public OrdersQueryController(IOrdersQueryRepository repository, IRequestStorageInitializer requestInitializer, ISecurityService securityService)
		    : base(repository, requestInitializer, securityService)
		{
		    Security = securityService;
		}

		private ISecurityService Security { get; }

        /// <summary>
        /// Get all <see cref="OrdersQuery"/> objects
        /// </summary>
        /// <returns></returns>        
        [HttpGet]
        [EnableQuery(MaxNodeCount = DefaultOdataSettings.MaxNodeCount)]
		public IQueryable<OrdersQuery> Get()
        {
		    if(!Security.Authorize(DomainPermissions.OrdersQuery_Read)){ ThrowInternalForbiddenException(@"OrdersQuery.Read(OrdersQuery_Read)"); }
            return InternalGet();
        }

		/// <summary>
        /// Get <see cref="OrdersQuery"/> object by key
        /// </summary>
        [HttpGet]
        [EnableQuery(MaxNodeCount = DefaultOdataSettings.MaxNodeCount)]
		public IHttpActionResult Get(int key)
        {
		    if(!Security.Authorize(DomainPermissions.OrdersQuery_Read)){ ThrowInternalForbiddenException(@"OrdersQuery.Read(OrdersQuery_Read)"); }
            var data = Repository.GetByKey(key);
			return data == null ? (IHttpActionResult) NotFound() : Ok(data);            
        }
    }
}