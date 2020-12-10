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
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Contracts.ActionServices;
using NorthWind.WebAPI.Contracts.DataObjects;


namespace NorthWind.WebAPI.Controllers.Actions
{

    /// <summary>
    /// 
    /// </summary>
    [AllowAnonymous]
    [RoutePrefix("api/reportservice")]
    public sealed class ReportServiceController: AbstractApiController
    {    

        /// <summary>
        /// Ctor
        /// </summary>
        public ReportServiceController(IRequestStorageInitializer requestInitializer, IFileStorageSwitcher fileStorageSwitcher, IFileStorageSaveOptionsSwitcher fileStorageSaveOptionsSwitcher, ISecurityService securityService, IWebApiActionService webApiActionService, IReportService service)
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
        private IReportService Service { get; }
    

        /// <summary>
        /// 
        /// </summary>
        [Route("serverprintsimple")]
        [HttpPost]
        public  HttpResponseMessage ServerPrintSimple()
        {
		    if(!Security.Authorize(DomainPermissions.ServerPrintSimple_Execute)){ ThrowInternalForbiddenException(@"Print report.Execute(ServerPrintSimple_Execute)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Custom.ReportService.ServerPrintSimple);

            try
            {
                    var result = Service.ServerPrintSimple();
				var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
				var reportContent = new StreamContent(result.Data.ReportStream);
                reportContent.Headers.Add("FullFileName", result.Data.FullFileName);
                reportContent.Headers.Add("Access-Control-Expose-Headers", "FullFileName");
                reportContent.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");  
                reportContent.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/octet-stream");
				response.Content = reportContent;
				return response;
            }
            catch (DomainException exc)
			{
                return new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    Content = new StringContent(exc.Message)
                };
			}
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        [Route("serverprintwithparameter")]
        [HttpPost]
        public  HttpResponseMessage ServerPrintWithParameter(int id)
        {
		    if(!Security.Authorize(DomainPermissions.ServerPrintWithParameter_Execute)){ ThrowInternalForbiddenException(@"Print report with parameter .Execute(ServerPrintWithParameter_Execute)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Custom.ReportService.ServerPrintWithParameter);

            try
            {
                    var result = Service.ServerPrintWithParameter(id);
				var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
				var reportContent = new StreamContent(result.Data.ReportStream);
                reportContent.Headers.Add("FullFileName", result.Data.FullFileName);
                reportContent.Headers.Add("Access-Control-Expose-Headers", "FullFileName");
                reportContent.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");  
                reportContent.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/octet-stream");
				response.Content = reportContent;
				return response;
            }
            catch (DomainException exc)
			{
                return new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    Content = new StringContent(exc.Message)
                };
			}
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="useExcel"></param>
        /// <param name="customerId"></param>
        [Route("serverprintwithform")]
        [HttpPost]
        public  HttpResponseMessage ServerPrintWithForm(int? employeeId, DateTime? fromDate, DateTime? toDate, bool useExcel, int? customerId)
        {
		    if(!Security.Authorize(DomainPermissions.ServerPrintWithForm_Execute)){ ThrowInternalForbiddenException(@"Print report with parameter .Execute(ServerPrintWithForm_Execute)"); }
            WebApiActionService.SetCurrentAction(DomainActions.Custom.ReportService.ServerPrintWithForm);

            try
            {
                    var result = Service.ServerPrintWithForm(employeeId, fromDate, toDate, useExcel, customerId);
				var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
				var reportContent = new StreamContent(result.Data.ReportStream);
                reportContent.Headers.Add("FullFileName", result.Data.FullFileName);
                reportContent.Headers.Add("Access-Control-Expose-Headers", "FullFileName");
                reportContent.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");  
                reportContent.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/octet-stream");
				response.Content = reportContent;
				return response;
            }
            catch (DomainException exc)
			{
                return new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    Content = new StringContent(exc.Message)
                };
			}
		}
    }
}