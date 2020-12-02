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
	[DebuggerDisplay("Category" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindCategory : ClassicDataObject<int, Category>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static Category CreateCategory(int id)
        {
            return new Category {Id = id};
        }

        private string _categoryName;
        private string _description;
        private byte[] _picture;

        protected CodeBehindCategory()
		{
		}

		protected CodeBehindCategory(Category origin)
		    :base(origin)
	    {
            _categoryName = origin._categoryName;
            _description = origin._description;
            _picture = origin._picture;
		}

        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "Category_CategoryName_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "Category_CategoryName")]
		public virtual string CategoryName
        {
            [DebuggerStepThrough]
            get { return _categoryName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _categoryName, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Category_Description")]
		public virtual string Description
        {
            [DebuggerStepThrough]
            get { return _description; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _description, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Category_Picture")]
		public virtual byte[] Picture
        {
            [DebuggerStepThrough]
            get { return _picture; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _picture, value); }
        } 
    } 
}
