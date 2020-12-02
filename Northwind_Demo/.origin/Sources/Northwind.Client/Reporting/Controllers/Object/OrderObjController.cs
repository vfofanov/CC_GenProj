using Northwind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace Northwind.Client.Reporting.Controllers.Object
{
    [Controller("Order", Description = "Order object controller", IsOnlyExternal = true)]
    public sealed class OrderObjController : ObjectController<Order,int>
    {
        public OrderObjController(IValueHolder<Order> holder)
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