using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.WebAPI.Common.Controllers;
using BusinessFramework.WebAPI.Common.Files;
using BusinessFramework.WebAPI.Common.Request;
using BusinessFramework.WebAPI.Contracts.Exceptions;
using BusinessFramework.WebAPI.Contracts.Files;
using BusinessFramework.WebAPI.Contracts.Files.Storage;
using BusinessFramework.WebAPI.Contracts.Services;
using Northwind.WebAPI.Contracts;
using Northwind.WebAPI.Contracts.ActionServices;
using Northwind.WebAPI.Contracts.DataObjects;


namespace Northwind.WebAPI.Controllers.Actions
{

    /// <summary>
    /// 
    /// </summary>
    [AllowAnonymous]
    [RoutePrefix("api/testdynamiccolumnsactionservice")]
    public sealed class TestDynamicColumnsActionServiceController: AbstractApiController
    {    

        /// <summary>
        /// Ctor
        /// </summary>
        public TestDynamicColumnsActionServiceController(IRequestStorageInitializer requestInitializer, IFileStorageSwitcher fileStorageSwitcher, IFileStorageSaveOptionsSwitcher fileStorageSaveOptionsSwitcher, ISecurityService securityService, IWebApiActionService webApiActionService, ITestDynamicColumnsActionService service)
            :base(requestInitializer, securityService)
        {
            FileStorageSwitcher = fileStorageSwitcher;
			FileStorageSaveOptionsSwitcher = fileStorageSaveOptionsSwitcher;
			Security = securityService;
            WebApiActionService = webApiActionService;
            Service = service;
        }

        private IFileStorageSwitcher FileStorageSwitcher { get; }
		private IFileStorageSaveOptionsSwitcher FileStorageSaveOptionsSwitcher { get; }
		private ISecurityService Security { get; }
        private IWebApiActionService WebApiActionService { get; }
        private ITestDynamicColumnsActionService Service { get; }
    

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="periodQuantity"></param>
        [Route("gettestdata")]
        [HttpPost]
        public  ActionResult GetTestData(DateTime startDate, DateTime endDate, int periodQuantity)
        {
		    if(!Security.Authorize(DomainPermissions.GetTestData_Execute)){ ThrowInternalForbiddenException(@"GetTestData.Execute(GetTestData_Execute)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Custom.TestDynamicColumnsActionService.GetTestData);

            try
            {
                    var result = Service.GetTestData(startDate, endDate, periodQuantity);
                return result;
            }
            catch (DomainException exc)
			{
                return HandleException(exc);
			}
		}
    }
}