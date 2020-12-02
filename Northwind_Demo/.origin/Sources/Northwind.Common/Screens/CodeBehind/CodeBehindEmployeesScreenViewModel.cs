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
    public abstract class CodeBehindEmployeesScreenViewModel : ScreenViewModel
    {
        protected CodeBehindEmployeesScreenViewModel(IEntityManagementService entityManagementService, IQEmployeesCollectionManager qEmployeesCollectionManager, IScreenCommandFactory screenCommandFactory)
        {
            EntityManagementService = entityManagementService;
            QEmployeesCollectionManager = qEmployeesCollectionManager;
            ScreenCommandFactory = screenCommandFactory;

	        //DataBlocks
            QEmployees = new MultiItemsScreenBlockViewModel<QEmployees, int>("qEmployees", GetqEmployeesData, QEmployeesCollectionManager, GetqEmployeesRowStyle);
			QEmployees.PropertyChanged += OnqEmployeesPropertyChanged;
            QEmployees1 = new ActiveItemScreenBlockViewModel<QEmployees>("qEmployees1");
            //Actions
            QEmployeesWizardCreateNew = ScreenCommandFactory.CreateFunc("qEmployeesWizardCreateNew", DoQEmployeesWizardCreateNew, CanExecuteQEmployeesWizardCreateNew);
            QEmployeesWizardView = ScreenCommandFactory.Create("qEmployeesWizardView", DoQEmployeesWizardView, CanExecuteQEmployeesWizardView);
            QEmployeesWizardEdit = ScreenCommandFactory.CreateFunc("qEmployeesWizardEdit", DoQEmployeesWizardEdit, CanExecuteQEmployeesWizardEdit);
            QEmployeesDeleteEntity = ScreenCommandFactory.CreateFunc("qEmployeesDeleteEntity", DoQEmployeesDeleteEntity, CanExecuteQEmployeesDeleteEntity);
            QEmployeesRefresh = ScreenCommandFactory.Create("qEmployeesRefresh", DoQEmployeesRefresh, CanExecuteQEmployeesRefresh);
        }

		//Dependencies
        protected IEntityManagementService EntityManagementService { get; private set; }

        protected IQEmployeesCollectionManager QEmployeesCollectionManager { get; private set; }

        protected IScreenCommandFactory ScreenCommandFactory { get; private set; }


	    //DataBlocks
        protected MultiItemsScreenBlockViewModel<QEmployees, int> QEmployees { get; private set; }
        protected ActiveItemScreenBlockViewModel<QEmployees> QEmployees1 { get; private set; }
        //Actions
        protected ScreenCommand QEmployeesWizardCreateNew { get; private set; }
        protected ScreenCommand QEmployeesWizardView { get; private set; }
        protected ScreenCommand QEmployeesWizardEdit { get; private set; }
        protected ScreenCommand QEmployeesDeleteEntity { get; private set; }
        protected ScreenCommand QEmployeesRefresh { get; private set; }

		public sealed override IScreenBlockViewModel GetDataBlock(string dataBlockName)
        {
		    ScreenBlockViewModel result;
            switch (dataBlockName)
            {
		        case "qEmployees":
				    result = QEmployees;
					break;
		        case "qEmployees1":
				    result = QEmployees1;
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
		        case "qEmployeesWizardCreateNew":
                    result = QEmployeesWizardCreateNew;
					break;
		        case "qEmployeesWizardView":
                    result = QEmployeesWizardView;
					break;
		        case "qEmployeesWizardEdit":
                    result = QEmployeesWizardEdit;
					break;
		        case "qEmployeesDeleteEntity":
                    result = QEmployeesDeleteEntity;
					break;
		        case "qEmployeesRefresh":
                    result = QEmployeesRefresh;
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
        protected virtual IQueryable<QEmployees> GetqEmployeesData(QuickFilter filter)
        {

            return QEmployeesCollectionManager.GetObjects(filter);
        }

        protected virtual IRowStyle GetqEmployeesRowStyle(QEmployees qEmployees)
        {
            return null;
        }

        protected virtual void OnqEmployeesPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
            if (e.PropertyName == "ActiveItem")
            {            

                if(QEmployees1.IsEnabled)
			    {
			        QEmployees1.Select(QEmployees.ActiveItem);
			    }
            }

            if(QEmployeesWizardView.IsEnabled)
			{
			    QEmployeesWizardView.RaiseCanExecuteChanged();
			}

            if(QEmployeesWizardEdit.IsEnabled)
			{
			    QEmployeesWizardEdit.RaiseCanExecuteChanged();
			}

            if(QEmployeesDeleteEntity.IsEnabled)
			{
			    QEmployeesDeleteEntity.RaiseCanExecuteChanged();
			}
        }
        protected virtual IRowStyle GetqEmployees1RowStyle(QEmployees qEmployees)
        {
            return null;
        }

		#endregion
		#region	Actions
        protected virtual WizardNewResult<Employee> DoQEmployeesWizardCreateNew(ScreenActionCommand command)
        {
            var result = EntityManagementService.New(DomainWizards.EmployeesWizard, DoQEmployeesWizardCreateNew_SetParameters, DoQEmployeesWizardCreateNew_SetDefaults);
            if (result.SaveToServerComplete)
            {
                QEmployees.RaiseDataChanged();
            }
            
            return result;
        }
        
        protected virtual void DoQEmployeesWizardCreateNew_SetDefaults(EmployeesWizardParameters parameters, Employee entity)
        {
        }
        
          
        protected virtual void DoQEmployeesWizardCreateNew_SetParameters(EmployeesWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQEmployeesWizardCreateNew()
        {		 
           return true;
        }

        protected virtual void DoQEmployeesWizardView(ScreenActionCommand command)
        {
        
            var key = QEmployees.ActiveItem.Id;
            
            EntityManagementService.View(DomainWizards.EmployeesWizard, key, DoQEmployeesWizardView_SetParameters);
        }
          
        protected virtual void DoQEmployeesWizardView_SetParameters(EmployeesWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQEmployeesWizardView()
        {		 
           if(!(QEmployees.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual WizardEditResult<Employee> DoQEmployeesWizardEdit(ScreenActionCommand command)
        {
        
            var key = QEmployees.ActiveItem.Id;
            var result = EntityManagementService.Edit(DomainWizards.EmployeesWizard, key, DoQEmployeesWizardEdit_SetParameters);
            if (result.SaveToServerComplete)
            {
                QEmployees.UpdateActiveObject();
            }
            
            return result;
        }
          
        protected virtual void DoQEmployeesWizardEdit_SetParameters(EmployeesWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQEmployeesWizardEdit()
        {		 
           if(!(QEmployees.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual bool DoQEmployeesDeleteEntity(ScreenActionCommand command)
        {
        
            var keys = QEmployees.SelectedItems.Select(obj => obj.Id).ToArray();
            
            var result = EntityManagementService.Delete<Employee, int>(keys);
            if(result)
            {
                QEmployees.RemoveSelectedObjects();
            }
            
            return result;
        }
        


        protected virtual bool CanExecuteQEmployeesDeleteEntity()
        {		 
           if(!(QEmployees.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual void DoQEmployeesRefresh(ScreenActionCommand command)
        {
        
            QEmployees.RaiseDataChanged();
        
        }

        protected virtual bool CanExecuteQEmployeesRefresh()
        {		 
           return true;
        }

        #endregion
    }
}