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
    public partial class EmployeeTerritory : AbstractApiEntity<EmployeeTerritoryKey>
    {	
        public override IDomainObject DomainKey
        {
            get { return DomainObjects.EmployeeTerritory; }
        }

        public EmployeeTerritory()
		{
		}	
        public virtual int EmployeeID { get; set; }

        public virtual int TerritoryID { get; set; }

        [JsonIgnore]
        public virtual Employees Employees { get; set; }

        [JsonIgnore]
        public virtual Territory Territory { get; set; }

        public override EmployeeTerritoryKey GetKey()
        {
            return new EmployeeTerritoryKey(EmployeeID, TerritoryID);
            
        }
        
		public bool IsNew()
        {
		    return Equals(EmployeeID, default(int)) && Equals(TerritoryID, default(int));
        }
        
		public EmployeeTerritory Clone()
        {
            var obj = new EmployeeTerritory
            {
            };

            return obj;
        }
    }
}