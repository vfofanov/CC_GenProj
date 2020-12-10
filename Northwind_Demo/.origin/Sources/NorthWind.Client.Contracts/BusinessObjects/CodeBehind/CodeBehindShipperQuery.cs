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
	[DebuggerDisplay("ShipperQuery" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(QueryResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindShipperQuery : ClassicDataObject<int, ShipperQuery>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static ShipperQuery CreateShipperQuery(int id)
        {
            return new ShipperQuery {Id = id};
        }

        private string _companyName;
        private string _phone;

        protected CodeBehindShipperQuery()
		{
		}

		protected CodeBehindShipperQuery(ShipperQuery origin)
		    :base(origin)
	    {
            _companyName = origin._companyName;
            _phone = origin._phone;
		}

		[Display(ResourceType = typeof(QueryResources), Name = "ShipperQuery_CompanyName")]
		public virtual string CompanyName
        {
            [DebuggerStepThrough]
            get { return _companyName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _companyName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ShipperQuery_Phone")]
		public virtual string Phone
        {
            [DebuggerStepThrough]
            get { return _phone; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _phone, value); }
        } 
    } 
}
