using System.Collections.Generic;
using Northwind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace Northwind.Client.Reporting.Controllers.Object
{
    [Controller("Category list", Description = "Category objects' list controller", IsOnlyExternal = true)]
    public sealed class CategoryObjListController : ObjectControllerList<Category,int>
    {
        #region Constructor
        public CategoryObjListController(IValueHolder<List<Category>> holder)
                : base(holder)
        {
        }
        #endregion
    }
}