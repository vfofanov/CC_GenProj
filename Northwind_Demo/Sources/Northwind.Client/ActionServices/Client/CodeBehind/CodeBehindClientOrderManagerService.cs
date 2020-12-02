using System.Collections.Generic;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.Contracts.Reporting;
using Northwind.Client.Properties;
using Northwind.Client.Services.Contracts.ActionServices;
using Northwind.Contracts;


namespace Northwind.Client.ActionServices.Client.CodeBehind
{

    /// <summary>
    /// Code behind
    /// </summary>
    public abstract partial class CodeBehindClientOrderManagerService : IClientOrderManagerService
    {
		/// <inheritdoc />
		public abstract ActionResult PrintOrderInvoice(int id);
		/// <inheritdoc />
		public virtual bool PrintOrderInvoiceCanExecute(int id)
		{
		    return true;
		}
		/// <inheritdoc />
		public virtual string PrintOrderInvoiceGetConfirmMessage(int id)
		{
		    return ActionServiceResources.ClientOrderManager_PrintOrderInvoice_ConfirmationMessage;
		}
    }
}