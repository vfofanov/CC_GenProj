using System.Collections.Generic;
using NorthWind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace NorthWind.Client.Reporting.Controllers.Object
{
    [Controller("Categories list", Description = "Categories objects' list controller", IsOnlyExternal = true)]
    public sealed class CategoriesObjListController : ObjectControllerList<Categories,int>
    {
        #region Constructor
        public CategoriesObjListController(IValueHolder<List<Categories>> holder)
                : base(holder)
        {
        }
        #endregion
    }
}