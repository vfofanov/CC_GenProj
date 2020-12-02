using System.Collections.Generic;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.Contracts.Reporting;


namespace Northwind.Client.Services.Contracts.ActionServices
{

    /// <summary>
    /// 
    /// </summary>
    public partial interface IClientOrderManagerService
    {    

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        ActionResult PrintOrderInvoice(int id);

        /// <summary>
        /// Can execute. 
        /// </summary>
        /// <param name="id"></param>
        bool PrintOrderInvoiceCanExecute(int id);

        /// <summary>
        /// Get confirmation message. 
        /// </summary>
        /// <param name="id"></param>
        string PrintOrderInvoiceGetConfirmMessage(int id);
    }
}