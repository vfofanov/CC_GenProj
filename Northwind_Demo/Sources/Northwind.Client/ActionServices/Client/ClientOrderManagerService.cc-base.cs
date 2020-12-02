using System;
using System.Collections.Generic;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.Contracts.Reporting;


namespace Northwind.Client.ActionServices.Client
{

    /// <summary>
    /// 
    /// </summary>
    public sealed class ClientOrderManagerService : CodeBehind.CodeBehindClientOrderManagerService
    {

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		public override ActionResult PrintOrderInvoice(int id)
		{
		    throw new NotImplementedException();
		}
    }
}