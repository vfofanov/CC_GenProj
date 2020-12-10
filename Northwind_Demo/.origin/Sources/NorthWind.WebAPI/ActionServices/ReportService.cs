using System;
using System.Collections.Generic;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.Contracts.Reporting;


namespace NorthWind.WebAPI.ActionServices
{

    /// <summary>
    /// 
    /// </summary>
    public sealed class ReportService : CodeBehind.CodeBehindReportService
    {
		/// <inheritdoc />
		public override ActionResult<Report> ServerPrintSimple()
		{
		    throw new NotImplementedException();
		}
		/// <inheritdoc />
		public override ActionResult<Report> ServerPrintWithParameter(int id)
		{
		    throw new NotImplementedException();
		}
		/// <inheritdoc />
		public override ActionResult<Report> ServerPrintWithForm(int? employeeId, DateTime? fromDate, DateTime? toDate, bool useExcel, int? customerId)
		{
		    throw new NotImplementedException();
		}
    }
}