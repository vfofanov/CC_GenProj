using BusinessFramework.Contracts.Metadata;


namespace NorthWind.WebAPI.Contracts
{
    /// <summary>
    ///     Domain actions' keys
    /// </summary>
    public abstract partial class DomainActions
    {
        public static class Custom
        {
            public static class ReportService
            {
                public static readonly CustomDomainAction ServerPrintSimple = new CustomDomainAction("ServerPrintSimple", DomainActionKeys.Custom.ReportService_ServerPrintSimple, "Print report", false);
                public static readonly CustomDomainAction ServerPrintWithParameter = new CustomDomainAction("ServerPrintWithParameter", DomainActionKeys.Custom.ReportService_ServerPrintWithParameter, "Print report with parameter ", false);
                public static readonly CustomDomainAction ServerPrintWithForm = new CustomDomainAction("ServerPrintWithForm", DomainActionKeys.Custom.ReportService_ServerPrintWithForm, "Print report with parameter ", false);
            }

        }
    }
}