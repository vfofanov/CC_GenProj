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
    public partial class SysObjectType : ClassicApiEntity<int>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.SysObjectType; }
        }

        public SysObjectType()
		{
		}	
        public virtual string Name { get; set; }

        
		public SysObjectType Clone()
        {
            var obj = new SysObjectType
            {
                Name = Name,
            };

            if (IsNew())
            {
            }
            return obj;
        }
    }
}