using Microsoft.AspNet.OData;
using System;
using System.Linq;
using System.Web.Http;
using BusinessFramework.WebAPI.Common.Controllers;
using BusinessFramework.WebAPI.Common.Request;
using NorthWind.Contracts;
using NorthWind.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.Repositories;


namespace NorthWind.WebAPI.Controllers.OData
{
    /// <summary>
    ///     Controls <see cref="OrderProductQuery" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class OrderProductQueryController : AbstractODataController<OrderProductQuery, OrderProductQueryKey, IOrderProductQueryRepository>
    {   
	    /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="requestInitializer"></param>     
        /// <param name="securityService"></param>     
        public OrderProductQueryController(IOrderProductQueryRepository repository, IRequestStorageInitializer requestInitializer, ISecurityService securityService)
		    : base(repository, requestInitializer, securityService)
		{
		    Security = securityService;
		}

		private ISecurityService Security { get; }

        /// <summary>
        /// Get all <see cref="OrderProductQuery"/> objects
        /// </summary>
        /// <returns></returns>        
        [HttpGet]
        [EnableQuery(MaxNodeCount = DefaultOdataSettings.MaxNodeCount)]
		public IQueryable<OrderProductQuery> Get()
        {
		    if(!Security.Authorize(DomainPermissions.OrderProductQuery_Read)){ ThrowInternalForbiddenException(@"OrderProductQuery.Read(OrderProductQuery_Read)"); }
            return InternalGet();
        }

		/// <summary>
        /// Get <see cref="OrderProductQuery"/> object by key
        /// </summary>
        [HttpGet]
        [EnableQuery(MaxNodeCount = DefaultOdataSettings.MaxNodeCount)]
		public IHttpActionResult Get(OrderProductQueryKey key)
        {
		    if(!Security.Authorize(DomainPermissions.OrderProductQuery_Read)){ ThrowInternalForbiddenException(@"OrderProductQuery.Read(OrderProductQuery_Read)"); }
            var data = Repository.GetByKey(key);
			return data == null ? (IHttpActionResult) NotFound() : Ok(data);            
        }
    }
}