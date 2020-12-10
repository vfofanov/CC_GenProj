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
    public partial class RegionQuery : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.RegionQuery; }
        }

        public RegionQuery()
		{
		}	
        public virtual string RegionDescription { get; set; }

        
		public RegionQuery Clone()
        {
            var obj = new RegionQuery
            {
                RegionDescription = RegionDescription,
            };

            return obj;
        }
    }
}