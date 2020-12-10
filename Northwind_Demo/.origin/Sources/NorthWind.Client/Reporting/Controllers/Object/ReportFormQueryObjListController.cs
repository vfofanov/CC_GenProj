using System.Collections.Generic;
using NorthWind.Client.Contracts.BusinessObjects;
using ReportingFramework.Client.ReportSystem;
using ReportingFramework.Client.ReportSystem.Controllers.Object;
using ReportSystem.Contracts.Attributes;


namespace NorthWind.Client.Reporting.Controllers.Object
{
    [Controller("ReportFormQuery list", Description = "ReportFormQuery objects' list controller", IsOnlyExternal = true)]
    public sealed class ReportFormQueryObjListController : ObjectControllerList<ReportFormQuery,int>
    {
        #region Constructor
        public ReportFormQueryObjListController(IValueHolder<List<ReportFormQuery>> holder)
                : base(holder)
        {
        }
        #endregion
    }
}