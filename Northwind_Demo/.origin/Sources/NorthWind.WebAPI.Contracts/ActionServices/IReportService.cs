using System;
using System.Collections.Generic;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.Contracts.Reporting;


namespace NorthWind.WebAPI.Contracts.ActionServices
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
        /// 
        /// </summary>
        /// <param name="id"></param>
        ActionResult<Report> ServerPrintWithParameter(int id);

        /// <summary>
        /// Can execute. 
        /// </summary>
        bool ServerPrintWithParameterCanExecute();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="useExcel"></param>
        /// <param name="customerId"></param>
        ActionResult<Report> ServerPrintWithForm(int? employeeId, DateTime? fromDate, DateTime? toDate, bool useExcel, int? customerId);

        /// <summary>
        /// Can execute. 
        /// </summary>
        bool ServerPrintWithFormCanExecute();
    }
}