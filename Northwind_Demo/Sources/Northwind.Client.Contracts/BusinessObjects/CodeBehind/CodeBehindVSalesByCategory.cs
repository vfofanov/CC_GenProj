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
	[DebuggerDisplay("VSalesByCategory" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindVSalesByCategory : ClassicDataObject<int, VSalesByCategory>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static VSalesByCategory CreateVSalesByCategory(int id)
        {
            return new VSalesByCategory {Id = id};
        }

        private string _categoryName;
        private string _productName;
        private decimal? _productSales;

        protected CodeBehindVSalesByCategory()
		{
		}

		protected CodeBehindVSalesByCategory(VSalesByCategory origin)
		    :base(origin)
	    {
            _categoryName = origin._categoryName;
            _productName = origin._productName;
            _productSales = origin._productSales;
		}

        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "VSalesByCategory_CategoryName_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "VSalesByCategory_CategoryName")]
		public virtual string CategoryName
        {
            [DebuggerStepThrough]
            get { return _categoryName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _categoryName, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "VSalesByCategory_ProductName_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "VSalesByCategory_ProductName")]
		public virtual string ProductName
        {
            [DebuggerStepThrough]
            get { return _productName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _productName, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "VSalesByCategory_ProductSales")]
		public virtual decimal? ProductSales
        {
            [DebuggerStepThrough]
            get { return _productSales; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _productSales, value); }
        } 
    } 
}
