using System;
using System.Collections.Generic;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.Contracts.Reporting;


namespace Northwind.Client.Services.Contracts.ActionServices
{

    /// <summary>
    /// 
    /// </summary>
    public partial interface ITestDynamicColumnsActionService
    {    

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="periodQuantity"></param>
        ActionResult GetTestData(DateTimeOffset startDate, DateTimeOffset endDate, int periodQuantity);

        /// <summary>
        /// Can execute. 
        /// </summary>
        bool GetTestDataCanExecute();

        /// <summary>
        /// Get confirmation message. 
        /// </summary>
        string GetTestDataGetConfirmMessage();

        /// <summary>
        /// Get waiting message. 
        /// </summary>
        string GetTestDataGetWaitMessage();
    }
}