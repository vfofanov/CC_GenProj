using System.Collections.Generic;
using Northwind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace Northwind.Client.Reporting.Controllers.Object
{
    [Controller("QOrders list", Description = "QOrders objects' list controller", IsOnlyExternal = true)]
    public sealed class QOrdersObjListController : ObjectControllerList<QOrders,int>
    {
        #region Constructor
        public QOrdersObjListController(IValueHolder<List<QOrders>> holder)
                : base(holder)
        {
        }
        #endregion
    }
}