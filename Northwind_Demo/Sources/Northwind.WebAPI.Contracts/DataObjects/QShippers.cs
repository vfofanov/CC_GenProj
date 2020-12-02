using System;
using System.Collections.Generic;
using BusinessFramework.Contracts;
using BusinessFramework.Contracts.DataObjects;
using BusinessFramework.WebAPI.Contracts.DataObjects;
using BusinessFramework.WebAPI.Contracts.Metadata;
using Newtonsoft.Json;
using Northwind.Contracts.DataObjects;

namespace Northwind.WebAPI.Contracts.DataObjects
{    
    public partial class QShippers : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.QShippers; }
        }

        public QShippers()
		{
		}	
        public virtual string CompanyName { get; set; }

        public virtual string Phone { get; set; }

        
		public QShippers Clone()
        {
            var obj = new QShippers
            {
                CompanyName = CompanyName,
                Phone = Phone,
            };

            return obj;
        }
    }
}