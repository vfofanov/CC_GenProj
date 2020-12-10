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
    public partial class Region : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.Region; }
        }

        public Region()
		{
		}	
        public virtual string RegionDescription { get; set; }

        
		public Region Clone()
        {
            var obj = new Region
            {
                RegionDescription = RegionDescription,
            };

            if (IsNew())
            {
            }
            return obj;
        }
    }
}