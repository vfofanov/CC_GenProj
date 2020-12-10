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
	[DebuggerDisplay("OrderProductQuery" + " {"+ nameof(Id) +"}" + " {"+ nameof(OrderID) +"}" + " {"+ nameof(ProductID) +"}")]
	[TypeDisplay(typeof(QueryResources))]
	[Microsoft.OData.Client.Key(nameof(Id), nameof(OrderID), nameof(ProductID))]
    public abstract class CodeBehindOrderProductQuery : AbstractDataObject<OrderProductQueryKey, OrderProductQuery>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static OrderProductQuery CreateOrderProductQuery(int id, int orderID, int productID)
        {
            return new OrderProductQuery {Id = id, OrderID = orderID, ProductID = productID};
        }

        private int _id;
        private int _orderID;
        private int _productID;
        private float _discount;
        private int _orders_CustomerID;
        private int? _orders_EmployeeID;
        private decimal? _orders_Freight;
        private int _orders_Id;
        private DateTimeOffset? _orders_OrderDate;
        private DateTimeOffset? _orders_RequiredDate;
        private string _orders_ShipAddress;
        private string _orders_ShipCity;
        private string _orders_ShipCountry;
        private string _orders_ShipName;
        private DateTimeOffset? _orders_ShippedDate;
        private string _orders_ShipPostalCode;
        private string _orders_ShipRegion;
        private int? _orders_ShipVia;
        private int? _products_CategoryID;
        private bool _products_Discontinued;
        private int _products_Id;
        private string _products_ProductName;
        private string _products_QuantityPerUnit;
        private short? _products_ReorderLevel;
        private int? _products_SupplierID;
        private decimal? _products_UnitPrice;
        private short? _products_UnitsInStock;
        private short? _products_UnitsOnOrder;
        private short _quantity;
        private decimal _unitPrice;

        protected CodeBehindOrderProductQuery()
		{
		}

		protected CodeBehindOrderProductQuery(OrderProductQuery origin)
		    :base(origin)
	    {
            _id = origin._id;
            _orderID = origin._orderID;
            _productID = origin._productID;
            _discount = origin._discount;
            _orders_CustomerID = origin._orders_CustomerID;
            _orders_EmployeeID = origin._orders_EmployeeID;
            _orders_Freight = origin._orders_Freight;
            _orders_Id = origin._orders_Id;
            _orders_OrderDate = origin._orders_OrderDate;
            _orders_RequiredDate = origin._orders_RequiredDate;
            _orders_ShipAddress = origin._orders_ShipAddress;
            _orders_ShipCity = origin._orders_ShipCity;
            _orders_ShipCountry = origin._orders_ShipCountry;
            _orders_ShipName = origin._orders_ShipName;
            _orders_ShippedDate = origin._orders_ShippedDate;
            _orders_ShipPostalCode = origin._orders_ShipPostalCode;
            _orders_ShipRegion = origin._orders_ShipRegion;
            _orders_ShipVia = origin._orders_ShipVia;
            _products_CategoryID = origin._products_CategoryID;
            _products_Discontinued = origin._products_Discontinued;
            _products_Id = origin._products_Id;
            _products_ProductName = origin._products_ProductName;
            _products_QuantityPerUnit = origin._products_QuantityPerUnit;
            _products_ReorderLevel = origin._products_ReorderLevel;
            _products_SupplierID = origin._products_SupplierID;
            _products_UnitPrice = origin._products_UnitPrice;
            _products_UnitsInStock = origin._products_UnitsInStock;
            _products_UnitsOnOrder = origin._products_UnitsOnOrder;
            _quantity = origin._quantity;
            _unitPrice = origin._unitPrice;
		}

		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Id")]
		public virtual int Id
        {
            [DebuggerStepThrough]
            get { return _id; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _id, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_OrderID")]
		public virtual int OrderID
        {
            [DebuggerStepThrough]
            get { return _orderID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orderID, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_ProductID")]
		public virtual int ProductID
        {
            [DebuggerStepThrough]
            get { return _productID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _productID, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Discount")]
		public virtual float Discount
        {
            [DebuggerStepThrough]
            get { return _discount; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _discount, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Orders_CustomerID")]
		public virtual int Orders_CustomerID
        {
            [DebuggerStepThrough]
            get { return _orders_CustomerID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orders_CustomerID, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Orders_EmployeeID")]
		public virtual int? Orders_EmployeeID
        {
            [DebuggerStepThrough]
            get { return _orders_EmployeeID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orders_EmployeeID, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Orders_Freight")]
		public virtual decimal? Orders_Freight
        {
            [DebuggerStepThrough]
            get { return _orders_Freight; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orders_Freight, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Orders_Id")]
		public virtual int Orders_Id
        {
            [DebuggerStepThrough]
            get { return _orders_Id; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orders_Id, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Orders_OrderDate")]
		public virtual DateTimeOffset? Orders_OrderDate
        {
            [DebuggerStepThrough]
            get { return _orders_OrderDate; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orders_OrderDate, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Orders_RequiredDate")]
		public virtual DateTimeOffset? Orders_RequiredDate
        {
            [DebuggerStepThrough]
            get { return _orders_RequiredDate; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orders_RequiredDate, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Orders_ShipAddress")]
		public virtual string Orders_ShipAddress
        {
            [DebuggerStepThrough]
            get { return _orders_ShipAddress; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orders_ShipAddress, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Orders_ShipCity")]
		public virtual string Orders_ShipCity
        {
            [DebuggerStepThrough]
            get { return _orders_ShipCity; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orders_ShipCity, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Orders_ShipCountry")]
		public virtual string Orders_ShipCountry
        {
            [DebuggerStepThrough]
            get { return _orders_ShipCountry; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orders_ShipCountry, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Orders_ShipName")]
		public virtual string Orders_ShipName
        {
            [DebuggerStepThrough]
            get { return _orders_ShipName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orders_ShipName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Orders_ShippedDate")]
		public virtual DateTimeOffset? Orders_ShippedDate
        {
            [DebuggerStepThrough]
            get { return _orders_ShippedDate; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orders_ShippedDate, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Orders_ShipPostalCode")]
		public virtual string Orders_ShipPostalCode
        {
            [DebuggerStepThrough]
            get { return _orders_ShipPostalCode; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orders_ShipPostalCode, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Orders_ShipRegion")]
		public virtual string Orders_ShipRegion
        {
            [DebuggerStepThrough]
            get { return _orders_ShipRegion; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orders_ShipRegion, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Orders_ShipVia")]
		public virtual int? Orders_ShipVia
        {
            [DebuggerStepThrough]
            get { return _orders_ShipVia; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orders_ShipVia, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Products_CategoryID")]
		public virtual int? Products_CategoryID
        {
            [DebuggerStepThrough]
            get { return _products_CategoryID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _products_CategoryID, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Products_Discontinued")]
		public virtual bool Products_Discontinued
        {
            [DebuggerStepThrough]
            get { return _products_Discontinued; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _products_Discontinued, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Products_Id")]
		public virtual int Products_Id
        {
            [DebuggerStepThrough]
            get { return _products_Id; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _products_Id, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Products_ProductName")]
		public virtual string Products_ProductName
        {
            [DebuggerStepThrough]
            get { return _products_ProductName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _products_ProductName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Products_QuantityPerUnit")]
		public virtual string Products_QuantityPerUnit
        {
            [DebuggerStepThrough]
            get { return _products_QuantityPerUnit; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _products_QuantityPerUnit, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Products_ReorderLevel")]
		public virtual short? Products_ReorderLevel
        {
            [DebuggerStepThrough]
            get { return _products_ReorderLevel; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _products_ReorderLevel, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Products_SupplierID")]
		public virtual int? Products_SupplierID
        {
            [DebuggerStepThrough]
            get { return _products_SupplierID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _products_SupplierID, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Products_UnitPrice")]
		public virtual decimal? Products_UnitPrice
        {
            [DebuggerStepThrough]
            get { return _products_UnitPrice; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _products_UnitPrice, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Products_UnitsInStock")]
		public virtual short? Products_UnitsInStock
        {
            [DebuggerStepThrough]
            get { return _products_UnitsInStock; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _products_UnitsInStock, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Products_UnitsOnOrder")]
		public virtual short? Products_UnitsOnOrder
        {
            [DebuggerStepThrough]
            get { return _products_UnitsOnOrder; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _products_UnitsOnOrder, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_Quantity")]
		public virtual short Quantity
        {
            [DebuggerStepThrough]
            get { return _quantity; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _quantity, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "OrderProductQuery_UnitPrice")]
		public virtual decimal UnitPrice
        {
            [DebuggerStepThrough]
            get { return _unitPrice; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _unitPrice, value); }
        } 
        public override OrderProductQueryKey GetKey()
        {
            return new OrderProductQueryKey(Id, OrderID, ProductID);
        }

        

		public override bool IsNew()
		{
		    return Id == default(int)|| OrderID == default(int)|| ProductID == default(int);
        }

		public override void MarkNew()
        {
            Id = default(int);
            OrderID = default(int);
            ProductID = default(int);
        }
    } 
}
