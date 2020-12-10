using System;
using System.Collections.Generic;
using BusinessFramework.Contracts;
using BusinessFramework.Contracts.DataObjects;
using BusinessFramework.WebAPI.Contracts.DataObjects;
using BusinessFramework.WebAPI.Contracts.Metadata;
using Newtonsoft.Json;
using NorthWind.Contracts.DataObjects;

namespace NorthWind.WebAPI.Contracts.DataObjects
{    
    public partial class ReportFormQuery : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.ReportFormQuery; }
        }

        public ReportFormQuery()
		{
		}	
        public virtual int? CustomerId { get; set; }

        public virtual int? EmployeeId { get; set; }

        public virtual DateTime? From { get; set; }

        public virtual DateTime? To { get; set; }

        public virtual bool useExcel { get; set; }

        
		public ReportFormQuery Clone()
        {
            var obj = new ReportFormQuery
            {
                CustomerId = CustomerId,
                EmployeeId = EmployeeId,
                From = From,
                To = To,
                useExcel = useExcel,
            };

            return obj;
        }
    }
}