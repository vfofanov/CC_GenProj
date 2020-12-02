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
	[DebuggerDisplay("Order" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindOrder : ClassicDataObject<int, Order>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static Order CreateOrder(int id)
        {
            return new Order {Id = id};
        }

        private int? _customerID;
        private int? _employeeID;
        private decimal? _freight;
        private DateTimeOffset? _orderDate;
        private DateTimeOffset? _requiredDate;
        private string _shipAddress;
        private string _shipCity;
        private string _shipCountry;
        private string _shipName;
        private DateTimeOffset? _shippedDate;
        private string _shipPostalCode;
        private string _shipRegion;
        private int? _shipVia;
        private short? _statusID;

        protected CodeBehindOrder()
		{
            _orderDate = DateTime.Now;
		}

		protected CodeBehindOrder(Order origin)
		    :base(origin)
	    {
            _customerID = origin._customerID;
            _employeeID = origin._employeeID;
            _freight = origin._freight;
            _orderDate = origin._orderDate;
            _requiredDate = origin._requiredDate;
            _shipAddress = origin._shipAddress;
            _shipCity = origin._shipCity;
            _shipCountry = origin._shipCountry;
            _shipName = origin._shipName;
            _shippedDate = origin._shippedDate;
            _shipPostalCode = origin._shipPostalCode;
            _shipRegion = origin._shipRegion;
            _shipVia = origin._shipVia;
            _statusID = origin._statusID;
		}

		[Display(ResourceType = typeof(ObjectResources), Name = "Order_CustomerID")]
		public virtual int? CustomerID
        {
            [DebuggerStepThrough]
            get { return _customerID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _customerID, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Order_EmployeeID")]
		public virtual int? EmployeeID
        {
            [DebuggerStepThrough]
            get { return _employeeID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employeeID, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Order_Freight")]
		public virtual decimal? Freight
        {
            [DebuggerStepThrough]
            get { return _freight; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _freight, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Order_OrderDate")]
		public virtual DateTimeOffset? OrderDate
        {
            [DebuggerStepThrough]
            get { return _orderDate; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orderDate, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Order_RequiredDate")]
		public virtual DateTimeOffset? RequiredDate
        {
            [DebuggerStepThrough]
            get { return _requiredDate; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _requiredDate, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Order_ShipAddress")]
		public virtual string ShipAddress
        {
            [DebuggerStepThrough]
            get { return _shipAddress; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shipAddress, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Order_ShipCity")]
		public virtual string ShipCity
        {
            [DebuggerStepThrough]
            get { return _shipCity; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shipCity, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Order_ShipCountry")]
		public virtual string ShipCountry
        {
            [DebuggerStepThrough]
            get { return _shipCountry; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shipCountry, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Order_ShipName")]
		public virtual string ShipName
        {
            [DebuggerStepThrough]
            get { return _shipName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shipName, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Order_ShippedDate")]
		public virtual DateTimeOffset? ShippedDate
        {
            [DebuggerStepThrough]
            get { return _shippedDate; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shippedDate, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Order_ShipPostalCode")]
		public virtual string ShipPostalCode
        {
            [DebuggerStepThrough]
            get { return _shipPostalCode; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shipPostalCode, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Order_ShipRegion")]
		public virtual string ShipRegion
        {
            [DebuggerStepThrough]
            get { return _shipRegion; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shipRegion, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Order_ShipVia")]
		public virtual int? ShipVia
        {
            [DebuggerStepThrough]
            get { return _shipVia; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shipVia, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Order_StatusID")]
		public virtual short? StatusID
        {
            [DebuggerStepThrough]
            get { return _statusID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _statusID, value); }
        } 
    } 
}
