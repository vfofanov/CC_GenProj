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
	[DebuggerDisplay("RegionQuery" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(QueryResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindRegionQuery : ClassicDataObject<int, RegionQuery>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static RegionQuery CreateRegionQuery(int id)
        {
            return new RegionQuery {Id = id};
        }

        private string _regionDescription;

        protected CodeBehindRegionQuery()
		{
		}

		protected CodeBehindRegionQuery(RegionQuery origin)
		    :base(origin)
	    {
            _regionDescription = origin._regionDescription;
		}

		[Display(ResourceType = typeof(QueryResources), Name = "RegionQuery_RegionDescription")]
		public virtual string RegionDescription
        {
            [DebuggerStepThrough]
            get { return _regionDescription; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _regionDescription, value); }
        } 
    } 
}
