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
    public abstract class CodeBehindRegionScreenViewModel : ScreenViewModel
    {
        protected CodeBehindRegionScreenViewModel(IEntityManagementService entityManagementService, IRegionCollectionManager regionCollectionManager, IScreenCommandFactory screenCommandFactory)
        {
            EntityManagementService = entityManagementService;
            RegionCollectionManager = regionCollectionManager;
            ScreenCommandFactory = screenCommandFactory;

	        //DataBlocks
            BlockRegion1 = new MultiItemsScreenBlockViewModel<Region, int>("blockRegion1", GetblockRegion1Data, RegionCollectionManager, GetblockRegion1RowStyle);
			BlockRegion1.PropertyChanged += OnblockRegion1PropertyChanged;
            //Actions
            BlockRegion1ActionView1 = ScreenCommandFactory.Create("blockRegion1ActionView1", DoBlockRegion1ActionView1, CanExecuteBlockRegion1ActionView1);
            BlockRegion1CreateNew1 = ScreenCommandFactory.CreateFunc("blockRegion1CreateNew1", DoBlockRegion1CreateNew1, CanExecuteBlockRegion1CreateNew1);
            BlockRegion1Edit1 = ScreenCommandFactory.CreateFunc("blockRegion1Edit1", DoBlockRegion1Edit1, CanExecuteBlockRegion1Edit1);
            BlockRegion1Refresh = ScreenCommandFactory.Create("blockRegion1Refresh", DoBlockRegion1Refresh, CanExecuteBlockRegion1Refresh);
        }

		//Dependencies
        protected IEntityManagementService EntityManagementService { get; private set; }

        protected IRegionCollectionManager RegionCollectionManager { get; private set; }

        protected IScreenCommandFactory ScreenCommandFactory { get; private set; }


	    //DataBlocks
        protected MultiItemsScreenBlockViewModel<Region, int> BlockRegion1 { get; private set; }
        //Actions
        protected ScreenCommand BlockRegion1ActionView1 { get; private set; }
        protected ScreenCommand BlockRegion1CreateNew1 { get; private set; }
        protected ScreenCommand BlockRegion1Edit1 { get; private set; }
        protected ScreenCommand BlockRegion1Refresh { get; private set; }

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
		        case "blockRegion1ActionView1":
                    result = BlockRegion1ActionView1;
					break;
		        case "blockRegion1CreateNew1":
                    result = BlockRegion1CreateNew1;
					break;
		        case "blockRegion1Edit1":
                    result = BlockRegion1Edit1;
					break;
		        case "blockRegion1Refresh":
                    result = BlockRegion1Refresh;
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
        protected virtual IQueryable<Region> GetblockRegion1Data(QuickFilter filter)
        {

            return RegionCollectionManager.GetObjects(filter);
        }

        protected virtual IRowStyle GetblockRegion1RowStyle(Region region)
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
        }
		#endregion
		#region	Actions
        protected virtual void DoBlockRegion1ActionView1(ScreenActionCommand command)
        {
        
            var key = BlockRegion1.ActiveItem.Id;
            
            EntityManagementService.View(DomainWizards.RegionWizard, key, DoBlockRegion1ActionView1_SetParameters);
        }
          
        protected virtual void DoBlockRegion1ActionView1_SetParameters(RegionWizardParameters parameters)
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

        protected virtual WizardNewResult<Region> DoBlockRegion1CreateNew1(ScreenActionCommand command)
        {
            var result = EntityManagementService.New(DomainWizards.RegionWizard, DoBlockRegion1CreateNew1_SetParameters, DoBlockRegion1CreateNew1_SetDefaults);
            if (result.SaveToServerComplete)
            {
                BlockRegion1.RaiseDataChanged();
            }
            
            return result;
        }
        
        protected virtual void DoBlockRegion1CreateNew1_SetDefaults(RegionWizardParameters parameters, Region entity)
        {
        }
        
          
        protected virtual void DoBlockRegion1CreateNew1_SetParameters(RegionWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteBlockRegion1CreateNew1()
        {		 
           return true;
        }

        protected virtual WizardEditResult<Region> DoBlockRegion1Edit1(ScreenActionCommand command)
        {
        
            var key = BlockRegion1.ActiveItem.Id;
            var result = EntityManagementService.Edit(DomainWizards.RegionWizard, key, DoBlockRegion1Edit1_SetParameters);
            if (result.SaveToServerComplete)
            {
                BlockRegion1.UpdateActiveObject();
            }
            
            return result;
        }
          
        protected virtual void DoBlockRegion1Edit1_SetParameters(RegionWizardParameters parameters)
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

        protected virtual void DoBlockRegion1Refresh(ScreenActionCommand command)
        {
        
            BlockRegion1.RaiseDataChanged();
        
        }

        protected virtual bool CanExecuteBlockRegion1Refresh()
        {		 
           return true;
        }

        #endregion
    }
}