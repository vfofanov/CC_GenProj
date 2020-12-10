using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using BusinessFramework.Client.Contracts.DataObjects;
using BusinessFramework.Client.Contracts.DataObjects.Attributes;
using BusinessFramework.Client.Contracts.DataObjects.Validation;
using NorthWind.Client.Contracts.Properties;
using NorthWind.Contracts.DataObjects;


namespace NorthWind.Client.Contracts.BusinessObjects.CodeBehind
{
    [Serializable]
	[DebuggerDisplay("EmployeeTerritory" + " {"+ nameof(EmployeeID) +"}" + " {"+ nameof(TerritoryID) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(EmployeeID), nameof(TerritoryID))]
    public abstract class CodeBehindEmployeeTerritory : AbstractDataObject<EmployeeTerritoryKey, EmployeeTerritory>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static EmployeeTerritory CreateEmployeeTerritory(int employeeID, int territoryID)
        {
            return new EmployeeTerritory {EmployeeID = employeeID, TerritoryID = territoryID};
        }

        private int _employeeID;
        private int _territoryID;

        protected CodeBehindEmployeeTerritory()
		{
		}

		protected CodeBehindEmployeeTerritory(EmployeeTerritory origin)
		    :base(origin)
	    {
            _employeeID = origin._employeeID;
            _territoryID = origin._territoryID;
		}

        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "EmployeeTerritory_EmployeeID_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "EmployeeTerritory_EmployeeID")]
		public virtual int EmployeeID
        {
            [DebuggerStepThrough]
            get { return _employeeID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employeeID, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "EmployeeTerritory_TerritoryID_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "EmployeeTerritory_TerritoryID")]
		public virtual int TerritoryID
        {
            [DebuggerStepThrough]
            get { return _territoryID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _territoryID, value); }
        } 
        public override EmployeeTerritoryKey GetKey()
        {
            return new EmployeeTerritoryKey(EmployeeID, TerritoryID);
        }

        

		public override bool IsNew()
		{
		    return EmployeeID == default(int)|| TerritoryID == default(int);
        }

		public override void MarkNew()
        {
            EmployeeID = default(int);
            TerritoryID = default(int);
        }
    } 
}
