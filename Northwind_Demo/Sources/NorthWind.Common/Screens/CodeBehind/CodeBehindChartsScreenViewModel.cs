using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using BusinessFramework.Client.Common.Screens;
using BusinessFramework.Client.Common.Screens.DataBlocks;
using BusinessFramework.Client.Contracts.Actions;
using BusinessFramework.Client.Contracts.Files;
using BusinessFramework.Client.Contracts.Screens;
using BusinessFramework.Client.Contracts.Screens.DataBlocks;
using BusinessFramework.Client.Contracts.Wizards;
using BusinessFramework.Contracts;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.Contracts.Reporting;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.ActionServices;
using NorthWind.Client.Services.Contracts.DomainModel;
using NorthWind.Common.Properties;
using NorthWind.Common.Wizards;
using NorthWind.Contracts.DataObjects;
using NorthWind.Contracts.Enums;


namespace NorthWind.Common.Screens.CodeBehind
{
    public abstract class CodeBehindChartsScreenViewModel : ScreenViewModel
    {
        protected CodeBehindChartsScreenViewModel(ICustomersCollectionManager customersCollectionManager)
        {
            CustomersCollectionManager = customersCollectionManager;

	        //DataBlocks
            BlockRegion1 = new MultiItemsScreenBlockViewModel<Customers, int>("blockRegion1", GetblockRegion1Data, CustomersCollectionManager, GetblockRegion1RowStyle);
            //Actions
        }

		//Dependencies
        protected ICustomersCollectionManager CustomersCollectionManager { get; private set; }


	    //DataBlocks
        protected MultiItemsScreenBlockViewModel<Customers, int> BlockRegion1 { get; private set; }
        //Actions

		public sealed override IScreenBlockViewModel GetDataBlock(string dataBlockName)
        {
		    ScreenBlockViewModel result;
            switch (dataBlockName)
            {
		        case "blockRegion1":
				    result = BlockRegion1;
					break;
                default:
                    throw new ArgumentOutOfRangeException("dataBlockName", "Unknown data block settings");
            }

			if (IsSealed)	
			{
			    if (result.IsEnabled)
				{
				    return result;
				}
				throw new ArgumentOutOfRangeException("actionName", "Try get disabled data block from sealed screenviewmodel");
			}
			result.Enable();
			return result;
        }

        public sealed override IScreenCommand GetCommand(string actionName)
        {
		    ScreenCommand result;
            switch (actionName)
            {
                default:
                    throw new ArgumentOutOfRangeException("actionName", "Unknown screen action");
            }

			if (IsSealed)	
			{
			    if (result.IsEnabled)
				{
				    return result;
				}
				throw new ArgumentOutOfRangeException("actionName", "Try get disabled action from sealed screenviewmodel");
			}
			result.Enable();
			return result;
        }

        #region	Data Blocks
        protected virtual IQueryable<Customers> GetblockRegion1Data(QuickFilter filter)
        {

            return CustomersCollectionManager.GetObjects(filter);
        }

        protected virtual IRowStyle GetblockRegion1RowStyle(Customers customers)
        {
            return null;
        }

		#endregion
		#region	Actions
        #endregion
    }
}