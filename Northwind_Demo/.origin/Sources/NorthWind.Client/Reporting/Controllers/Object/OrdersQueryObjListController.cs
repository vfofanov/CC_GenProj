using System.Collections.Generic;
using NorthWind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace NorthWind.Client.Reporting.Controllers.Object
{
    [Controller("OrdersQuery list", Description = "OrdersQuery objects' list controller", IsOnlyExternal = true)]
    public sealed class OrdersQueryObjListController : ObjectControllerList<OrdersQuery,int>
    {
        #region Constructor
        public OrdersQueryObjListController(IValueHolder<List<OrdersQuery>> holder)
                : base(holder)
        {
        }
        #endregion
    }
}