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
	[DebuggerDisplay("OrderDetails" + " {"+ nameof(OrderID) +"}" + " {"+ nameof(ProductID) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(OrderID), nameof(ProductID))]
    public abstract class CodeBehindOrderDetails : AbstractDataObject<OrderDetailsKey, OrderDetails>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static OrderDetails CreateOrderDetails(int orderID, int productID)
        {
            return new OrderDetails {OrderID = orderID, ProductID = productID};
        }

        private int _orderID;
        private int _productID;
        private float _discount;
        private short _quantity;
        private decimal _unitPrice;

        protected CodeBehindOrderDetails()
		{
            _discount = 0;
            _quantity = 1;
		}

		protected CodeBehindOrderDetails(OrderDetails origin)
		    :base(origin)
	    {
            _orderID = origin._orderID;
            _productID = origin._productID;
            _discount = origin._discount;
            _quantity = origin._quantity;
            _unitPrice = origin._unitPrice;
		}

        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "OrderDetails_OrderID_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "OrderDetails_OrderID")]
		public virtual int OrderID
        {
            [DebuggerStepThrough]
            get { return _orderID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _orderID, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "OrderDetails_ProductID_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "OrderDetails_ProductID")]
		public virtual int ProductID
        {
            [DebuggerStepThrough]
            get { return _productID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _productID, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "OrderDetails_Discount_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "OrderDetails_Discount")]
		public virtual float Discount
        {
            [DebuggerStepThrough]
            get { return _discount; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _discount, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "OrderDetails_Quantity_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "OrderDetails_Quantity")]
		public virtual short Quantity
        {
            [DebuggerStepThrough]
            get { return _quantity; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _quantity, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "OrderDetails_UnitPrice_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "OrderDetails_UnitPrice")]
		public virtual decimal UnitPrice
        {
            [DebuggerStepThrough]
            get { return _unitPrice; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _unitPrice, value); }
        } 
        public override OrderDetailsKey GetKey()
        {
            return new OrderDetailsKey(OrderID, ProductID);
        }

        

		public override bool IsNew()
		{
		    return OrderID == default(int)|| ProductID == default(int);
        }

		public override void MarkNew()
        {
            OrderID = default(int);
            ProductID = default(int);
        }
    } 
}
