using NorthWind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace NorthWind.Client.Reporting.Controllers.Object
{
    [Controller("OrdersQuery", Description = "OrdersQuery object controller", IsOnlyExternal = true)]
    public sealed class OrdersQueryObjController : ObjectController<OrdersQuery,int>
    {
        public OrdersQueryObjController(IValueHolder<OrdersQuery> holder)
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