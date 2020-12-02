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
    ///     Controls <see cref="VSalesByCategory" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class VSalesByCategoryController : AbstractODataController<VSalesByCategory, int, IVSalesByCategoryRepository>
    {   
	    /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="requestInitializer"></param>     
        /// <param name="securityService"></param>     
        public VSalesByCategoryController(IVSalesByCategoryRepository repository, IRequestStorageInitializer requestInitializer, ISecurityService securityService)
		    : base(repository, requestInitializer, securityService)
		{
		    Security = securityService;
		}

		private ISecurityService Security { get; }

        /// <summary>
        /// Get all <see cref="VSalesByCategory"/> objects
        /// </summary>
        /// <returns></returns>        
        [HttpGet]
        [EnableQuery(MaxNodeCount = DefaultOdataSettings.MaxNodeCount)]
		public IQueryable<VSalesByCategory> Get()
        {
		    if(!Security.Authorize(DomainPermissions.VSalesByCategory_Read)){ ThrowInternalForbiddenException(@"V sales by category.Read(VSalesByCategory_Read)"); }
            return InternalGet();
        }

		/// <summary>
        /// Get <see cref="VSalesByCategory"/> object by key
        /// </summary>
        [HttpGet]
        [EnableQuery(MaxNodeCount = DefaultOdataSettings.MaxNodeCount)]
		public IHttpActionResult Get(int key)
        {
		    if(!Security.Authorize(DomainPermissions.VSalesByCategory_Read)){ ThrowInternalForbiddenException(@"V sales by category.Read(VSalesByCategory_Read)"); }
            var data = Repository.GetByKey(key);
			return data == null ? (IHttpActionResult) NotFound() : Ok(data);            
        }
    }
}