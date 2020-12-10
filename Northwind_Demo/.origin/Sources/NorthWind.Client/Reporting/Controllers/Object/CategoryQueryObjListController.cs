using System.Collections.Generic;
using NorthWind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace NorthWind.Client.Reporting.Controllers.Object
{
    [Controller("CategoryQuery list", Description = "CategoryQuery objects' list controller", IsOnlyExternal = true)]
    public sealed class CategoryQueryObjListController : ObjectControllerList<CategoryQuery,int>
    {
        #region Constructor
        public CategoryQueryObjListController(IValueHolder<List<CategoryQuery>> holder)
                : base(holder)
        {
        }
        #endregion
    }
}