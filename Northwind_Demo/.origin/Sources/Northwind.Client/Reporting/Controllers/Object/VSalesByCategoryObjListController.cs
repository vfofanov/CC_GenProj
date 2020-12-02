using System.Collections.Generic;
using Northwind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace Northwind.Client.Reporting.Controllers.Object
{
    [Controller("VSalesByCategory list", Description = "VSalesByCategory objects' list controller", IsOnlyExternal = true)]
    public sealed class VSalesByCategoryObjListController : ObjectControllerList<VSalesByCategory,int>
    {
        #region Constructor
        public VSalesByCategoryObjListController(IValueHolder<List<VSalesByCategory>> holder)
                : base(holder)
        {
        }
        #endregion
    }
}