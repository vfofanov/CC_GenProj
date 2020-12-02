using System.Collections.Generic;
using Northwind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace Northwind.Client.Reporting.Controllers.Object
{
    [Controller("Order list", Description = "Order objects' list controller", IsOnlyExternal = true)]
    public sealed class OrderObjListController : ObjectControllerList<Order,int>
    {
        #region Constructor
        public OrderObjListController(IValueHolder<List<Order>> holder)
                : base(holder)
        {
        }
        #endregion
    }
}