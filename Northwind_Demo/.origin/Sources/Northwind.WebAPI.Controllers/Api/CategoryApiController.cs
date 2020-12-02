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
    ///     Controls <see cref="Category" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class CategoryApiController : AbstractApiController<Category, int, ICategoryRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public CategoryApiController(ICategoryRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="Category"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Category_Read)){ return GetInternalForbiddenResult(@"Category.Read(Category_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="Category"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.Category_Read)){ return GetInternalForbiddenResult(@"Category.Read(Category_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="Category"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.Category_Create)){ return GetInternalForbiddenResult(@"Category.Create(Category_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Category.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="Category"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.Category_Update)){ return GetInternalForbiddenResult(@"Category.Update(Category_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Category.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="Category"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Category_Delete)){ return GetInternalForbiddenResult(@"Category.Delete(Category_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Category.Delete);
            return InternalDelete(key);
        }
    }
}
