using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using BusinessFramework.Client.Contracts.DataObjects;
using BusinessFramework.Client.Contracts.DataObjects.Attributes;
using BusinessFramework.Client.Contracts.DataObjects.Validation;
using Northwind.Client.Contracts.Properties;


namespace Northwind.Client.Contracts.BusinessObjects.CodeBehind
{
    [Serializable]
	[DebuggerDisplay("OrderStatus" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindOrderStatus : ClassicDataObject<short, OrderStatus>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static OrderStatus CreateOrderStatus(short id)
        {
            return new OrderStatus {Id = id};
        }

        private string _name;

        protected CodeBehindOrderStatus()
		{
		}

		protected CodeBehindOrderStatus(OrderStatus origin)
		    :base(origin)
	    {
            _name = origin._name;
		}

		[Display(ResourceType = typeof(ObjectResources), Name = "OrderStatus_Name")]
		public virtual string Name
        {
            [DebuggerStepThrough]
            get { return _name; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _name, value); }
        } 
    } 
}
