using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Files;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.Contracts.Reporting;
using Northwind.Client.ServerServices.Properties;
using Northwind.Client.Services.Contracts.ActionServices;
using Northwind.Contracts;


namespace Northwind.Client.ServerServices.ActionServices.Server.CodeBehind
{

    /// <summary>
    /// Code behind
    /// </summary>
    public abstract class CodeBehindTestDynamicColumnsActionService : ITestDynamicColumnsActionService
    {    

        /// <summary>
        /// Ctor
        /// </summary>
        protected CodeBehindTestDynamicColumnsActionService(IControllerClientFactory clientFactory)
        {
            ControllerClient = clientFactory.Create("testdynamiccolumnsactionservice");
        }

        /// <summary>
        ///  Server controller client
        /// </summary>
        protected IControllerClient ControllerClient { get; private set; }

		/// <inheritdoc />
		public virtual ActionResult GetTestData(DateTimeOffset startDate, DateTimeOffset endDate, int periodQuantity)
		{
		    var uri = ControllerClient.CreateUri().AddPart("gettestdata")
		    .AddParameter("startDate", startDate)
		    .AddParameter("endDate", endDate)
		    .AddParameter("periodQuantity", periodQuantity);
		
		
		    return ControllerClient.HttpPost<ActionResult>(uri.ToString());
		}

		/// <inheritdoc />
		public virtual bool GetTestDataCanExecute()
		{
		    return true;
		}
		/// <inheritdoc />
		public virtual string GetTestDataGetConfirmMessage()
		{
		    return ActionServiceResources.TestDynamicColumnsActionService_GetTestData_ConfirmationMessage;
		}
		/// <inheritdoc />
		public virtual string GetTestDataGetWaitMessage()
		{
		    return ActionServiceResources.TestDynamicColumnsActionService_GetTestData_WaitMessage;
		}
    }
}