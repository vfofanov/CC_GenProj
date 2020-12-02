using Northwind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace Northwind.Client.Reporting.Controllers.Object
{
    [Controller("QOrders", Description = "QOrders object controller", IsOnlyExternal = true)]
    public sealed class QOrdersObjController : ObjectController<QOrders,int>
    {
        public QOrdersObjController(IValueHolder<QOrders> holder)
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