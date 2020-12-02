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
	[DebuggerDisplay("Product" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindProduct : ClassicDataObject<int, Product>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static Product CreateProduct(int id)
        {
            return new Product {Id = id};
        }

        private int? _categoryID;
        private bool _discontinued;
        private string _productName;
        private string _quantityPerUnit;
        private short? _reorderLevel;
        private int? _supplierID;
        private decimal? _unitPrice;
        private short? _unitsInStock;
        private short? _unitsOnOrder;

        protected CodeBehindProduct()
		{
            _discontinued = false;
            _reorderLevel = 0;
            _unitsInStock = 0;
            _unitsOnOrder = 0;
		}

		protected CodeBehindProduct(Product origin)
		    :base(origin)
	    {
            _categoryID = origin._categoryID;
            _discontinued = origin._discontinued;
            _productName = origin._productName;
            _quantityPerUnit = origin._quantityPerUnit;
            _reorderLevel = origin._reorderLevel;
            _supplierID = origin._supplierID;
            _unitPrice = origin._unitPrice;
            _unitsInStock = origin._unitsInStock;
            _unitsOnOrder = origin._unitsOnOrder;
		}

		[Display(ResourceType = typeof(ObjectResources), Name = "Product_CategoryID")]
		public virtual int? CategoryID
        {
            [DebuggerStepThrough]
            get { return _categoryID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _categoryID, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "Product_Discontinued_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "Product_Discontinued")]
		public virtual bool Discontinued
        {
            [DebuggerStepThrough]
            get { return _discontinued; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _discontinued, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "Product_ProductName_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "Product_ProductName")]
		public virtual string ProductName
        {
            [DebuggerStepThrough]
            get { return _productName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _productName, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Product_QuantityPerUnit")]
		public virtual string QuantityPerUnit
        {
            [DebuggerStepThrough]
            get { return _quantityPerUnit; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _quantityPerUnit, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Product_ReorderLevel")]
		public virtual short? ReorderLevel
        {
            [DebuggerStepThrough]
            get { return _reorderLevel; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _reorderLevel, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Product_SupplierID")]
		public virtual int? SupplierID
        {
            [DebuggerStepThrough]
            get { return _supplierID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _supplierID, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Product_UnitPrice")]
		public virtual decimal? UnitPrice
        {
            [DebuggerStepThrough]
            get { return _unitPrice; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _unitPrice, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Product_UnitsInStock")]
		public virtual short? UnitsInStock
        {
            [DebuggerStepThrough]
            get { return _unitsInStock; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _unitsInStock, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Product_UnitsOnOrder")]
		public virtual short? UnitsOnOrder
        {
            [DebuggerStepThrough]
            get { return _unitsOnOrder; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _unitsOnOrder, value); }
        } 
    } 
}
