using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using BusinessFramework.Client.Contracts.DataObjects;
using BusinessFramework.Client.Contracts.DataObjects.Attributes;
using BusinessFramework.Client.Contracts.DataObjects.Validation;
using BusinessFramework.Client.Contracts.Files;
using NorthWind.Client.Contracts.Properties;


namespace NorthWind.Client.Contracts.BusinessObjects.CodeBehind
{
    [Serializable]
	[DebuggerDisplay("Employees" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindEmployees : ClassicDataObject<int, Employees>, IFileLinkContainer
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static Employees CreateEmployees(int id)
        {
            return new Employees {Id = id};
        }

        private string _address;
        private DateTimeOffset? _birthDate;
        private string _city;
        private string _country;
        private FileLink _documentScanFileId;
        private string _extension;
        private string _firstName;
        private DateTimeOffset? _hireDate;
        private string _homePhone;
        private string _lastName;
        private string _notes;
        private byte[] _photo;
        private string _photoPath;
        private string _postalCode;
        private string _region;
        private int? _reportsTo;
        private string _title;
        private string _titleOfCourtesy;

        protected CodeBehindEmployees()
		{
		}

		protected CodeBehindEmployees(Employees origin)
		    :base(origin)
	    {
            _address = origin._address;
            _birthDate = origin._birthDate;
            _city = origin._city;
            _country = origin._country;
            _documentScanFileId = origin._documentScanFileId;
            _extension = origin._extension;
            _firstName = origin._firstName;
            _hireDate = origin._hireDate;
            _homePhone = origin._homePhone;
            _lastName = origin._lastName;
            _notes = origin._notes;
            _photo = origin._photo;
            _photoPath = origin._photoPath;
            _postalCode = origin._postalCode;
            _region = origin._region;
            _reportsTo = origin._reportsTo;
            _title = origin._title;
            _titleOfCourtesy = origin._titleOfCourtesy;
		}

		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_Address")]
		public virtual string Address
        {
            [DebuggerStepThrough]
            get { return _address; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _address, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_BirthDate")]
		public virtual DateTimeOffset? BirthDate
        {
            [DebuggerStepThrough]
            get { return _birthDate; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _birthDate, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_City")]
		public virtual string City
        {
            [DebuggerStepThrough]
            get { return _city; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _city, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_Country")]
		public virtual string Country
        {
            [DebuggerStepThrough]
            get { return _country; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _country, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_DocumentScanFileId")]
		public virtual FileLink DocumentScanFileId
        {
            [DebuggerStepThrough]
            get { return _documentScanFileId; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _documentScanFileId, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_Extension")]
		public virtual string Extension
        {
            [DebuggerStepThrough]
            get { return _extension; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _extension, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "Employees_FirstName_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_FirstName")]
		public virtual string FirstName
        {
            [DebuggerStepThrough]
            get { return _firstName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _firstName, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_HireDate")]
		public virtual DateTimeOffset? HireDate
        {
            [DebuggerStepThrough]
            get { return _hireDate; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _hireDate, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_HomePhone")]
		public virtual string HomePhone
        {
            [DebuggerStepThrough]
            get { return _homePhone; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _homePhone, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "Employees_LastName_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_LastName")]
		public virtual string LastName
        {
            [DebuggerStepThrough]
            get { return _lastName; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _lastName, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_Notes")]
		public virtual string Notes
        {
            [DebuggerStepThrough]
            get { return _notes; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _notes, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_Photo")]
		public virtual byte[] Photo
        {
            [DebuggerStepThrough]
            get { return _photo; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _photo, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_PhotoPath")]
		public virtual string PhotoPath
        {
            [DebuggerStepThrough]
            get { return _photoPath; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _photoPath, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_PostalCode")]
		public virtual string PostalCode
        {
            [DebuggerStepThrough]
            get { return _postalCode; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _postalCode, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_Region")]
		public virtual string Region
        {
            [DebuggerStepThrough]
            get { return _region; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _region, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_ReportsTo")]
		public virtual int? ReportsTo
        {
            [DebuggerStepThrough]
            get { return _reportsTo; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _reportsTo, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_Title")]
		public virtual string Title
        {
            [DebuggerStepThrough]
            get { return _title; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _title, value); }
        } 
		[Display(ResourceType = typeof(ObjectResources), Name = "Employees_TitleOfCourtesy")]
		public virtual string TitleOfCourtesy
        {
            [DebuggerStepThrough]
            get { return _titleOfCourtesy; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _titleOfCourtesy, value); }
        } 
        

        public IEnumerable<FileLink> GetFileLinks()
        {
               if (DocumentScanFileId != null)
               {
                   yield return DocumentScanFileId;
               }

        }
    } 
}
