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
	[DebuggerDisplay("ProductQuery" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(QueryResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindProductQuery : ClassicDataObject<int, ProductQuery>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static ProductQuery CreateProductQuery(int id)
        {
            return new ProductQuery {Id = id};
        }

        private string _categories_CategoryName;
        private string _categories_Description;
        private int? _categories_Id;
        private int? _categoryID;
        private bool _discontinued;
        private string _productName;
        private string _quantityPerUnit;
        private short? _reorderLevel;
        private int? _supplierID;
        private string _suppliers_Address;
        private string _suppliers_City;
        private string _suppliers_CompanyName;
        private string _suppliers_ContactName;
        private string _suppliers_ContactTitle;
        private string _suppliers_Country;
        private string _suppliers_Fax;
        private string _suppliers_HomePage;
        private int? _suppliers_Id;
        private string _suppliers_Phone;
        private string _suppliers_PostalCode;
        private string _suppliers_Region;
        private decimal? _unitPrice;
        private short? _unitsInStock;
        private short? _unitsOnOrder;

        protected CodeBehindProductQuery()
		{
		}

		protected CodeBehindProductQuery(ProductQuery origin)
		    :base(origin)
	    {
            _categories_CategoryName = origin._categories_CategoryName;
            _categories_Description = origin._categories_Description;
            _categories_Id = origin._categories_Id;
            _categoryID = origin._categoryID;
            _discontinued = origin._discontinued;
            _productName = origin._productName;
            _quantityPerUnit = origin._quantityPerUnit;
            _reorderLevel = origin._reorderLevel;
            _supplierID = origin._supplierID;
            _suppliers_Address = origin._suppliers_Address;
            _suppliers_City = origin._suppliers_City;
            _suppliers_CompanyName = origin._suppliers_CompanyName;
            _suppliers_ContactName = origin._suppliers_ContactName;
            _suppliers_ContactTitle = origin._suppliers_ContactTitle;
            _suppliers_Country = origin._suppliers_Country;
            _suppliers_Fax = origin._suppliers_Fax;
            _suppliers_HomePage = origin._suppliers_HomePage;
            _suppliers_Id = origin._suppliers_Id;
            _suppliers_Phone = origin._suppliers_Phone;
            _suppliers_PostalCode = origin._suppliers_PostalCode;
            _suppliers_Region = origin._suppliers_Region;
            _unitPrice = origin._unitPrice;
            _unitsInStock = origin._unitsInStock;
            _unitsOnOrder = origin._unitsOnOrder;
		}

		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_Categories_CategoryName")]
		public virtual string Categories_CategoryName
        {
            [DebuggerStepThrough]
            get { return _categories_CategoryName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _categories_CategoryName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_Categories_Description")]
		public virtual string Categories_Description
        {
            [DebuggerStepThrough]
            get { return _categories_Description; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _categories_Description, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_Categories_Id")]
		public virtual int? Categories_Id
        {
            [DebuggerStepThrough]
            get { return _categories_Id; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _categories_Id, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_CategoryID")]
		public virtual int? CategoryID
        {
            [DebuggerStepThrough]
            get { return _categoryID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _categoryID, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_Discontinued")]
		public virtual bool Discontinued
        {
            [DebuggerStepThrough]
            get { return _discontinued; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _discontinued, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_ProductName")]
		public virtual string ProductName
        {
            [DebuggerStepThrough]
            get { return _productName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _productName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_QuantityPerUnit")]
		public virtual string QuantityPerUnit
        {
            [DebuggerStepThrough]
            get { return _quantityPerUnit; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _quantityPerUnit, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_ReorderLevel")]
		public virtual short? ReorderLevel
        {
            [DebuggerStepThrough]
            get { return _reorderLevel; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _reorderLevel, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_SupplierID")]
		public virtual int? SupplierID
        {
            [DebuggerStepThrough]
            get { return _supplierID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _supplierID, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_Suppliers_Address")]
		public virtual string Suppliers_Address
        {
            [DebuggerStepThrough]
            get { return _suppliers_Address; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _suppliers_Address, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_Suppliers_City")]
		public virtual string Suppliers_City
        {
            [DebuggerStepThrough]
            get { return _suppliers_City; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _suppliers_City, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_Suppliers_CompanyName")]
		public virtual string Suppliers_CompanyName
        {
            [DebuggerStepThrough]
            get { return _suppliers_CompanyName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _suppliers_CompanyName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_Suppliers_ContactName")]
		public virtual string Suppliers_ContactName
        {
            [DebuggerStepThrough]
            get { return _suppliers_ContactName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _suppliers_ContactName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_Suppliers_ContactTitle")]
		public virtual string Suppliers_ContactTitle
        {
            [DebuggerStepThrough]
            get { return _suppliers_ContactTitle; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _suppliers_ContactTitle, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_Suppliers_Country")]
		public virtual string Suppliers_Country
        {
            [DebuggerStepThrough]
            get { return _suppliers_Country; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _suppliers_Country, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_Suppliers_Fax")]
		public virtual string Suppliers_Fax
        {
            [DebuggerStepThrough]
            get { return _suppliers_Fax; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _suppliers_Fax, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_Suppliers_HomePage")]
		public virtual string Suppliers_HomePage
        {
            [DebuggerStepThrough]
            get { return _suppliers_HomePage; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _suppliers_HomePage, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_Suppliers_Id")]
		public virtual int? Suppliers_Id
        {
            [DebuggerStepThrough]
            get { return _suppliers_Id; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _suppliers_Id, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_Suppliers_Phone")]
		public virtual string Suppliers_Phone
        {
            [DebuggerStepThrough]
            get { return _suppliers_Phone; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _suppliers_Phone, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_Suppliers_PostalCode")]
		public virtual string Suppliers_PostalCode
        {
            [DebuggerStepThrough]
            get { return _suppliers_PostalCode; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _suppliers_PostalCode, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_Suppliers_Region")]
		public virtual string Suppliers_Region
        {
            [DebuggerStepThrough]
            get { return _suppliers_Region; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _suppliers_Region, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_UnitPrice")]
		public virtual decimal? UnitPrice
        {
            [DebuggerStepThrough]
            get { return _unitPrice; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _unitPrice, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_UnitsInStock")]
		public virtual short? UnitsInStock
        {
            [DebuggerStepThrough]
            get { return _unitsInStock; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _unitsInStock, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "ProductQuery_UnitsOnOrder")]
		public virtual short? UnitsOnOrder
        {
            [DebuggerStepThrough]
            get { return _unitsOnOrder; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _unitsOnOrder, value); }
        } 
    } 
}
