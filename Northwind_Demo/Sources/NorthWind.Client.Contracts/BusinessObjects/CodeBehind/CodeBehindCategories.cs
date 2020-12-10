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
	[DebuggerDisplay("Categories" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindCategories : ClassicDataObject<int, Categories>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static Categories CreateCategories(int id)
        {
            return new Categories {Id = id};
        }

        private string _categoryName;
        private string _description;
        private byte[] _picture;

        protected CodeBehindCategories()
		{
		}

		protected CodeBehindCategories(Categories origin)
		    :base(origin)
	    {
            _categoryName = origin._categoryName;
            _description = origin._description;
            _picture = origin._picture;
		}

        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "Categories_CategoryName_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "Categories_CategoryName")]
		public virtual string CategoryName
        {
            [DebuggerStepThrough]
            get { return _categoryName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _categoryName, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Categories_Description")]
		public virtual string Description
        {
            [DebuggerStepThrough]
            get { return _description; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _description, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Categories_Picture")]
		public virtual byte[] Picture
        {
            [DebuggerStepThrough]
            get { return _picture; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _picture, value); }
        } 
    } 
}
