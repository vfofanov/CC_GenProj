﻿using System.Linq;
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
    ///     Controls <see cref="OrderProductQuery" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class OrderProductQueryApiController : AbstractApiController<OrderProductQuery, OrderProductQueryKey, IOrderProductQueryRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public OrderProductQueryApiController(IOrderProductQueryRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="OrderProductQuery"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(OrderProductQueryKey key)
        {
		    if(!Security.Authorize(DomainPermissions.OrderProductQuery_Read)){ return GetInternalForbiddenResult(@"OrderProductQuery.Read(OrderProductQuery_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="OrderProductQuery"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.OrderProductQuery_Read)){ return GetInternalForbiddenResult(@"OrderProductQuery.Read(OrderProductQuery_Read)"); }
            return InternalGetAll();
        }
    }
}
