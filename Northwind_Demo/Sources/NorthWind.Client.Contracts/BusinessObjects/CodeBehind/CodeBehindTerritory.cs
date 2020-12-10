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
	[DebuggerDisplay("Territory" + " {"+ nameof(Id) +"}")]
	[TypeDisplay(typeof(ObjectResources))]
	[Microsoft.OData.Client.Key(nameof(Id))]
    public abstract class CodeBehindTerritory : ClassicDataObject<int, Territory>
    {
	    /// <summary>
        ///     Object's creation method for OData
        /// </summary>
	    public static Territory CreateTerritory(int id)
        {
            return new Territory {Id = id};
        }

        private int _regionID;
        private string _territoryDescription;

        protected CodeBehindTerritory()
		{
		}

		protected CodeBehindTerritory(Territory origin)
		    :base(origin)
	    {
            _regionID = origin._regionID;
            _territoryDescription = origin._territoryDescription;
		}

        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "Territory_RegionID_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "Territory_RegionID")]
		public virtual int RegionID
        {
            [DebuggerStepThrough]
            get { return _regionID; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _regionID, value); }
        } 
        [RequiredValidator( MessageTemplateResourceType = typeof(ObjectResources), MessageTemplateResourceName = "Territory_TerritoryDescription_RequiredMsg")]
		[Display(ResourceType = typeof(ObjectResources), Name = "Territory_TerritoryDescription")]
		public virtual string TerritoryDescription
        {
            [DebuggerStepThrough]
            get { return _territoryDescription; }
            [DebuggerStepThrough]
			set { SetMemberAndMarkChanged(ref _territoryDescription, value); }
        } 
    } 
}
