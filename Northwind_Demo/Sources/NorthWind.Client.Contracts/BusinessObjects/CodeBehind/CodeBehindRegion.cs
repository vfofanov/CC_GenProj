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
	[DebuggerDisplay("Region" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindRegion : ClassicDataObject<int, Region>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static Region CreateRegion(int id)
        {
            return new Region {Id = id};
        }

        private string _regionDescription;

        protected CodeBehindRegion()
		{
		}

		protected CodeBehindRegion(Region origin)
		    :base(origin)
	    {
            _regionDescription = origin._regionDescription;
		}

        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "Region_RegionDescription_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "Region_RegionDescription")]
		public virtual string RegionDescription
        {
            [DebuggerStepThrough]
            get { return _regionDescription; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _regionDescription, value); }
        } 
    } 
}
