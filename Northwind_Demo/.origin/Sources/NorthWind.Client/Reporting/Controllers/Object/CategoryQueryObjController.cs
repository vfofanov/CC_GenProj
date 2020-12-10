using NorthWind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace NorthWind.Client.Reporting.Controllers.Object
{
    [Controller("CategoryQuery", Description = "CategoryQuery object controller", IsOnlyExternal = true)]
    public sealed class CategoryQueryObjController : ObjectController<CategoryQuery,int>
    {
        public CategoryQueryObjController(IValueHolder<CategoryQuery> holder)
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