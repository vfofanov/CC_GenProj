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
    ///     Controls <see cref="VSalesByCategory" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class VSalesByCategoryApiController : AbstractApiController<VSalesByCategory, int, IVSalesByCategoryRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public VSalesByCategoryApiController(IVSalesByCategoryRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="VSalesByCategory"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.VSalesByCategory_Read)){ return GetInternalForbiddenResult(@"V sales by category.Read(VSalesByCategory_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="VSalesByCategory"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.VSalesByCategory_Read)){ return GetInternalForbiddenResult(@"V sales by category.Read(VSalesByCategory_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="VSalesByCategory"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.VSalesByCategory_Create)){ return GetInternalForbiddenResult(@"V sales by category.Create(VSalesByCategory_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.VSalesByCategory.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="VSalesByCategory"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.VSalesByCategory_Update)){ return GetInternalForbiddenResult(@"V sales by category.Update(VSalesByCategory_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.VSalesByCategory.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="VSalesByCategory"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.VSalesByCategory_Delete)){ return GetInternalForbiddenResult(@"V sales by category.Delete(VSalesByCategory_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.VSalesByCategory.Delete);
            return InternalDelete(key);
        }
    }
}
