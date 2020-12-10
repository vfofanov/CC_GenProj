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
using BusinessFramework.Client.Contracts.Reporting;
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
    public abstract class CodeBehindCategoriesScreenViewModel : ScreenViewModel
    {
        protected CodeBehindCategoriesScreenViewModel(ICategoryQueryCollectionManager categoryQueryCollectionManager, IEntityManagementService entityManagementService, IProductQueryCollectionManager productQueryCollectionManager, IReportViewer reportViewer, IScreenCommandFactory screenCommandFactory)
        {
            CategoryQueryCollectionManager = categoryQueryCollectionManager;
            EntityManagementService = entityManagementService;
            ProductQueryCollectionManager = productQueryCollectionManager;
            ReportViewer = reportViewer;
            ScreenCommandFactory = screenCommandFactory;

	        //DataBlocks
            QCategories = new MultiItemsScreenBlockViewModel<CategoryQuery, int>("qCategories", GetqCategoriesData, CategoryQueryCollectionManager, GetqCategoriesRowStyle);
			QCategories.PropertyChanged += OnqCategoriesPropertyChanged;
            QProducts = new MultiItemsScreenBlockViewModel<ProductQuery, int>("qProducts", GetqProductsData, ProductQueryCollectionManager, GetqProductsRowStyle);
			QProducts.PropertyChanged += OnqProductsPropertyChanged;
            //Actions
            QCategoriesCreateNew1 = ScreenCommandFactory.CreateFunc("qCategoriesCreateNew1", DoQCategoriesCreateNew1, CanExecuteQCategoriesCreateNew1);
            QCategoriesActionView1 = ScreenCommandFactory.Create("qCategoriesActionView1", DoQCategoriesActionView1, CanExecuteQCategoriesActionView1);
            QCategoriesEdit1 = ScreenCommandFactory.CreateFunc("qCategoriesEdit1", DoQCategoriesEdit1, CanExecuteQCategoriesEdit1);
            QCategoriesDelete1 = ScreenCommandFactory.CreateFunc("qCategoriesDelete1", DoQCategoriesDelete1, CanExecuteQCategoriesDelete1);
            QCategoriesRefresh1 = ScreenCommandFactory.Create("qCategoriesRefresh1", DoQCategoriesRefresh1, CanExecuteQCategoriesRefresh1);
            QCategoriesOpenReports1 = ScreenCommandFactory.Create("qCategoriesOpenReports1", DoQCategoriesOpenReports1, CanExecuteQCategoriesOpenReports1);
            QProductsCreateNew1 = ScreenCommandFactory.CreateFunc("qProductsCreateNew1", DoQProductsCreateNew1, CanExecuteQProductsCreateNew1);
            QProductsActionView1 = ScreenCommandFactory.Create("qProductsActionView1", DoQProductsActionView1, CanExecuteQProductsActionView1);
            QProductsEdit1 = ScreenCommandFactory.CreateFunc("qProductsEdit1", DoQProductsEdit1, CanExecuteQProductsEdit1);
            QProductsDelete1 = ScreenCommandFactory.CreateFunc("qProductsDelete1", DoQProductsDelete1, CanExecuteQProductsDelete1);
            QProductsRefresh1 = ScreenCommandFactory.Create("qProductsRefresh1", DoQProductsRefresh1, CanExecuteQProductsRefresh1);
        }

		//Dependencies
        protected ICategoryQueryCollectionManager CategoryQueryCollectionManager { get; private set; }

        protected IEntityManagementService EntityManagementService { get; private set; }

        protected IProductQueryCollectionManager ProductQueryCollectionManager { get; private set; }

        protected IReportViewer ReportViewer { get; private set; }

        protected IScreenCommandFactory ScreenCommandFactory { get; private set; }


	    //DataBlocks
        protected MultiItemsScreenBlockViewModel<CategoryQuery, int> QCategories { get; private set; }
        protected MultiItemsScreenBlockViewModel<ProductQuery, int> QProducts { get; private set; }
        //Actions
        protected ScreenCommand QCategoriesCreateNew1 { get; private set; }
        protected ScreenCommand QCategoriesActionView1 { get; private set; }
        protected ScreenCommand QCategoriesEdit1 { get; private set; }
        protected ScreenCommand QCategoriesDelete1 { get; private set; }
        protected ScreenCommand QCategoriesRefresh1 { get; private set; }
        protected ScreenCommand QCategoriesOpenReports1 { get; private set; }
        protected ScreenCommand QProductsCreateNew1 { get; private set; }
        protected ScreenCommand QProductsActionView1 { get; private set; }
        protected ScreenCommand QProductsEdit1 { get; private set; }
        protected ScreenCommand QProductsDelete1 { get; private set; }
        protected ScreenCommand QProductsRefresh1 { get; private set; }

		public sealed override IScreenBlockViewModel GetDataBlock(string dataBlockName)
        {
		    ScreenBlockViewModel result;
            switch (dataBlockName)
            {
		        case "qCategories":
				    result = QCategories;
					break;
		        case "qProducts":
				    result = QProducts;
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
		        case "qCategoriesCreateNew1":
                    result = QCategoriesCreateNew1;
					break;
		        case "qCategoriesActionView1":
                    result = QCategoriesActionView1;
					break;
		        case "qCategoriesEdit1":
                    result = QCategoriesEdit1;
					break;
		        case "qCategoriesDelete1":
                    result = QCategoriesDelete1;
					break;
		        case "qCategoriesRefresh1":
                    result = QCategoriesRefresh1;
					break;
		        case "qCategoriesOpenReports1":
                    result = QCategoriesOpenReports1;
					break;
		        case "qProductsCreateNew1":
                    result = QProductsCreateNew1;
					break;
		        case "qProductsActionView1":
                    result = QProductsActionView1;
					break;
		        case "qProductsEdit1":
                    result = QProductsEdit1;
					break;
		        case "qProductsDelete1":
                    result = QProductsDelete1;
					break;
		        case "qProductsRefresh1":
                    result = QProductsRefresh1;
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
        protected virtual IQueryable<CategoryQuery> GetqCategoriesData(QuickFilter filter)
        {

            return CategoryQueryCollectionManager.GetObjects(filter);
        }

        protected virtual IRowStyle GetqCategoriesRowStyle(CategoryQuery categoryQuery)
        {
            return null;
        }

        protected virtual void OnqCategoriesPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
            if (e.PropertyName == "ActiveItem")
            {            

                if(QProducts.IsEnabled)
			    {
			        QProducts.RaiseDataChanged();
			    }
            }

            if(QCategoriesActionView1.IsEnabled)
			{
			    QCategoriesActionView1.RaiseCanExecuteChanged();
			}

            if(QCategoriesEdit1.IsEnabled)
			{
			    QCategoriesEdit1.RaiseCanExecuteChanged();
			}

            if(QCategoriesDelete1.IsEnabled)
			{
			    QCategoriesDelete1.RaiseCanExecuteChanged();
			}

            if(QProductsCreateNew1.IsEnabled)
			{
			    QProductsCreateNew1.RaiseCanExecuteChanged();
			}
        }
        protected virtual IQueryable<ProductQuery> GetqProductsData(QuickFilter filter)
        {
            if(QCategories.ActiveItem == null)
			{
			    return null;
			}
            var cond1 = QCategories.ActiveItem.Id;

            return ProductQueryCollectionManager.GetObjects(filter).Where(obj => obj.CategoryID == cond1);
        }

        protected virtual IRowStyle GetqProductsRowStyle(ProductQuery productQuery)
        {
            return null;
        }

        protected virtual void OnqProductsPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
            if (e.PropertyName == "ActiveItem")
            {            
            }

            if(QProductsActionView1.IsEnabled)
			{
			    QProductsActionView1.RaiseCanExecuteChanged();
			}

            if(QProductsEdit1.IsEnabled)
			{
			    QProductsEdit1.RaiseCanExecuteChanged();
			}

            if(QProductsDelete1.IsEnabled)
			{
			    QProductsDelete1.RaiseCanExecuteChanged();
			}
        }
		#endregion
		#region	Actions
        protected virtual WizardNewResult<Categories> DoQCategoriesCreateNew1(ScreenActionCommand command)
        {
            var result = EntityManagementService.New(DomainWizards.CategoryWizard, DoQCategoriesCreateNew1_SetParameters, DoQCategoriesCreateNew1_SetDefaults);
            if (result.SaveToServerComplete)
            {
                QCategories.RaiseDataChanged();
            }
            
            return result;
        }
        
        protected virtual void DoQCategoriesCreateNew1_SetDefaults(CategoryWizardParameters parameters, Categories entity)
        {
        }
        
          
        protected virtual void DoQCategoriesCreateNew1_SetParameters(CategoryWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQCategoriesCreateNew1()
        {		 
           return true;
        }

        protected virtual void DoQCategoriesActionView1(ScreenActionCommand command)
        {
        
            var key = QCategories.ActiveItem.Id;
            
            EntityManagementService.View(DomainWizards.CategoryWizard, key, DoQCategoriesActionView1_SetParameters);
        }
          
        protected virtual void DoQCategoriesActionView1_SetParameters(CategoryWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQCategoriesActionView1()
        {		 
           if(!(QCategories.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual WizardEditResult<Categories> DoQCategoriesEdit1(ScreenActionCommand command)
        {
        
            var key = QCategories.ActiveItem.Id;
            var result = EntityManagementService.Edit(DomainWizards.CategoryWizard, key, DoQCategoriesEdit1_SetParameters);
            if (result.SaveToServerComplete)
            {
                QCategories.UpdateActiveObject();
            }
            
            return result;
        }
          
        protected virtual void DoQCategoriesEdit1_SetParameters(CategoryWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQCategoriesEdit1()
        {		 
           if(!(QCategories.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual bool DoQCategoriesDelete1(ScreenActionCommand command)
        {
        
            var keys = QCategories.SelectedItems.Select(obj => obj.Id).ToArray();
            
            var result = EntityManagementService.Delete<Categories, int>(keys);
            if(result)
            {
                QCategories.RemoveSelectedObjects();
            }
            
            return result;
        }
        


        protected virtual bool CanExecuteQCategoriesDelete1()
        {		 
           if(!(QCategories.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual void DoQCategoriesRefresh1(ScreenActionCommand command)
        {
        
            QCategories.RaiseDataChanged();
        
        }

        protected virtual bool CanExecuteQCategoriesRefresh1()
        {		 
           return true;
        }

        protected virtual void DoQCategoriesOpenReports1(ScreenActionCommand command)
        {
        
            if (QCategories.ActiveItem == null || !ReportViewer.IsReportSupported(QCategories.ItemType))
            {
                return;
            }
        
            ReportViewer.OpenReportForm(QCategories.SelectedItems);
        }


        protected virtual bool CanExecuteQCategoriesOpenReports1()
        {		 
           return true;
        }

        protected virtual WizardNewResult<Products> DoQProductsCreateNew1(ScreenActionCommand command)
        {
            var result = EntityManagementService.New(DomainWizards.ProductWizard, DoQProductsCreateNew1_SetParameters, DoQProductsCreateNew1_SetDefaults);
            if (result.SaveToServerComplete)
            {
                QProducts.RaiseDataChanged();
            }
            
            return result;
        }
        
        protected virtual void DoQProductsCreateNew1_SetDefaults(ProductWizardParameters parameters, Products entity)
        {
            entity.CategoryID = QCategories.ActiveItem.Id;
        }
        
          
        protected virtual void DoQProductsCreateNew1_SetParameters(ProductWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQProductsCreateNew1()
        {		 
           if(!(QCategories.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual void DoQProductsActionView1(ScreenActionCommand command)
        {
        
            var key = QProducts.ActiveItem.Id;
            
            EntityManagementService.View(DomainWizards.ProductWizard, key, DoQProductsActionView1_SetParameters);
        }
          
        protected virtual void DoQProductsActionView1_SetParameters(ProductWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQProductsActionView1()
        {		 
           if(!(QProducts.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual WizardEditResult<Products> DoQProductsEdit1(ScreenActionCommand command)
        {
        
            var key = QProducts.ActiveItem.Id;
            var result = EntityManagementService.Edit(DomainWizards.ProductWizard, key, DoQProductsEdit1_SetParameters);
            if (result.SaveToServerComplete)
            {
                QProducts.UpdateActiveObject();
            }
            
            return result;
        }
          
        protected virtual void DoQProductsEdit1_SetParameters(ProductWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQProductsEdit1()
        {		 
           if(!(QProducts.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual bool DoQProductsDelete1(ScreenActionCommand command)
        {
        
            var keys = QProducts.SelectedItems.Select(obj => obj.Id).ToArray();
            
            var result = EntityManagementService.Delete<Products, int>(keys);
            if(result)
            {
                QProducts.RemoveSelectedObjects();
            }
            
            return result;
        }
        


        protected virtual bool CanExecuteQProductsDelete1()
        {		 
           if(!(QProducts.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual void DoQProductsRefresh1(ScreenActionCommand command)
        {
        
            QProducts.RaiseDataChanged();
        
        }

        protected virtual bool CanExecuteQProductsRefresh1()
        {		 
           return true;
        }

        #endregion
    }
}