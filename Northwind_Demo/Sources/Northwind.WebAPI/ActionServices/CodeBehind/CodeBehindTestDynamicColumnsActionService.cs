using System;
using System.Collections.Generic;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.Contracts.Reporting;
using Northwind.Contracts;
using Northwind.WebAPI.Contracts.ActionServices;
using Northwind.WebAPI.Properties;


namespace Northwind.WebAPI.ActionServices.CodeBehind
{

    /// <summary>
    /// Code behind
    /// </summary>
    public abstract partial class CodeBehindTestDynamicColumnsActionService : ITestDynamicColumnsActionService
    {
		/// <inheritdoc />
		public abstract ActionResult GetTestData(DateTime startDate, DateTime endDate, int periodQuantity);
		/// <inheritdoc />
		public virtual bool GetTestDataCanExecute()
		{
		    return true;
		}
    }
}