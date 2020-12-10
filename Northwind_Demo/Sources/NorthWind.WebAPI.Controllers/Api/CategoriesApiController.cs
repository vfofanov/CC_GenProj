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
    ///     Controls <see cref="Categories" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class CategoriesApiController : AbstractApiController<Categories, int, ICategoriesRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public CategoriesApiController(ICategoriesRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="Categories"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Categories_Read)){ return GetInternalForbiddenResult(@"Categories.Read(Categories_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="Categories"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.Categories_Read)){ return GetInternalForbiddenResult(@"Categories.Read(Categories_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="Categories"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.Categories_Create)){ return GetInternalForbiddenResult(@"Categories.Create(Categories_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Categories.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="Categories"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.Categories_Update)){ return GetInternalForbiddenResult(@"Categories.Update(Categories_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Categories.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="Categories"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Categories_Delete)){ return GetInternalForbiddenResult(@"Categories.Delete(Categories_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Categories.Delete);
            return InternalDelete(key);
        }
    }
}
