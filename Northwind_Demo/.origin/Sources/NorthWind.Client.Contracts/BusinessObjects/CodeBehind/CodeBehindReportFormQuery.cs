using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using BusinessFramework.Client.Contracts.DataObjects;
using BusinessFramework.Client.Contracts.DataObjects.Attributes;
using BusinessFramework.Client.Contracts.DataObjects.Validation;
using NorthWind.Client.Contracts.Properties;


namespace NorthWind.Client.Contracts.BusinessObjects.CodeBehind
{
    [Serializable]
	[DebuggerDisplay("ReportFormQuery" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(QueryResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindReportFormQuery : ClassicDataObject<int, ReportFormQuery>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static ReportFormQuery CreateReportFormQuery(int id)
        {
            return new ReportFormQuery {Id = id};
        }

        private int? _customerId;
        private int? _employeeId;
        private DateTimeOffset? _from;
        private DateTimeOffset? _to;
        private bool _useExcel;

        protected CodeBehindReportFormQuery()
		{
		}

		protected CodeBehindReportFormQuery(ReportFormQuery origin)
		    :base(origin)
	    {
            _customerId = origin._customerId;
            _employeeId = origin._employeeId;
            _from = origin._from;
            _to = origin._to;
            _useExcel = origin._useExcel;
		}

		[Display(ResourceType = typeof(QueryResources), Name = "ReportFormQuery_CustomerId")]
		public virtual int? CustomerId
        {
            [DebuggerStepThrough]
            get { return _customerId; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _customerId, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ReportFormQuery_EmployeeId")]
		public virtual int? EmployeeId
        {
            [DebuggerStepThrough]
            get { return _employeeId; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employeeId, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ReportFormQuery_From")]
		public virtual DateTimeOffset? From
        {
            [DebuggerStepThrough]
            get { return _from; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _from, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ReportFormQuery_To")]
		public virtual DateTimeOffset? To
        {
            [DebuggerStepThrough]
            get { return _to; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _to, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ReportFormQuery_useExcel")]
		public virtual bool useExcel
        {
            [DebuggerStepThrough]
            get { return _useExcel; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _useExcel, value); }
        } 
    } 
}
