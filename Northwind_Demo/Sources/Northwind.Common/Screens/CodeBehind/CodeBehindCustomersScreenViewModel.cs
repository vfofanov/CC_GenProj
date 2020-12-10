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
    public abstract class CodeBehindCustomersScreenViewModel : ScreenViewModel
    {
        protected CodeBehindCustomersScreenViewModel(ICustomerQueryCollectionManager customerQueryCollectionManager, IEntityManagementService entityManagementService, IScreenCommandFactory screenCommandFactory)
        {
            CustomerQueryCollectionManager = customerQueryCollectionManager;
            EntityManagementService = entityManagementService;
            ScreenCommandFactory = screenCommandFactory;

	        //DataBlocks
            QCustomers = new MultiItemsScreenBlockViewModel<CustomerQuery, int>("qCustomers", GetqCustomersData, CustomerQueryCollectionManager, GetqCustomersRowStyle);
			QCustomers.PropertyChanged += OnqCustomersPropertyChanged;
            //Actions
            QCustomersWizardCreateNew = ScreenCommandFactory.CreateFunc("qCustomersWizardCreateNew", DoQCustomersWizardCreateNew, CanExecuteQCustomersWizardCreateNew);
            QCustomersWizardView = ScreenCommandFactory.Create("qCustomersWizardView", DoQCustomersWizardView, CanExecuteQCustomersWizardView);
            QCustomersWizardEdit = ScreenCommandFactory.CreateFunc("qCustomersWizardEdit", DoQCustomersWizardEdit, CanExecuteQCustomersWizardEdit);
            QCustomersDeleteEntity = ScreenCommandFactory.CreateFunc("qCustomersDeleteEntity", DoQCustomersDeleteEntity, CanExecuteQCustomersDeleteEntity);
            QCustomersRefresh = ScreenCommandFactory.Create("qCustomersRefresh", DoQCustomersRefresh, CanExecuteQCustomersRefresh);
        }

		//Dependencies
        protected ICustomerQueryCollectionManager CustomerQueryCollectionManager { get; private set; }

        protected IEntityManagementService EntityManagementService { get; private set; }

        protected IScreenCommandFactory ScreenCommandFactory { get; private set; }


	    //DataBlocks
        protected MultiItemsScreenBlockViewModel<CustomerQuery, int> QCustomers { get; private set; }
        //Actions
        protected ScreenCommand QCustomersWizardCreateNew { get; private set; }
        protected ScreenCommand QCustomersWizardView { get; private set; }
        protected ScreenCommand QCustomersWizardEdit { get; private set; }
        protected ScreenCommand QCustomersDeleteEntity { get; private set; }
        protected ScreenCommand QCustomersRefresh { get; private set; }

		public sealed override IScreenBlockViewModel GetDataBlock(string dataBlockName)
        {
		    ScreenBlockViewModel result;
            switch (dataBlockName)
            {
		        case "qCustomers":
				    result = QCustomers;
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
		        case "qCustomersWizardCreateNew":
                    result = QCustomersWizardCreateNew;
					break;
		        case "qCustomersWizardView":
                    result = QCustomersWizardView;
					break;
		        case "qCustomersWizardEdit":
                    result = QCustomersWizardEdit;
					break;
		        case "qCustomersDeleteEntity":
                    result = QCustomersDeleteEntity;
					break;
		        case "qCustomersRefresh":
                    result = QCustomersRefresh;
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
        protected virtual IQueryable<CustomerQuery> GetqCustomersData(QuickFilter filter)
        {

            return CustomerQueryCollectionManager.GetObjects(filter);
        }

        protected virtual IRowStyle GetqCustomersRowStyle(CustomerQuery customerQuery)
        {
            return null;
        }

        protected virtual void OnqCustomersPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
            if (e.PropertyName == "ActiveItem")
            {            
            }

            if(QCustomersWizardView.IsEnabled)
			{
			    QCustomersWizardView.RaiseCanExecuteChanged();
			}

            if(QCustomersWizardEdit.IsEnabled)
			{
			    QCustomersWizardEdit.RaiseCanExecuteChanged();
			}

            if(QCustomersDeleteEntity.IsEnabled)
			{
			    QCustomersDeleteEntity.RaiseCanExecuteChanged();
			}
        }
		#endregion
		#region	Actions
        protected virtual WizardNewResult<Customers> DoQCustomersWizardCreateNew(ScreenActionCommand command)
        {
            var result = EntityManagementService.New(DomainWizards.CustomerWizard, DoQCustomersWizardCreateNew_SetParameters, DoQCustomersWizardCreateNew_SetDefaults);
            if (result.SaveToServerComplete)
            {
                QCustomers.RaiseDataChanged();
            }
            
            return result;
        }
        
        protected virtual void DoQCustomersWizardCreateNew_SetDefaults(CustomerWizardParameters parameters, Customers entity)
        {
        }
        
          
        protected virtual void DoQCustomersWizardCreateNew_SetParameters(CustomerWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQCustomersWizardCreateNew()
        {		 
           return true;
        }

        protected virtual void DoQCustomersWizardView(ScreenActionCommand command)
        {
        
            var key = QCustomers.ActiveItem.Id;
            
            EntityManagementService.View(DomainWizards.CustomerWizard, key, DoQCustomersWizardView_SetParameters);
        }
          
        protected virtual void DoQCustomersWizardView_SetParameters(CustomerWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQCustomersWizardView()
        {		 
           if(!(QCustomers.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual WizardEditResult<Customers> DoQCustomersWizardEdit(ScreenActionCommand command)
        {
        
            var key = QCustomers.ActiveItem.Id;
            var result = EntityManagementService.Edit(DomainWizards.CustomerWizard, key, DoQCustomersWizardEdit_SetParameters);
            if (result.SaveToServerComplete)
            {
                QCustomers.UpdateActiveObject();
            }
            
            return result;
        }
          
        protected virtual void DoQCustomersWizardEdit_SetParameters(CustomerWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQCustomersWizardEdit()
        {		 
           if(!(QCustomers.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual bool DoQCustomersDeleteEntity(ScreenActionCommand command)
        {
        
            var keys = QCustomers.SelectedItems.Select(obj => obj.Id).ToArray();
            
            var result = EntityManagementService.Delete<Customers, int>(keys);
            if(result)
            {
                QCustomers.RemoveSelectedObjects();
            }
            
            return result;
        }
        


        protected virtual bool CanExecuteQCustomersDeleteEntity()
        {		 
           if(!(QCustomers.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual void DoQCustomersRefresh(ScreenActionCommand command)
        {
        
            QCustomers.RaiseDataChanged();
        
        }

        protected virtual bool CanExecuteQCustomersRefresh()
        {		 
           return true;
        }

        #endregion
    }
}