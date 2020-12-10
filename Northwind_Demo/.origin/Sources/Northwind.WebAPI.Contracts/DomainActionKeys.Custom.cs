namespace NorthWind.WebAPI.Contracts
{
    /// <summary>
    ///     Domain actions' keys
    /// </summary>
    public abstract partial class DomainActionKeys
    {
        public static class Custom
        {
             public const int ReportService_ServerPrintSimple = 477;
             public const int ReportService_ServerPrintWithParameter = 478;
             public const int ReportService_ServerPrintWithForm = 479;
        }
    }
}