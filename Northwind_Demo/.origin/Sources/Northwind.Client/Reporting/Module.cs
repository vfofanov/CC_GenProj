using System;
using System.Diagnostics;
using ReportSystem.Contracts;
using ReportSystem.Contracts.Attributes;

namespace Northwind.Client.Reporting
{
    [ModuleInfo]
    public sealed class Module : ModuleInfo
    {
        #region Static
        private static readonly Guid ms_guid = new Guid("E671BC4C-4422-4630-9DD5-9ECCE95FC2AA");
        #endregion
        public override Guid Guid
        {
            [DebuggerStepThrough]
            get { return ms_guid; }
        }
        public override string Name
        {
            [DebuggerStepThrough]
            get { return "Northwind.Client"; }
        }
    }
}