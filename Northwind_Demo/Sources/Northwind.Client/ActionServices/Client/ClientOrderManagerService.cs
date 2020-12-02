using BusinessFramework.Client.Contracts.Reporting;
using BusinessFramework.Contracts.Actions;
using Northwind.Client.Services.Contracts.DomainModel;

namespace Northwind.Client.ActionServices.Client
{
    /// <summary>
    /// </summary>
    public sealed class ClientOrderManagerService : CodeBehind.CodeBehindClientOrderManagerService
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public ClientOrderManagerService(IReportViewer reportViewer, IQOrdersCollectionManager qOrdersCollectionManager)
        {
            ReportViewer = reportViewer;
            QOrdersCollectionManager = qOrdersCollectionManager;
        }

        private IReportViewer ReportViewer { get; set; }
        private IQOrdersCollectionManager QOrdersCollectionManager { get; set; }

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        public override ActionResult PrintOrderInvoice(int id)
        {
            var order = QOrdersCollectionManager.GetReadOnlyObjectByKey(id);

            ReportViewer.ForcedRun("OrderInvoice", ReportSaveFormat.Auto, ReportViewActions.SaveOpen, order);
            return ActionResult.DefaultSuccess;
        }
    }
}