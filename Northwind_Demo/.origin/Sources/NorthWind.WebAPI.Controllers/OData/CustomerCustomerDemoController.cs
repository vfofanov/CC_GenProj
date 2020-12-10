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
    ///     Controls <see cref="CustomerCustomerDemo" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class CustomerCustomerDemoController : AbstractODataController<CustomerCustomerDemo, CustomerCustomerDemoKey, ICustomerCustomerDemoRepository>
    {   
	    /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="requestInitializer"></param>     
        /// <param name="securityService"></param>     
        public CustomerCustomerDemoController(ICustomerCustomerDemoRepository repository, IRequestStorageInitializer requestInitializer, ISecurityService securityService)
		    : base(repository, requestInitializer, securityService)
		{
		    Security = securityService;
		}

		private ISecurityService Security { get; }

        /// <summary>
        /// Get all <see cref="CustomerCustomerDemo"/> objects
        /// </summary>
        /// <returns></returns>        
        [HttpGet]
        [EnableQuery(MaxNodeCount = DefaultOdataSettings.MaxNodeCount)]
		public IQueryable<CustomerCustomerDemo> Get()
        {
		    if(!Security.Authorize(DomainPermissions.CustomerCustomerDemo_Read)){ ThrowInternalForbiddenException(@"Customer customer demo.Read(CustomerCustomerDemo_Read)"); }
            return InternalGet();
        }

		/// <summary>
        /// Get <see cref="CustomerCustomerDemo"/> object by key
        /// </summary>
        [HttpGet]
        [EnableQuery(MaxNodeCount = DefaultOdataSettings.MaxNodeCount)]
		public IHttpActionResult Get(CustomerCustomerDemoKey key)
        {
		    if(!Security.Authorize(DomainPermissions.CustomerCustomerDemo_Read)){ ThrowInternalForbiddenException(@"Customer customer demo.Read(CustomerCustomerDemo_Read)"); }
            var data = Repository.GetByKey(key);
			return data == null ? (IHttpActionResult) NotFound() : Ok(data);            
        }
    }
}