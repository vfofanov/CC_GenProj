using NorthWind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace NorthWind.Client.Reporting.Controllers.Object
{
    [Controller("Orders", Description = "Orders object controller", IsOnlyExternal = true)]
    public sealed class OrdersObjController : ObjectController<Orders,int>
    {
        public OrdersObjController(IValueHolder<Orders> holder)
                : base(holder)
        {
        }        
        [ArgumentOut]
        public int Id
	    {
	       get { return Value.Id; }
	    }
    }
}