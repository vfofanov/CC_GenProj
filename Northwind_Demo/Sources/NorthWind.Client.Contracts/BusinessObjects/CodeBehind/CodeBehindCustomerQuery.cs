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
	[DebuggerDisplay("CustomerQuery" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(QueryResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindCustomerQuery : ClassicDataObject<int, CustomerQuery>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static CustomerQuery CreateCustomerQuery(int id)
        {
            return new CustomerQuery {Id = id};
        }

        private string _address;
        private string _city;
        private string _companyName;
        private string _contactName;
        private string _contactTitle;
        private string _country;
        private string _fax;
        private string _phone;
        private string _postalCode;
        private string _region;

        protected CodeBehindCustomerQuery()
		{
		}

		protected CodeBehindCustomerQuery(CustomerQuery origin)
		    :base(origin)
	    {
            _address = origin._address;
            _city = origin._city;
            _companyName = origin._companyName;
            _contactName = origin._contactName;
            _contactTitle = origin._contactTitle;
            _country = origin._country;
            _fax = origin._fax;
            _phone = origin._phone;
            _postalCode = origin._postalCode;
            _region = origin._region;
		}

		[Display(ResourceType = typeof(QueryResources), Name = "CustomerQuery_Address")]
		public virtual string Address
        {
            [DebuggerStepThrough]
            get { return _address; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _address, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "CustomerQuery_City")]
		public virtual string City
        {
            [DebuggerStepThrough]
            get { return _city; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _city, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "CustomerQuery_CompanyName")]
		public virtual string CompanyName
        {
            [DebuggerStepThrough]
            get { return _companyName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _companyName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "CustomerQuery_ContactName")]
		public virtual string ContactName
        {
            [DebuggerStepThrough]
            get { return _contactName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _contactName, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "CustomerQuery_ContactTitle")]
		public virtual string ContactTitle
        {
            [DebuggerStepThrough]
            get { return _contactTitle; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _contactTitle, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "CustomerQuery_Country")]
		public virtual string Country
        {
            [DebuggerStepThrough]
            get { return _country; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _country, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "CustomerQuery_Fax")]
		public virtual string Fax
        {
            [DebuggerStepThrough]
            get { return _fax; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _fax, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "CustomerQuery_Phone")]
		public virtual string Phone
        {
            [DebuggerStepThrough]
            get { return _phone; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _phone, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "CustomerQuery_PostalCode")]
		public virtual string PostalCode
        {
            [DebuggerStepThrough]
            get { return _postalCode; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _postalCode, value); }
        } 
		[Display(ResourceType = typeof(QueryResources), Name = "CustomerQuery_Region")]
		public virtual string Region
        {
            [DebuggerStepThrough]
            get { return _region; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _region, value); }
        } 
    } 
}
