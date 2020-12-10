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
using BusinessFramework.Client.Contracts.Services;
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
    public abstract class CodeBehindShippersScreenViewModel : ScreenViewModel
    {
        protected CodeBehindShippersScreenViewModel(IEntityManagementService entityManagementService, IScreenCommandFactory screenCommandFactory, IShipperQueryCollectionManager shipperQueryCollectionManager)
        {
            EntityManagementService = entityManagementService;
            ScreenCommandFactory = screenCommandFactory;
            ShipperQueryCollectionManager = shipperQueryCollectionManager;

	        //DataBlocks
            BlockRegion1 = new MultiItemsScreenBlockViewModel<ShipperQuery, int>("blockRegion1", GetblockRegion1Data, ShipperQueryCollectionManager, GetblockRegion1RowStyle);
			BlockRegion1.PropertyChanged += OnblockRegion1PropertyChanged;
            //Actions
            BlockRegion1CreateNew1 = ScreenCommandFactory.CreateFunc("blockRegion1CreateNew1", DoBlockRegion1CreateNew1, CanExecuteBlockRegion1CreateNew1);
            BlockRegion1ActionView1 = ScreenCommandFactory.Create("blockRegion1ActionView1", DoBlockRegion1ActionView1, CanExecuteBlockRegion1ActionView1);
            BlockRegion1Edit1 = ScreenCommandFactory.CreateFunc("blockRegion1Edit1", DoBlockRegion1Edit1, CanExecuteBlockRegion1Edit1);
            BlockRegion1Delete1 = ScreenCommandFactory.CreateFunc("blockRegion1Delete1", DoBlockRegion1Delete1, CanExecuteBlockRegion1Delete1);
            BlockRegion1Refresh1 = ScreenCommandFactory.Create("blockRegion1Refresh1", DoBlockRegion1Refresh1, CanExecuteBlockRegion1Refresh1);
        }

		//Dependencies
        protected IEntityManagementService EntityManagementService { get; private set; }

        protected IScreenCommandFactory ScreenCommandFactory { get; private set; }

        protected IShipperQueryCollectionManager ShipperQueryCollectionManager { get; private set; }


	    //DataBlocks
        protected MultiItemsScreenBlockViewModel<ShipperQuery, int> BlockRegion1 { get; private set; }
        //Actions
        protected ScreenCommand BlockRegion1CreateNew1 { get; private set; }
        protected ScreenCommand BlockRegion1ActionView1 { get; private set; }
        protected ScreenCommand BlockRegion1Edit1 { get; private set; }
        protected ScreenCommand BlockRegion1Delete1 { get; private set; }
        protected ScreenCommand BlockRegion1Refresh1 { get; private set; }

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
		        case "blockRegion1CreateNew1":
                    result = BlockRegion1CreateNew1;
					break;
		        case "blockRegion1ActionView1":
                    result = BlockRegion1ActionView1;
					break;
		        case "blockRegion1Edit1":
                    result = BlockRegion1Edit1;
					break;
		        case "blockRegion1Delete1":
                    result = BlockRegion1Delete1;
					break;
		        case "blockRegion1Refresh1":
                    result = BlockRegion1Refresh1;
					break;
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
        protected virtual IQueryable<ShipperQuery> GetblockRegion1Data(QuickFilter filter)
        {

            return ShipperQueryCollectionManager.GetObjects(filter);
        }

        protected virtual IRowStyle GetblockRegion1RowStyle(ShipperQuery shipperQuery)
        {
            return null;
        }

        protected virtual void OnblockRegion1PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
            if (e.PropertyName == "ActiveItem")
            {            
            }

            if(BlockRegion1ActionView1.IsEnabled)
			{
			    BlockRegion1ActionView1.RaiseCanExecuteChanged();
			}

            if(BlockRegion1Edit1.IsEnabled)
			{
			    BlockRegion1Edit1.RaiseCanExecuteChanged();
			}

            if(BlockRegion1Delete1.IsEnabled)
			{
			    BlockRegion1Delete1.RaiseCanExecuteChanged();
			}
        }
		#endregion
		#region	Actions
        protected virtual WizardNewResult<Shippers> DoBlockRegion1CreateNew1(ScreenActionCommand command)
        {
            var result = EntityManagementService.New(DomainWizards.ShipperWizard, DoBlockRegion1CreateNew1_SetParameters, DoBlockRegion1CreateNew1_SetDefaults);
            if (result.SaveToServerComplete)
            {
                BlockRegion1.RaiseDataChanged();
            }
            
            return result;
        }
        
        protected virtual void DoBlockRegion1CreateNew1_SetDefaults(ShipperWizardParameters parameters, Shippers entity)
        {
        }
        
          
        protected virtual void DoBlockRegion1CreateNew1_SetParameters(ShipperWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteBlockRegion1CreateNew1()
        {		 
           return true;
        }

        protected virtual void DoBlockRegion1ActionView1(ScreenActionCommand command)
        {
        
            var key = BlockRegion1.ActiveItem.Id;
            
            EntityManagementService.View(DomainWizards.ShipperWizard, key, DoBlockRegion1ActionView1_SetParameters);
        }
          
        protected virtual void DoBlockRegion1ActionView1_SetParameters(ShipperWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteBlockRegion1ActionView1()
        {		 
           if(!(BlockRegion1.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual WizardEditResult<Shippers> DoBlockRegion1Edit1(ScreenActionCommand command)
        {
        
            var key = BlockRegion1.ActiveItem.Id;
            var result = EntityManagementService.Edit(DomainWizards.ShipperWizard, key, DoBlockRegion1Edit1_SetParameters);
            if (result.SaveToServerComplete)
            {
                BlockRegion1.UpdateActiveObject();
            }
            
            return result;
        }
          
        protected virtual void DoBlockRegion1Edit1_SetParameters(ShipperWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteBlockRegion1Edit1()
        {		 
           if(!(BlockRegion1.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual bool DoBlockRegion1Delete1(ScreenActionCommand command)
        {
        
            var keys = BlockRegion1.SelectedItems.Select(obj => obj.Id).ToArray();
            
            var result = EntityManagementService.Delete<Shippers, int>(keys);
            if(result)
            {
                BlockRegion1.RemoveSelectedObjects();
            }
            
            return result;
        }
        


        protected virtual bool CanExecuteBlockRegion1Delete1()
        {		 
           if(!(BlockRegion1.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual void DoBlockRegion1Refresh1(ScreenActionCommand command)
        {
        
            BlockRegion1.RaiseDataChanged();
        
        }

        protected virtual bool CanExecuteBlockRegion1Refresh1()
        {		 
           return true;
        }

        #endregion
    }
}