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
    ///     Controls <see cref="QOrderProducts" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class QOrderProductsController : AbstractODataController<QOrderProducts, int, IQOrderProductsRepository>
    {   
	    /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="requestInitializer"></param>     
        /// <param name="securityService"></param>     
        public QOrderProductsController(IQOrderProductsRepository repository, IRequestStorageInitializer requestInitializer, ISecurityService securityService)
		    : base(repository, requestInitializer, securityService)
		{
		    Security = securityService;
		}

		private ISecurityService Security { get; }

        /// <summary>
        /// Get all <see cref="QOrderProducts"/> objects
        /// </summary>
        /// <returns></returns>        
        [HttpGet]
        [EnableQuery(MaxNodeCount = DefaultOdataSettings.MaxNodeCount)]
		public IQueryable<QOrderProducts> Get()
        {
		    if(!Security.Authorize(DomainPermissions.QOrderProducts_Read)){ ThrowInternalForbiddenException(@"qOrderProducts.Read(QOrderProducts_Read)"); }
            return InternalGet();
        }

		/// <summary>
        /// Get <see cref="QOrderProducts"/> object by key
        /// </summary>
        [HttpGet]
        [EnableQuery(MaxNodeCount = DefaultOdataSettings.MaxNodeCount)]
		public IHttpActionResult Get(int key)
        {
		    if(!Security.Authorize(DomainPermissions.QOrderProducts_Read)){ ThrowInternalForbiddenException(@"qOrderProducts.Read(QOrderProducts_Read)"); }
            var data = Repository.GetByKey(key);
			return data == null ? (IHttpActionResult) NotFound() : Ok(data);            
        }
    }
}