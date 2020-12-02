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
	[DebuggerDisplay("QCategories" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(QueryResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindQCategories : ClassicDataObject<int, QCategories>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static QCategories CreateQCategories(int id)
        {
            return new QCategories {Id = id};
        }

        private string _categoryName;
        private string _description;
        private byte[] _picture;

        protected CodeBehindQCategories()
		{
		}

		protected CodeBehindQCategories(QCategories origin)
		    :base(origin)
	    {
            _categoryName = origin._categoryName;
            _description = origin._description;
            _picture = origin._picture;
		}

		[Display(ResourceType = typeof(QueryResources), Name = "qCategories_CategoryName")]
		public virtual string CategoryName
        {
            [DebuggerStepThrough]
            get { return _categoryName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _categoryName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qCategories_Description")]
		public virtual string Description
        {
            [DebuggerStepThrough]
            get { return _description; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _description, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qCategories_Picture")]
		public virtual byte[] Picture
        {
            [DebuggerStepThrough]
            get { return _picture; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _picture, value); }
        } 
    } 
}
