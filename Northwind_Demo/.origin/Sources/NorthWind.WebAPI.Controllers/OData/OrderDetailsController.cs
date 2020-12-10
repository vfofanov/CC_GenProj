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
    ///     Controls <see cref="OrderDetails" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class OrderDetailsController : AbstractODataController<OrderDetails, OrderDetailsKey, IOrderDetailsRepository>
    {   
	    /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="requestInitializer"></param>     
        /// <param name="securityService"></param>     
        public OrderDetailsController(IOrderDetailsRepository repository, IRequestStorageInitializer requestInitializer, ISecurityService securityService)
		    : base(repository, requestInitializer, securityService)
		{
		    Security = securityService;
		}

		private ISecurityService Security { get; }

        /// <summary>
        /// Get all <see cref="OrderDetails"/> objects
        /// </summary>
        /// <returns></returns>        
        [HttpGet]
        [EnableQuery(MaxNodeCount = DefaultOdataSettings.MaxNodeCount)]
		public IQueryable<OrderDetails> Get()
        {
		    if(!Security.Authorize(DomainPermissions.OrderDetails_Read)){ ThrowInternalForbiddenException(@"OrderDetails.Read(OrderDetails_Read)"); }
            return InternalGet();
        }

		/// <summary>
        /// Get <see cref="OrderDetails"/> object by key
        /// </summary>
        [HttpGet]
        [EnableQuery(MaxNodeCount = DefaultOdataSettings.MaxNodeCount)]
		public IHttpActionResult Get(OrderDetailsKey key)
        {
		    if(!Security.Authorize(DomainPermissions.OrderDetails_Read)){ ThrowInternalForbiddenException(@"OrderDetails.Read(OrderDetails_Read)"); }
            var data = Repository.GetByKey(key);
			return data == null ? (IHttpActionResult) NotFound() : Ok(data);            
        }
    }
}