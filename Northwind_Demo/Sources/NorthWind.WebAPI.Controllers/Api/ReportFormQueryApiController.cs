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
    ///     Controls <see cref="ReportFormQuery" /> objects
    /// </summary>
    [AllowAnonymous]
	public sealed class ReportFormQueryApiController : AbstractApiController<ReportFormQuery, int, IReportFormQueryRepository>
    {
	    /// <summary>
        /// Ctor
        /// </summary>
        public ReportFormQueryApiController(IReportFormQueryRepository repository, IEntityValidatorFactory validatorFactory, IRequestStorageInitializer requestInitializer, 
		                               ISecurityService securityService, IWebApiActionService webApiActionService)
            : base(repository, validatorFactory, requestInitializer, securityService)
        {
            WebApiActionService = webApiActionService;
			Security = securityService;
        }

        private IWebApiActionService WebApiActionService { get; }

		private ISecurityService Security { get; }


		/// <summary>
        /// Get <see cref="ReportFormQuery"/> object by key
        /// </summary>          
        public IHttpActionResult GetByKey(int key)
        {
		    if(!Security.Authorize(DomainPermissions.ReportFormQuery_Read)){ return GetInternalForbiddenResult(@"ReportFormQuery.Read(ReportFormQuery_Read)"); }
            return InternalGetByKey(key);
        }

        /// <summary>
        /// Get all <see cref="ReportFormQuery"/> objects
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetAll()
        {
		    if(!Security.Authorize(DomainPermissions.ReportFormQuery_Read)){ return GetInternalForbiddenResult(@"ReportFormQuery.Read(ReportFormQuery_Read)"); }
            return InternalGetAll();
        }
        /// <summary>
        /// Create <see cref="ReportFormQuery"/> object
        /// </summary>
        public async Task<IHttpActionResult> Post()
        {
		    if(!Security.Authorize(DomainPermissions.ReportFormQuery_Create)){ return GetInternalForbiddenResult(@"ReportFormQuery.Create(ReportFormQuery_Create)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Object.ReportFormQuery.Create);
            return await InternalPostAsync();
        }
    }
}
