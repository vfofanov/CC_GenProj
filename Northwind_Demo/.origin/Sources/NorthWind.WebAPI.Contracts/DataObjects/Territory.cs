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
    public partial class Territory : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.Territory; }
        }

        public Territory()
		{
		}	
        [JsonIgnore]
        public virtual Region Region { get; set; }

        public virtual int RegionID { get; set; }

        public virtual string TerritoryDescription { get; set; }

        
		public Territory Clone()
        {
            var obj = new Territory
            {
                RegionID = RegionID,
                TerritoryDescription = TerritoryDescription,
            };

            if (IsNew())
            {
                if(Region != null && Region.IsNew())  
                {
                   obj.Region = Region;
                }
            }
            return obj;
        }
    }
}