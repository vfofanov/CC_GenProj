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
	[DebuggerDisplay("QShippers" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(QueryResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindQShippers : ClassicDataObject<int, QShippers>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static QShippers CreateQShippers(int id)
        {
            return new QShippers {Id = id};
        }

        private string _companyName;
        private string _phone;

        protected CodeBehindQShippers()
		{
		}

		protected CodeBehindQShippers(QShippers origin)
		    :base(origin)
	    {
            _companyName = origin._companyName;
            _phone = origin._phone;
		}

		[Display(ResourceType = typeof(QueryResources), Name = "qShippers_CompanyName")]
		public virtual string CompanyName
        {
            [DebuggerStepThrough]
            get { return _companyName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _companyName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "qShippers_Phone")]
		public virtual string Phone
        {
            [DebuggerStepThrough]
            get { return _phone; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _phone, value); }
        } 
    } 
}
