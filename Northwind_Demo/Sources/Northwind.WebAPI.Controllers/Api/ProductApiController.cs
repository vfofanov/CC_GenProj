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
    ///     Controls <see cref="Product" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class ProductApiController : AbstractApiController<Product, int, IProductRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public ProductApiController(IProductRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="Product"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Product_Read)){ return GetInternalForbiddenResult(@"Product.Read(Product_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="Product"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.Product_Read)){ return GetInternalForbiddenResult(@"Product.Read(Product_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="Product"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.Product_Create)){ return GetInternalForbiddenResult(@"Product.Create(Product_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Product.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="Product"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.Product_Update)){ return GetInternalForbiddenResult(@"Product.Update(Product_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Product.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="Product"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Product_Delete)){ return GetInternalForbiddenResult(@"Product.Delete(Product_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Product.Delete);
            return InternalDelete(key);
        }
    }
}
