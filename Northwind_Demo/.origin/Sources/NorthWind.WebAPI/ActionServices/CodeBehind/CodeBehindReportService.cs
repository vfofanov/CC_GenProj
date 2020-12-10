using System;
using System.Collections.Generic;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.Contracts.Reporting;
using NorthWind.Contracts;
using NorthWind.WebAPI.Contracts.ActionServices;
using NorthWind.WebAPI.Properties;


namespace NorthWind.WebAPI.ActionServices.CodeBehind
{

    /// <summary>
    /// Code behind
    /// </summary>
    public abstract partial class CodeBehindReportService : IReportService
    {
		/// <inheritdoc />
		public abstract ActionResult<Report> ServerPrintSimple();
		/// <inheritdoc />
		public virtual bool ServerPrintSimpleCanExecute()
		{
		    return true;
		}
		/// <inheritdoc />
		public abstract ActionResult<Report> ServerPrintWithParameter(int id);
		/// <inheritdoc />
		public virtual bool ServerPrintWithParameterCanExecute()
		{
		    return true;
		}
		/// <inheritdoc />
		public abstract ActionResult<Report> ServerPrintWithForm(int? employeeId, DateTime? fromDate, DateTime? toDate, bool useExcel, int? customerId);
		/// <inheritdoc />
		public virtual bool ServerPrintWithFormCanExecute()
		{
		    return true;
		}
    }
}