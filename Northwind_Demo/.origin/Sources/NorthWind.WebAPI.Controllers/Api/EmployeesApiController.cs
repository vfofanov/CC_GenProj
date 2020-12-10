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
    ///     Controls <see cref="Employees" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class EmployeesApiController : FileContainerAbstractApiController<Employees, int, IEmployeesRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public EmployeesApiController(IEmployeesRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService, IFileStorageSwitcher fileStorageSwitcher, IFileStorageSaveOptionsSwitcher fileStorageSaveOptionsSwitcher, IFileLinkRepository fileLinkRepository)
            : base(repository, validatorFactory, requestInitializer, fileStorageSwitcher, fileStorageSaveOptionsSwitcher, fileLinkRepository, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="Employees"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Employees_Read)){ return GetInternalForbiddenResult(@"Employees.Read(Employees_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="Employees"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.Employees_Read)){ return GetInternalForbiddenResult(@"Employees.Read(Employees_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="Employees"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.Employees_Create)){ return GetInternalForbiddenResult(@"Employees.Create(Employees_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Employees.Create);
            return await InternalPostAsync();
        }
        /// <summary>
        /// Update <see cref="Employees"/> object
        /// </summary>
        public async Task<IHttpActionResult> Put()
        {
		    if(!Security.Authorize(DomainPermissions.Employees_Update)){ return GetInternalForbiddenResult(@"Employees.Update(Employees_Update)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Employees.Update);
            return await InternalPutAsync();
        }
        /// <summary>
        /// Delete <see cref="Employees"/> object
        /// </summary>
		public IHttpActionResult Delete(int key)
        {
		    if(!Security.Authorize(DomainPermissions.Employees_Delete)){ return GetInternalForbiddenResult(@"Employees.Delete(Employees_Delete)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.Employees.Delete);
            return InternalDelete(key);
        }
    }
}
