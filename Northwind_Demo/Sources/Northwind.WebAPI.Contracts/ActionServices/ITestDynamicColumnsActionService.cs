using System;
using System.Collections.Generic;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.Contracts.Reporting;


namespace Northwind.WebAPI.Contracts.ActionServices
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
        ActionResult GetTestData(DateTime startDate, DateTime endDate, int periodQuantity);

        /// <summary>
        /// Can execute. 
        /// </summary>
        bool GetTestDataCanExecute();
    }
}