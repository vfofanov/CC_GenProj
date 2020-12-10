using BusinessFramework.Client.Contracts.Reporting;
using BusinessFramework.Contracts.Actions;
using NorthWind.Client.ActionServices.Client.CodeBehind;
using NorthWind.Client.Services.Contracts.DomainModel;

namespace NorthWind.Client.ActionServices.Client
{
    /// <summary>
    /// </summary>
    public sealed class ClientOrderManagerService : CodeBehindClientOrderManagerService
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public ClientOrderManagerService(IReportViewer reportViewer, IOrdersQueryCollectionManager ordersQueryCollectionManager)
        {
            ReportViewer = reportViewer;
            OrdersQueryCollectionManager = ordersQueryCollectionManager;
        }

        private IReportViewer ReportViewer { get; set; }
        private IOrdersQueryCollectionManager OrdersQueryCollectionManager { get; set; }

        public override ActionResult ClientPrintSimple()
        {
            throw new System.NotImplementedException();
        }

        public override ActionResult ClientPrintWithParameter(int id)
        {
            var order = OrdersQueryCollectionManager.GetReadOnlyObjectByKey(id);

            ReportViewer.ForcedRun("OrderInvoice", ReportSaveFormat.Auto, ReportViewActions.SaveOpen, order);
            return ActionResult.DefaultSuccess;
        }

        public override ActionResult ClientPrintWithForm()
        {
            throw new System.NotImplementedException();
        }
    }
}