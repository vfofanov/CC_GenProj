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
	[DebuggerDisplay("OrderDetail" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindOrderDetail : ClassicDataObject<int, OrderDetail>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static OrderDetail CreateOrderDetail(int id)
        {
            return new OrderDetail {Id = id};
        }

        private float _discount;
        private int _orderID;
        private int _productID;
        private short _quantity;
        private decimal _unitPrice;

        protected CodeBehindOrderDetail()
		{
            _discount = 0;
            _quantity = 1;
		}

		protected CodeBehindOrderDetail(OrderDetail origin)
		    :base(origin)
	    {
            _discount = origin._discount;
            _orderID = origin._orderID;
            _productID = origin._productID;
            _quantity = origin._quantity;
            _unitPrice = origin._unitPrice;
		}

        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "OrderDetail_Discount_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "OrderDetail_Discount")]
		public virtual float Discount
        {
            [DebuggerStepThrough]
            get { return _discount; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _discount, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "OrderDetail_OrderID_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "OrderDetail_OrderID")]
		public virtual int OrderID
        {
            [DebuggerStepThrough]
            get { return _orderID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orderID, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "OrderDetail_ProductID_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "OrderDetail_ProductID")]
		public virtual int ProductID
        {
            [DebuggerStepThrough]
            get { return _productID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _productID, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "OrderDetail_Quantity_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "OrderDetail_Quantity")]
		public virtual short Quantity
        {
            [DebuggerStepThrough]
            get { return _quantity; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _quantity, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "OrderDetail_UnitPrice_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "OrderDetail_UnitPrice")]
		public virtual decimal UnitPrice
        {
            [DebuggerStepThrough]
            get { return _unitPrice; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _unitPrice, value); }
        } 
    } 
}
