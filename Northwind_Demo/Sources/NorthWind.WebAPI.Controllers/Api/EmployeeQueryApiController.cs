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
    ///     Controls <see cref="EmployeeQuery" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class EmployeeQueryApiController : FileContainerAbstractApiController<EmployeeQuery, int, IEmployeeQueryRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public EmployeeQueryApiController(IEmployeeQueryRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService, IFileStorageSwitcher fileStorageSwitcher, IFileStorageSaveOptionsSwitcher fileStorageSaveOptionsSwitcher, IFileLinkRepository fileLinkRepository)
            : base(repository, validatorFactory, requestInitializer, fileStorageSwitcher, fileStorageSaveOptionsSwitcher, fileLinkRepository, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="EmployeeQuery"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.EmployeeQuery_Read)){ return GetInternalForbiddenResult(@"EmployeeQuery.Read(EmployeeQuery_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="EmployeeQuery"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.EmployeeQuery_Read)){ return GetInternalForbiddenResult(@"EmployeeQuery.Read(EmployeeQuery_Read)"); }
            return InternalGetAll();
        }
    }
}
