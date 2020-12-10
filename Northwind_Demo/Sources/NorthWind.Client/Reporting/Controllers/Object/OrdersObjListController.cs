using System.Collections.Generic;
using NorthWind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace NorthWind.Client.Reporting.Controllers.Object
{
    [Controller("Orders list", Description = "Orders objects' list controller", IsOnlyExternal = true)]
    public sealed class OrdersObjListController : ObjectControllerList<Orders,int>
    {
        #region Constructor
        public OrdersObjListController(IValueHolder<List<Orders>> holder)
                : base(holder)
        {
        }
        #endregion
    }
}