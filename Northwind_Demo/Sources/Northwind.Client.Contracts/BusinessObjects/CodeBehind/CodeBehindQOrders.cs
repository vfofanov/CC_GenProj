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
	[DebuggerDisplay("QOrders" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(QueryResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindQOrders : ClassicDataObject<int, QOrders>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static QOrders CreateQOrders(int id)
        {
            return new QOrders {Id = id};
        }

        private int? _customerID;
        private string _customers_Address;
        private string _customers_City;
        private string _customers_CompanyName;
        private string _customers_ContactName;
        private string _customers_ContactTitle;
        private string _customers_Country;
        private string _customers_Fax;
        private int? _customers_Id;
        private string _customers_Phone;
        private string _customers_PostalCode;
        private string _customers_Region;
        private string _employeeFullName;
        private int? _employeeID;
        private string _employees_Address;
        private DateTimeOffset? _employees_BirthDate;
        private string _employees_City;
        private string _employees_Country;
        private string _employees_Extension;
        private string _employees_FirstName;
        private DateTimeOffset? _employees_HireDate;
        private string _employees_HomePhone;
        private int? _employees_Id;
        private string _employees_LastName;
        private string _employees_Notes;
        private string _employees_PhotoPath;
        private string _employees_PostalCode;
        private string _employees_Region;
        private int? _employees_ReportsTo;
        private string _employees_Title;
        private string _employees_TitleOfCourtesy;
        private decimal? _freight;
        private DateTimeOffset? _orderDate;
        private DateTimeOffset? _requiredDate;
        private string _shipAddress;
        private string _shipCity;
        private string _shipCountry;
        private string _shipName;
        private DateTimeOffset? _shippedDate;
        private string _shippers_CompanyName;
        private int? _shippers_Id;
        private string _shippers_Phone;
        private string _shipPostalCode;
        private string _shipRegion;
        private int? _shipVia;

        protected CodeBehindQOrders()
		{
		}

		protected CodeBehindQOrders(QOrders origin)
		    :base(origin)
	    {
            _customerID = origin._customerID;
            _customers_Address = origin._customers_Address;
            _customers_City = origin._customers_City;
            _customers_CompanyName = origin._customers_CompanyName;
            _customers_ContactName = origin._customers_ContactName;
            _customers_ContactTitle = origin._customers_ContactTitle;
            _customers_Country = origin._customers_Country;
            _customers_Fax = origin._customers_Fax;
            _customers_Id = origin._customers_Id;
            _customers_Phone = origin._customers_Phone;
            _customers_PostalCode = origin._customers_PostalCode;
            _customers_Region = origin._customers_Region;
            _employeeFullName = origin._employeeFullName;
            _employeeID = origin._employeeID;
            _employees_Address = origin._employees_Address;
            _employees_BirthDate = origin._employees_BirthDate;
            _employees_City = origin._employees_City;
            _employees_Country = origin._employees_Country;
            _employees_Extension = origin._employees_Extension;
            _employees_FirstName = origin._employees_FirstName;
            _employees_HireDate = origin._employees_HireDate;
            _employees_HomePhone = origin._employees_HomePhone;
            _employees_Id = origin._employees_Id;
            _employees_LastName = origin._employees_LastName;
            _employees_Notes = origin._employees_Notes;
            _employees_PhotoPath = origin._employees_PhotoPath;
            _employees_PostalCode = origin._employees_PostalCode;
            _employees_Region = origin._employees_Region;
            _employees_ReportsTo = origin._employees_ReportsTo;
            _employees_Title = origin._employees_Title;
            _employees_TitleOfCourtesy = origin._employees_TitleOfCourtesy;
            _freight = origin._freight;
            _orderDate = origin._orderDate;
            _requiredDate = origin._requiredDate;
            _shipAddress = origin._shipAddress;
            _shipCity = origin._shipCity;
            _shipCountry = origin._shipCountry;
            _shipName = origin._shipName;
            _shippedDate = origin._shippedDate;
            _shippers_CompanyName = origin._shippers_CompanyName;
            _shippers_Id = origin._shippers_Id;
            _shippers_Phone = origin._shippers_Phone;
            _shipPostalCode = origin._shipPostalCode;
            _shipRegion = origin._shipRegion;
            _shipVia = origin._shipVia;
		}

		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_CustomerID")]
		public virtual int? CustomerID
        {
            [DebuggerStepThrough]
            get { return _customerID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _customerID, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Customers_Address")]
		public virtual string Customers_Address
        {
            [DebuggerStepThrough]
            get { return _customers_Address; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _customers_Address, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Customers_City")]
		public virtual string Customers_City
        {
            [DebuggerStepThrough]
            get { return _customers_City; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _customers_City, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Customers_CompanyName")]
		public virtual string Customers_CompanyName
        {
            [DebuggerStepThrough]
            get { return _customers_CompanyName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _customers_CompanyName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Customers_ContactName")]
		public virtual string Customers_ContactName
        {
            [DebuggerStepThrough]
            get { return _customers_ContactName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _customers_ContactName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Customers_ContactTitle")]
		public virtual string Customers_ContactTitle
        {
            [DebuggerStepThrough]
            get { return _customers_ContactTitle; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _customers_ContactTitle, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Customers_Country")]
		public virtual string Customers_Country
        {
            [DebuggerStepThrough]
            get { return _customers_Country; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _customers_Country, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Customers_Fax")]
		public virtual string Customers_Fax
        {
            [DebuggerStepThrough]
            get { return _customers_Fax; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _customers_Fax, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Customers_Id")]
		public virtual int? Customers_Id
        {
            [DebuggerStepThrough]
            get { return _customers_Id; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _customers_Id, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Customers_Phone")]
		public virtual string Customers_Phone
        {
            [DebuggerStepThrough]
            get { return _customers_Phone; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _customers_Phone, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Customers_PostalCode")]
		public virtual string Customers_PostalCode
        {
            [DebuggerStepThrough]
            get { return _customers_PostalCode; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _customers_PostalCode, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Customers_Region")]
		public virtual string Customers_Region
        {
            [DebuggerStepThrough]
            get { return _customers_Region; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _customers_Region, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_EmployeeFullName")]
		public virtual string EmployeeFullName
        {
            [DebuggerStepThrough]
            get { return _employeeFullName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employeeFullName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_EmployeeID")]
		public virtual int? EmployeeID
        {
            [DebuggerStepThrough]
            get { return _employeeID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employeeID, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Employees_Address")]
		public virtual string Employees_Address
        {
            [DebuggerStepThrough]
            get { return _employees_Address; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employees_Address, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Employees_BirthDate")]
		public virtual DateTimeOffset? Employees_BirthDate
        {
            [DebuggerStepThrough]
            get { return _employees_BirthDate; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employees_BirthDate, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Employees_City")]
		public virtual string Employees_City
        {
            [DebuggerStepThrough]
            get { return _employees_City; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employees_City, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Employees_Country")]
		public virtual string Employees_Country
        {
            [DebuggerStepThrough]
            get { return _employees_Country; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employees_Country, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Employees_Extension")]
		public virtual string Employees_Extension
        {
            [DebuggerStepThrough]
            get { return _employees_Extension; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employees_Extension, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Employees_FirstName")]
		public virtual string Employees_FirstName
        {
            [DebuggerStepThrough]
            get { return _employees_FirstName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employees_FirstName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Employees_HireDate")]
		public virtual DateTimeOffset? Employees_HireDate
        {
            [DebuggerStepThrough]
            get { return _employees_HireDate; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employees_HireDate, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Employees_HomePhone")]
		public virtual string Employees_HomePhone
        {
            [DebuggerStepThrough]
            get { return _employees_HomePhone; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employees_HomePhone, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Employees_Id")]
		public virtual int? Employees_Id
        {
            [DebuggerStepThrough]
            get { return _employees_Id; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employees_Id, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Employees_LastName")]
		public virtual string Employees_LastName
        {
            [DebuggerStepThrough]
            get { return _employees_LastName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employees_LastName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Employees_Notes")]
		public virtual string Employees_Notes
        {
            [DebuggerStepThrough]
            get { return _employees_Notes; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employees_Notes, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Employees_PhotoPath")]
		public virtual string Employees_PhotoPath
        {
            [DebuggerStepThrough]
            get { return _employees_PhotoPath; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employees_PhotoPath, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Employees_PostalCode")]
		public virtual string Employees_PostalCode
        {
            [DebuggerStepThrough]
            get { return _employees_PostalCode; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employees_PostalCode, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Employees_Region")]
		public virtual string Employees_Region
        {
            [DebuggerStepThrough]
            get { return _employees_Region; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employees_Region, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Employees_ReportsTo")]
		public virtual int? Employees_ReportsTo
        {
            [DebuggerStepThrough]
            get { return _employees_ReportsTo; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employees_ReportsTo, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Employees_Title")]
		public virtual string Employees_Title
        {
            [DebuggerStepThrough]
            get { return _employees_Title; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employees_Title, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Employees_TitleOfCourtesy")]
		public virtual string Employees_TitleOfCourtesy
        {
            [DebuggerStepThrough]
            get { return _employees_TitleOfCourtesy; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _employees_TitleOfCourtesy, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Freight")]
		public virtual decimal? Freight
        {
            [DebuggerStepThrough]
            get { return _freight; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _freight, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_OrderDate")]
		public virtual DateTimeOffset? OrderDate
        {
            [DebuggerStepThrough]
            get { return _orderDate; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orderDate, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_RequiredDate")]
		public virtual DateTimeOffset? RequiredDate
        {
            [DebuggerStepThrough]
            get { return _requiredDate; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _requiredDate, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_ShipAddress")]
		public virtual string ShipAddress
        {
            [DebuggerStepThrough]
            get { return _shipAddress; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shipAddress, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_ShipCity")]
		public virtual string ShipCity
        {
            [DebuggerStepThrough]
            get { return _shipCity; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shipCity, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_ShipCountry")]
		public virtual string ShipCountry
        {
            [DebuggerStepThrough]
            get { return _shipCountry; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shipCountry, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_ShipName")]
		public virtual string ShipName
        {
            [DebuggerStepThrough]
            get { return _shipName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shipName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_ShippedDate")]
		public virtual DateTimeOffset? ShippedDate
        {
            [DebuggerStepThrough]
            get { return _shippedDate; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shippedDate, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Shippers_CompanyName")]
		public virtual string Shippers_CompanyName
        {
            [DebuggerStepThrough]
            get { return _shippers_CompanyName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shippers_CompanyName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Shippers_Id")]
		public virtual int? Shippers_Id
        {
            [DebuggerStepThrough]
            get { return _shippers_Id; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shippers_Id, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_Shippers_Phone")]
		public virtual string Shippers_Phone
        {
            [DebuggerStepThrough]
            get { return _shippers_Phone; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shippers_Phone, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_ShipPostalCode")]
		public virtual string ShipPostalCode
        {
            [DebuggerStepThrough]
            get { return _shipPostalCode; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shipPostalCode, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_ShipRegion")]
		public virtual string ShipRegion
        {
            [DebuggerStepThrough]
            get { return _shipRegion; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shipRegion, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qOrders_ShipVia")]
		public virtual int? ShipVia
        {
            [DebuggerStepThrough]
            get { return _shipVia; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _shipVia, value); }
        } 
    } 
}
