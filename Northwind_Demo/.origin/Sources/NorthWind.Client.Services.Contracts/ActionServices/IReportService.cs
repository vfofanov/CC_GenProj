using System;
using System.Collections.Generic;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.Contracts.Reporting;


namespace NorthWind.Client.Services.Contracts.ActionServices
{

    /// <summary>
    /// 
    /// </summary>
    public partial interface IReportService
    {    

        /// <summary>
        /// 
        /// </summary>
        ActionResult<Report> ServerPrintSimple();

        /// <summary>
        /// Can execute. 
        /// </summary>
        bool ServerPrintSimpleCanExecute();

        /// <summary>
        /// Get confirmation message. 
        /// </summary>
        string ServerPrintSimpleGetConfirmMessage();

        /// <summary>
        /// Get waiting message. 
        /// </summary>
        string ServerPrintSimpleGetWaitMessage();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        ActionResult<Report> ServerPrintWithParameter(int id);

        /// <summary>
        /// Can execute. 
        /// </summary>
        bool ServerPrintWithParameterCanExecute();

        /// <summary>
        /// Get confirmation message. 
        /// </summary>
        string ServerPrintWithParameterGetConfirmMessage();

        /// <summary>
        /// Get waiting message. 
        /// </summary>
        string ServerPrintWithParameterGetWaitMessage();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="useExcel"></param>
        /// <param name="customerId"></param>
        ActionResult<Report> ServerPrintWithForm(int? employeeId, DateTimeOffset? fromDate, DateTimeOffset? toDate, bool useExcel, int? customerId);

        /// <summary>
        /// Can execute. 
        /// </summary>
        bool ServerPrintWithFormCanExecute();

        /// <summary>
        /// Get confirmation message. 
        /// </summary>
        string ServerPrintWithFormGetConfirmMessage();

        /// <summary>
        /// Get waiting message. 
        /// </summary>
        string ServerPrintWithFormGetWaitMessage();
    }
}