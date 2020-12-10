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
    public abstract class CodeBehindEmployeesScreenViewModel : ScreenViewModel
    {
        protected CodeBehindEmployeesScreenViewModel(IEmployeeQueryCollectionManager employeeQueryCollectionManager, IEntityManagementService entityManagementService, IScreenCommandFactory screenCommandFactory)
        {
            EmployeeQueryCollectionManager = employeeQueryCollectionManager;
            EntityManagementService = entityManagementService;
            ScreenCommandFactory = screenCommandFactory;

	        //DataBlocks
            QEmployees = new MultiItemsScreenBlockViewModel<EmployeeQuery, int>("qEmployees", GetqEmployeesData, EmployeeQueryCollectionManager, GetqEmployeesRowStyle);
			QEmployees.PropertyChanged += OnqEmployeesPropertyChanged;
            QEmployees1 = new ActiveItemScreenBlockViewModel<EmployeeQuery>("qEmployees1");
            //Actions
            QEmployeesWizardCreateNew = ScreenCommandFactory.CreateFunc("qEmployeesWizardCreateNew", DoQEmployeesWizardCreateNew, CanExecuteQEmployeesWizardCreateNew);
            QEmployeesWizardView = ScreenCommandFactory.Create("qEmployeesWizardView", DoQEmployeesWizardView, CanExecuteQEmployeesWizardView);
            QEmployeesWizardEdit = ScreenCommandFactory.CreateFunc("qEmployeesWizardEdit", DoQEmployeesWizardEdit, CanExecuteQEmployeesWizardEdit);
            QEmployeesDeleteEntity = ScreenCommandFactory.CreateFunc("qEmployeesDeleteEntity", DoQEmployeesDeleteEntity, CanExecuteQEmployeesDeleteEntity);
            QEmployeesRefresh = ScreenCommandFactory.Create("qEmployeesRefresh", DoQEmployeesRefresh, CanExecuteQEmployeesRefresh);
        }

		//Dependencies
        protected IEmployeeQueryCollectionManager EmployeeQueryCollectionManager { get; private set; }

        protected IEntityManagementService EntityManagementService { get; private set; }

        protected IScreenCommandFactory ScreenCommandFactory { get; private set; }


	    //DataBlocks
        protected MultiItemsScreenBlockViewModel<EmployeeQuery, int> QEmployees { get; private set; }
        protected ActiveItemScreenBlockViewModel<EmployeeQuery> QEmployees1 { get; private set; }
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
        protected virtual IQueryable<EmployeeQuery> GetqEmployeesData(QuickFilter filter)
        {

            return EmployeeQueryCollectionManager.GetObjects(filter);
        }

        protected virtual IRowStyle GetqEmployeesRowStyle(EmployeeQuery employeeQuery)
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
        protected virtual IRowStyle GetqEmployees1RowStyle(EmployeeQuery employeeQuery)
        {
            return null;
        }

		#endregion
		#region	Actions
        protected virtual WizardNewResult<Employees> DoQEmployeesWizardCreateNew(ScreenActionCommand command)
        {
            var result = EntityManagementService.New(DomainWizards.EmployeeWizard, DoQEmployeesWizardCreateNew_SetParameters, DoQEmployeesWizardCreateNew_SetDefaults);
            if (result.SaveToServerComplete)
            {
                QEmployees.RaiseDataChanged();
            }
            
            return result;
        }
        
        protected virtual void DoQEmployeesWizardCreateNew_SetDefaults(EmployeeWizardParameters parameters, Employees entity)
        {
        }
        
          
        protected virtual void DoQEmployeesWizardCreateNew_SetParameters(EmployeeWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQEmployeesWizardCreateNew()
        {		 
           return true;
        }

        protected virtual void DoQEmployeesWizardView(ScreenActionCommand command)
        {
        
            var key = QEmployees.ActiveItem.Id;
            
            EntityManagementService.View(DomainWizards.EmployeeWizard, key, DoQEmployeesWizardView_SetParameters);
        }
          
        protected virtual void DoQEmployeesWizardView_SetParameters(EmployeeWizardParameters parameters)
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

        protected virtual WizardEditResult<Employees> DoQEmployeesWizardEdit(ScreenActionCommand command)
        {
        
            var key = QEmployees.ActiveItem.Id;
            var result = EntityManagementService.Edit(DomainWizards.EmployeeWizard, key, DoQEmployeesWizardEdit_SetParameters);
            if (result.SaveToServerComplete)
            {
                QEmployees.UpdateActiveObject();
            }
            
            return result;
        }
          
        protected virtual void DoQEmployeesWizardEdit_SetParameters(EmployeeWizardParameters parameters)
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
            
            var result = EntityManagementService.Delete<Employees, int>(keys);
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