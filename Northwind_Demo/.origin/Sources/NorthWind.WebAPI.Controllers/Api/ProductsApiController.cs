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
using NorthWind.Contracts;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebAPI.Contracts.Repositories;


namespace NorthWind.WebAPI.Controllers.Api
{
    /// <summary>
    ///     Controls <see cref="Products" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class ProductsApiController : AbstractApiController<Products, int, IProductsRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public ProductsApiController(IProductsRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="Products"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Products_Read)){ return GetInternalForbiddenResult(@"Products.Read(Products_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="Products"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.Products_Read)){ return GetInternalForbiddenResult(@"Products.Read(Products_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="Products"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.Products_Create)){ return GetInternalForbiddenResult(@"Products.Create(Products_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Products.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="Products"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.Products_Update)){ return GetInternalForbiddenResult(@"Products.Update(Products_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Products.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="Products"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Products_Delete)){ return GetInternalForbiddenResult(@"Products.Delete(Products_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Products.Delete);
            return InternalDelete(key);
        }
    }
}
