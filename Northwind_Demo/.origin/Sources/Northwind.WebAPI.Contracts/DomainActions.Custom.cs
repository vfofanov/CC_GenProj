using BusinessFramework.Contracts.Metadata;


namespace Northwind.WebAPI.Contracts
{
    /// <summary>
    ///     Domain actions' keys
    /// </summary>
    public abstract partial class DomainActions
    {
        public static class Custom
        {
            public static class TestDynamicColumnsActionService
            {
                public static readonly CustomDomainAction GetTestData = new CustomDomainAction("GetTestData", DomainActionKeys.Custom.TestDynamicColumnsActionService_GetTestData, "GetTestData", false);
            }

        }
    }
}