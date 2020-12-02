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
    public partial class VSalesByCategory : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.VSalesByCategory; }
        }

        public VSalesByCategory()
		{
		}	
        public virtual string CategoryName { get; set; }

        public virtual string ProductName { get; set; }

        public virtual decimal? ProductSales { get; set; }

        
		public VSalesByCategory Clone()
        {
            var obj = new VSalesByCategory
            {
                CategoryName = CategoryName,
                ProductName = ProductName,
                ProductSales = ProductSales,
            };

            if (IsNew())
            {
            }
            return obj;
        }
    }
}