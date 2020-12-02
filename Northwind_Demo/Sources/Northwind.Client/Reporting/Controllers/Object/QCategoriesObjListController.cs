using System.Collections.Generic;
using Northwind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace Northwind.Client.Reporting.Controllers.Object
{
    [Controller("QCategories list", Description = "QCategories objects' list controller", IsOnlyExternal = true)]
    public sealed class QCategoriesObjListController : ObjectControllerList<QCategories,int>
    {
        #region Constructor
        public QCategoriesObjListController(IValueHolder<List<QCategories>> holder)
                : base(holder)
        {
        }
        #endregion
    }
}