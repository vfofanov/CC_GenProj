using NorthWind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace NorthWind.Client.Reporting.Controllers.Object
{
    [Controller("ReportFormQuery", Description = "ReportFormQuery object controller", IsOnlyExternal = true)]
    public sealed class ReportFormQueryObjController : ObjectController<ReportFormQuery,int>
    {
        public ReportFormQueryObjController(IValueHolder<ReportFormQuery> holder)
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