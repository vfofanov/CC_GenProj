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
    public abstract class CodeBehindProductsScreenViewModel : ScreenViewModel
    {
        protected CodeBehindProductsScreenViewModel(ICategoryQueryCollectionManager categoryQueryCollectionManager, IEntityManagementService entityManagementService, IProductQueryCollectionManager productQueryCollectionManager, IScreenCommandFactory screenCommandFactory, ISupplierQueryCollectionManager supplierQueryCollectionManager)
        {
            CategoryQueryCollectionManager = categoryQueryCollectionManager;
            EntityManagementService = entityManagementService;
            ProductQueryCollectionManager = productQueryCollectionManager;
            ScreenCommandFactory = screenCommandFactory;
            SupplierQueryCollectionManager = supplierQueryCollectionManager;

	        //DataBlocks
            QProducts = new MultiItemsScreenBlockViewModel<ProductQuery, int>("qProducts", GetqProductsData, ProductQueryCollectionManager, GetqProductsRowStyle);
			QProducts.PropertyChanged += OnqProductsPropertyChanged;
            QCategories = new ActiveItemDataFuncScreenBlockViewModel<CategoryQuery>("qCategories", GetqCategoriesData);
            QSuppliers = new ActiveItemDataFuncScreenBlockViewModel<SupplierQuery>("qSuppliers", GetqSuppliersData);
            //Actions
            QProductsWizardCreateNew = ScreenCommandFactory.CreateFunc("qProductsWizardCreateNew", DoQProductsWizardCreateNew, CanExecuteQProductsWizardCreateNew);
            QProductsWizardView = ScreenCommandFactory.Create("qProductsWizardView", DoQProductsWizardView, CanExecuteQProductsWizardView);
            QProductsWizardEdit = ScreenCommandFactory.CreateFunc("qProductsWizardEdit", DoQProductsWizardEdit, CanExecuteQProductsWizardEdit);
            QProductsDeleteEntity = ScreenCommandFactory.CreateFunc("qProductsDeleteEntity", DoQProductsDeleteEntity, CanExecuteQProductsDeleteEntity);
            QProductsRefresh = ScreenCommandFactory.Create("qProductsRefresh", DoQProductsRefresh, CanExecuteQProductsRefresh);
        }

		//Dependencies
        protected ICategoryQueryCollectionManager CategoryQueryCollectionManager { get; private set; }

        protected IEntityManagementService EntityManagementService { get; private set; }

        protected IProductQueryCollectionManager ProductQueryCollectionManager { get; private set; }

        protected IScreenCommandFactory ScreenCommandFactory { get; private set; }

        protected ISupplierQueryCollectionManager SupplierQueryCollectionManager { get; private set; }


	    //DataBlocks
        protected MultiItemsScreenBlockViewModel<ProductQuery, int> QProducts { get; private set; }
        protected ActiveItemDataFuncScreenBlockViewModel<CategoryQuery> QCategories { get; private set; }
        protected ActiveItemDataFuncScreenBlockViewModel<SupplierQuery> QSuppliers { get; private set; }
        //Actions
        protected ScreenCommand QProductsWizardCreateNew { get; private set; }
        protected ScreenCommand QProductsWizardView { get; private set; }
        protected ScreenCommand QProductsWizardEdit { get; private set; }
        protected ScreenCommand QProductsDeleteEntity { get; private set; }
        protected ScreenCommand QProductsRefresh { get; private set; }

		public sealed override IScreenBlockViewModel GetDataBlock(string dataBlockName)
        {
		    ScreenBlockViewModel result;
            switch (dataBlockName)
            {
		        case "qProducts":
				    result = QProducts;
					break;
		        case "qCategories":
				    result = QCategories;
					break;
		        case "qSuppliers":
				    result = QSuppliers;
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
		        case "qProductsWizardCreateNew":
                    result = QProductsWizardCreateNew;
					break;
		        case "qProductsWizardView":
                    result = QProductsWizardView;
					break;
		        case "qProductsWizardEdit":
                    result = QProductsWizardEdit;
					break;
		        case "qProductsDeleteEntity":
                    result = QProductsDeleteEntity;
					break;
		        case "qProductsRefresh":
                    result = QProductsRefresh;
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
        protected virtual IQueryable<ProductQuery> GetqProductsData(QuickFilter filter)
        {

            return ProductQueryCollectionManager.GetObjects(filter);
        }

        protected virtual IRowStyle GetqProductsRowStyle(ProductQuery productQuery)
        {
            return null;
        }

        protected virtual void OnqProductsPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
            if (e.PropertyName == "ActiveItem")
            {            

                if(QCategories.IsEnabled)
			    {
			        QCategories.RaiseDataChanged();
			    }

                if(QSuppliers.IsEnabled)
			    {
			        QSuppliers.RaiseDataChanged();
			    }
            }

            if(QProductsWizardView.IsEnabled)
			{
			    QProductsWizardView.RaiseCanExecuteChanged();
			}

            if(QProductsWizardEdit.IsEnabled)
			{
			    QProductsWizardEdit.RaiseCanExecuteChanged();
			}

            if(QProductsDeleteEntity.IsEnabled)
			{
			    QProductsDeleteEntity.RaiseCanExecuteChanged();
			}
        }
        protected virtual IQueryable<CategoryQuery> GetqCategoriesData(QuickFilter filter)
        {
            if(QProducts.ActiveItem == null)
			{
			    return null;
			}
            var cond1 = QProducts.ActiveItem.CategoryID;

            return CategoryQueryCollectionManager.GetObjects(filter).Where(obj => obj.Id == cond1);
        }

        protected virtual IRowStyle GetqCategoriesRowStyle(CategoryQuery categoryQuery)
        {
            return null;
        }

        protected virtual IQueryable<SupplierQuery> GetqSuppliersData(QuickFilter filter)
        {
            if(QProducts.ActiveItem == null)
			{
			    return null;
			}
            var cond1 = QProducts.ActiveItem.SupplierID;

            return SupplierQueryCollectionManager.GetObjects(filter).Where(obj => obj.Id == cond1);
        }

        protected virtual IRowStyle GetqSuppliersRowStyle(SupplierQuery supplierQuery)
        {
            return null;
        }

		#endregion
		#region	Actions
        protected virtual WizardNewResult<Products> DoQProductsWizardCreateNew(ScreenActionCommand command)
        {
            var result = EntityManagementService.New(DomainWizards.ProductWizard, DoQProductsWizardCreateNew_SetParameters, DoQProductsWizardCreateNew_SetDefaults);
            if (result.SaveToServerComplete)
            {
                QProducts.RaiseDataChanged();
            }
            
            return result;
        }
        
        protected virtual void DoQProductsWizardCreateNew_SetDefaults(ProductWizardParameters parameters, Products entity)
        {
        }
        
          
        protected virtual void DoQProductsWizardCreateNew_SetParameters(ProductWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQProductsWizardCreateNew()
        {		 
           return true;
        }

        protected virtual void DoQProductsWizardView(ScreenActionCommand command)
        {
        
            var key = QProducts.ActiveItem.Id;
            
            EntityManagementService.View(DomainWizards.ProductWizard, key, DoQProductsWizardView_SetParameters);
        }
          
        protected virtual void DoQProductsWizardView_SetParameters(ProductWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQProductsWizardView()
        {		 
           if(!(QProducts.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual WizardEditResult<Products> DoQProductsWizardEdit(ScreenActionCommand command)
        {
        
            var key = QProducts.ActiveItem.Id;
            var result = EntityManagementService.Edit(DomainWizards.ProductWizard, key, DoQProductsWizardEdit_SetParameters);
            if (result.SaveToServerComplete)
            {
                QProducts.UpdateActiveObject();
            }
            
            return result;
        }
          
        protected virtual void DoQProductsWizardEdit_SetParameters(ProductWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQProductsWizardEdit()
        {		 
           if(!(QProducts.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual bool DoQProductsDeleteEntity(ScreenActionCommand command)
        {
        
            var keys = QProducts.SelectedItems.Select(obj => obj.Id).ToArray();
            
            var result = EntityManagementService.Delete<Products, int>(keys);
            if(result)
            {
                QProducts.RemoveSelectedObjects();
            }
            
            return result;
        }
        


        protected virtual bool CanExecuteQProductsDeleteEntity()
        {		 
           if(!(QProducts.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual void DoQProductsRefresh(ScreenActionCommand command)
        {
        
            QProducts.RaiseDataChanged();
        
        }

        protected virtual bool CanExecuteQProductsRefresh()
        {		 
           return true;
        }

        #endregion
    }
}