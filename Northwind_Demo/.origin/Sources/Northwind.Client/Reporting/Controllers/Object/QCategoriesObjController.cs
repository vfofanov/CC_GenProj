using Northwind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace Northwind.Client.Reporting.Controllers.Object
{
    [Controller("QCategories", Description = "QCategories object controller", IsOnlyExternal = true)]
    public sealed class QCategoriesObjController : ObjectController<QCategories,int>
    {
        public QCategoriesObjController(IValueHolder<QCategories> holder)
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