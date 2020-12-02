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
    ///     Controls <see cref="QOrderProducts" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class QOrderProductsApiController : AbstractApiController<QOrderProducts, int, IQOrderProductsRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public QOrderProductsApiController(IQOrderProductsRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="QOrderProducts"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.QOrderProducts_Read)){ return GetInternalForbiddenResult(@"qOrderProducts.Read(QOrderProducts_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="QOrderProducts"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.QOrderProducts_Read)){ return GetInternalForbiddenResult(@"qOrderProducts.Read(QOrderProducts_Read)"); }
            return InternalGetAll();
        }
    }
}
