using Northwind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace Northwind.Client.Reporting.Controllers.Object
{
    [Controller("VSalesByCategory", Description = "VSalesByCategory object controller", IsOnlyExternal = true)]
    public sealed class VSalesByCategoryObjController : ObjectController<VSalesByCategory,int>
    {
        public VSalesByCategoryObjController(IValueHolder<VSalesByCategory> holder)
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