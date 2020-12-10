using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Files;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.Contracts.Reporting;
using NorthWind.Client.ServerServices.Properties;
using NorthWind.Client.Services.Contracts.ActionServices;
using NorthWind.Contracts;


namespace NorthWind.Client.ServerServices.ActionServices.Server.CodeBehind
{

    /// <summary>
    /// Code behind
    /// </summary>
    public abstract class CodeBehindReportService : IReportService
    {    

        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindReportService(IControllerClientFactory clientFactory)
        {
            ControllerClient = clientFactory.Create("reportservice");
        }

        /// <summary>
        ///  Server controller client
        /// </summary>
        protected IControllerClient ControllerClient { get; private set; }

		/// <inheritdoc />
		public virtual ActionResult<Report> ServerPrintSimple()
		{
		    var uri = ControllerClient.CreateUri().AddPart("serverprintsimple");
		
		
		    return ControllerClient.HttpPost<ActionResult<Report>>(uri.ToString());
		}

		/// <inheritdoc />
		public virtual bool ServerPrintSimpleCanExecute()
		{
		    return true;
		}
		/// <inheritdoc />
		public virtual string ServerPrintSimpleGetConfirmMessage()
		{
		    return ActionServiceResources.ReportService_ServerPrintSimple_ConfirmationMessage;
		}
		/// <inheritdoc />
		public virtual string ServerPrintSimpleGetWaitMessage()
		{
		    return ActionServiceResources.ReportService_ServerPrintSimple_WaitMessage;
		}
		/// <inheritdoc />
		public virtual ActionResult<Report> ServerPrintWithParameter(int id)
		{
		    var uri = ControllerClient.CreateUri().AddPart("serverprintwithparameter")
		    .AddParameter("id", id);
		
		
		    return ControllerClient.HttpPost<ActionResult<Report>>(uri.ToString());
		}

		/// <inheritdoc />
		public virtual bool ServerPrintWithParameterCanExecute()
		{
		    return true;
		}
		/// <inheritdoc />
		public virtual string ServerPrintWithParameterGetConfirmMessage()
		{
		    return ActionServiceResources.ReportService_ServerPrintWithParameter_ConfirmationMessage;
		}
		/// <inheritdoc />
		public virtual string ServerPrintWithParameterGetWaitMessage()
		{
		    return ActionServiceResources.ReportService_ServerPrintWithParameter_WaitMessage;
		}
		/// <inheritdoc />
		public virtual ActionResult<Report> ServerPrintWithForm(int? employeeId, DateTimeOffset? fromDate, DateTimeOffset? toDate, bool useExcel, int? customerId)
		{
		    var uri = ControllerClient.CreateUri().AddPart("serverprintwithform")
		    .AddParameter("employeeId", employeeId)
		    .AddParameter("fromDate", fromDate)
		    .AddParameter("toDate", toDate)
		    .AddParameter("useExcel", useExcel)
		    .AddParameter("customerId", customerId);
		
		
		    return ControllerClient.HttpPost<ActionResult<Report>>(uri.ToString());
		}

		/// <inheritdoc />
		public virtual bool ServerPrintWithFormCanExecute()
		{
		    return true;
		}
		/// <inheritdoc />
		public virtual string ServerPrintWithFormGetConfirmMessage()
		{
		    return ActionServiceResources.ReportService_ServerPrintWithForm_ConfirmationMessage;
		}
		/// <inheritdoc />
		public virtual string ServerPrintWithFormGetWaitMessage()
		{
		    return ActionServiceResources.ReportService_ServerPrintWithForm_WaitMessage;
		}
    }
}