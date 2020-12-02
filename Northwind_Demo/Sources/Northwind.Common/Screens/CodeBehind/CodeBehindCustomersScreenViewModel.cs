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
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.Services.Contracts.ActionServices;
using Northwind.Client.Services.Contracts.DomainModel;
using Northwind.Common.Properties;
using Northwind.Common.Wizards;
using Northwind.Contracts.DataObjects;
using Northwind.Contracts.Enums;


namespace Northwind.Common.Screens.CodeBehind
{
    public abstract class CodeBehindCustomersScreenViewModel : ScreenViewModel
    {
        protected CodeBehindCustomersScreenViewModel(IEntityManagementService entityManagementService, IQCustomersCollectionManager qCustomersCollectionManager, IScreenCommandFactory screenCommandFactory)
        {
            EntityManagementService = entityManagementService;
            QCustomersCollectionManager = qCustomersCollectionManager;
            ScreenCommandFactory = screenCommandFactory;

	        //DataBlocks
            QCustomers = new MultiItemsScreenBlockViewModel<QCustomers, int>("qCustomers", GetqCustomersData, QCustomersCollectionManager, GetqCustomersRowStyle);
			QCustomers.PropertyChanged += OnqCustomersPropertyChanged;
            //Actions
            QCustomersWizardCreateNew = ScreenCommandFactory.CreateFunc("qCustomersWizardCreateNew", DoQCustomersWizardCreateNew, CanExecuteQCustomersWizardCreateNew);
            QCustomersWizardView = ScreenCommandFactory.Create("qCustomersWizardView", DoQCustomersWizardView, CanExecuteQCustomersWizardView);
            QCustomersWizardEdit = ScreenCommandFactory.CreateFunc("qCustomersWizardEdit", DoQCustomersWizardEdit, CanExecuteQCustomersWizardEdit);
            QCustomersDeleteEntity = ScreenCommandFactory.CreateFunc("qCustomersDeleteEntity", DoQCustomersDeleteEntity, CanExecuteQCustomersDeleteEntity);
            QCustomersRefresh = ScreenCommandFactory.Create("qCustomersRefresh", DoQCustomersRefresh, CanExecuteQCustomersRefresh);
        }

		//Dependencies
        protected IEntityManagementService EntityManagementService { get; private set; }

        protected IQCustomersCollectionManager QCustomersCollectionManager { get; private set; }

        protected IScreenCommandFactory ScreenCommandFactory { get; private set; }


	    //DataBlocks
        protected MultiItemsScreenBlockViewModel<QCustomers, int> QCustomers { get; private set; }
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
        protected virtual IQueryable<QCustomers> GetqCustomersData(QuickFilter filter)
        {

            return QCustomersCollectionManager.GetObjects(filter);
        }

        protected virtual IRowStyle GetqCustomersRowStyle(QCustomers qCustomers)
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
        protected virtual WizardNewResult<Customer> DoQCustomersWizardCreateNew(ScreenActionCommand command)
        {
            var result = EntityManagementService.New(DomainWizards.CustomersWizard, DoQCustomersWizardCreateNew_SetParameters, DoQCustomersWizardCreateNew_SetDefaults);
            if (result.SaveToServerComplete)
            {
                QCustomers.RaiseDataChanged();
            }
            
            return result;
        }
        
        protected virtual void DoQCustomersWizardCreateNew_SetDefaults(CustomersWizardParameters parameters, Customer entity)
        {
        }
        
          
        protected virtual void DoQCustomersWizardCreateNew_SetParameters(CustomersWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQCustomersWizardCreateNew()
        {		 
           return true;
        }

        protected virtual void DoQCustomersWizardView(ScreenActionCommand command)
        {
        
            var key = QCustomers.ActiveItem.Id;
            
            EntityManagementService.View(DomainWizards.CustomersWizard, key, DoQCustomersWizardView_SetParameters);
        }
          
        protected virtual void DoQCustomersWizardView_SetParameters(CustomersWizardParameters parameters)
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

        protected virtual WizardEditResult<Customer> DoQCustomersWizardEdit(ScreenActionCommand command)
        {
        
            var key = QCustomers.ActiveItem.Id;
            var result = EntityManagementService.Edit(DomainWizards.CustomersWizard, key, DoQCustomersWizardEdit_SetParameters);
            if (result.SaveToServerComplete)
            {
                QCustomers.UpdateActiveObject();
            }
            
            return result;
        }
          
        protected virtual void DoQCustomersWizardEdit_SetParameters(CustomersWizardParameters parameters)
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
            
            var result = EntityManagementService.Delete<Customer, int>(keys);
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