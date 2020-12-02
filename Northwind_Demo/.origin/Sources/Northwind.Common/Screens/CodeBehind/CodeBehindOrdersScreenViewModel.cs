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
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.Services.Contracts.ActionServices;
using Northwind.Client.Services.Contracts.DomainModel;
using Northwind.Common.Properties;
using Northwind.Common.Wizards;
using Northwind.Contracts.DataObjects;
using Northwind.Contracts.Enums;


namespace Northwind.Common.Screens.CodeBehind
{
    public abstract class CodeBehindOrdersScreenViewModel : ScreenViewModel
    {
        protected CodeBehindOrdersScreenViewModel(IClientOrderManagerService clientOrderManagerService, IEntityManagementService entityManagementService, IQOrderProductsCollectionManager qOrderProductsCollectionManager, IQOrdersCollectionManager qOrdersCollectionManager, IQShippersCollectionManager qShippersCollectionManager, IReportViewer reportViewer, IScreenCommandFactory screenCommandFactory)
        {
            ClientOrderManagerService = clientOrderManagerService;
            EntityManagementService = entityManagementService;
            QOrderProductsCollectionManager = qOrderProductsCollectionManager;
            QOrdersCollectionManager = qOrdersCollectionManager;
            QShippersCollectionManager = qShippersCollectionManager;
            ReportViewer = reportViewer;
            ScreenCommandFactory = screenCommandFactory;

	        //DataBlocks
            QOrders = new MultiItemsScreenBlockViewModel<QOrders, int>("qOrders", GetqOrdersData, QOrdersCollectionManager, GetqOrdersRowStyle);
			QOrders.PropertyChanged += OnqOrdersPropertyChanged;
            BlockRegion1 = new ActiveItemScreenBlockViewModel<QOrders>("blockRegion1");
			BlockRegion1.PropertyChanged += OnblockRegion1PropertyChanged;
            QOrderProducts = new MultiItemsScreenBlockViewModel<QOrderProducts, int>("qOrderProducts", GetqOrderProductsData, QOrderProductsCollectionManager, GetqOrderProductsRowStyle);
			QOrderProducts.PropertyChanged += OnqOrderProductsPropertyChanged;
            ShipperDetailRegion = new ActiveItemDataFuncScreenBlockViewModel<QShippers>("shipperDetailRegion", GetshipperDetailRegionData);
            //Actions
            QOrdersCreateNew1 = ScreenCommandFactory.CreateFunc("qOrdersCreateNew1", DoQOrdersCreateNew1, CanExecuteQOrdersCreateNew1);
            QOrdersActionView1 = ScreenCommandFactory.Create("qOrdersActionView1", DoQOrdersActionView1, CanExecuteQOrdersActionView1);
            QOrdersEdit1 = ScreenCommandFactory.CreateFunc("qOrdersEdit1", DoQOrdersEdit1, CanExecuteQOrdersEdit1);
            QOrdersDelete1 = ScreenCommandFactory.CreateFunc("qOrdersDelete1", DoQOrdersDelete1, CanExecuteQOrdersDelete1);
            QOrdersRefresh1 = ScreenCommandFactory.Create("qOrdersRefresh1", DoQOrdersRefresh1, CanExecuteQOrdersRefresh1);
            QOrdersOpenReports1 = ScreenCommandFactory.Create("qOrdersOpenReports1", DoQOrdersOpenReports1, CanExecuteQOrdersOpenReports1);
            QOrdersPrintOrderInvoice = ScreenCommandFactory.CreateFunc("qOrdersPrintOrderInvoice", DoQOrdersPrintOrderInvoice, CanExecuteQOrdersPrintOrderInvoice);
            QOrderProductsCreateNew1 = ScreenCommandFactory.CreateFunc("qOrderProductsCreateNew1", DoQOrderProductsCreateNew1, CanExecuteQOrderProductsCreateNew1);
            QOrderProductsActionView1 = ScreenCommandFactory.Create("qOrderProductsActionView1", DoQOrderProductsActionView1, CanExecuteQOrderProductsActionView1);
            QOrderProductsEdit1 = ScreenCommandFactory.CreateFunc("qOrderProductsEdit1", DoQOrderProductsEdit1, CanExecuteQOrderProductsEdit1);
            QOrderProductsDelete1 = ScreenCommandFactory.CreateFunc("qOrderProductsDelete1", DoQOrderProductsDelete1, CanExecuteQOrderProductsDelete1);
            QOrderProductsRefresh1 = ScreenCommandFactory.Create("qOrderProductsRefresh1", DoQOrderProductsRefresh1, CanExecuteQOrderProductsRefresh1);
        }

		//Dependencies
        protected IClientOrderManagerService ClientOrderManagerService { get; private set; }

        protected IEntityManagementService EntityManagementService { get; private set; }

        protected IQOrderProductsCollectionManager QOrderProductsCollectionManager { get; private set; }

        protected IQOrdersCollectionManager QOrdersCollectionManager { get; private set; }

        protected IQShippersCollectionManager QShippersCollectionManager { get; private set; }

        protected IReportViewer ReportViewer { get; private set; }

        protected IScreenCommandFactory ScreenCommandFactory { get; private set; }


	    //DataBlocks
        protected MultiItemsScreenBlockViewModel<QOrders, int> QOrders { get; private set; }
        protected ActiveItemScreenBlockViewModel<QOrders> BlockRegion1 { get; private set; }
        protected MultiItemsScreenBlockViewModel<QOrderProducts, int> QOrderProducts { get; private set; }
        protected ActiveItemDataFuncScreenBlockViewModel<QShippers> ShipperDetailRegion { get; private set; }
        //Actions
        protected ScreenCommand QOrdersCreateNew1 { get; private set; }
        protected ScreenCommand QOrdersActionView1 { get; private set; }
        protected ScreenCommand QOrdersEdit1 { get; private set; }
        protected ScreenCommand QOrdersDelete1 { get; private set; }
        protected ScreenCommand QOrdersRefresh1 { get; private set; }
        protected ScreenCommand QOrdersOpenReports1 { get; private set; }
        protected ScreenCommand QOrdersPrintOrderInvoice { get; private set; }
        protected ScreenCommand QOrderProductsCreateNew1 { get; private set; }
        protected ScreenCommand QOrderProductsActionView1 { get; private set; }
        protected ScreenCommand QOrderProductsEdit1 { get; private set; }
        protected ScreenCommand QOrderProductsDelete1 { get; private set; }
        protected ScreenCommand QOrderProductsRefresh1 { get; private set; }

		public sealed override IScreenBlockViewModel GetDataBlock(string dataBlockName)
        {
		    ScreenBlockViewModel result;
            switch (dataBlockName)
            {
		        case "qOrders":
				    result = QOrders;
					break;
		        case "blockRegion1":
				    result = BlockRegion1;
					break;
		        case "qOrderProducts":
				    result = QOrderProducts;
					break;
		        case "shipperDetailRegion":
				    result = ShipperDetailRegion;
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
		        case "qOrdersCreateNew1":
                    result = QOrdersCreateNew1;
					break;
		        case "qOrdersActionView1":
                    result = QOrdersActionView1;
					break;
		        case "qOrdersEdit1":
                    result = QOrdersEdit1;
					break;
		        case "qOrdersDelete1":
                    result = QOrdersDelete1;
					break;
		        case "qOrdersRefresh1":
                    result = QOrdersRefresh1;
					break;
		        case "qOrdersOpenReports1":
                    result = QOrdersOpenReports1;
					break;
		        case "qOrdersPrintOrderInvoice":
                    result = QOrdersPrintOrderInvoice;
					break;
		        case "qOrderProductsCreateNew1":
                    result = QOrderProductsCreateNew1;
					break;
		        case "qOrderProductsActionView1":
                    result = QOrderProductsActionView1;
					break;
		        case "qOrderProductsEdit1":
                    result = QOrderProductsEdit1;
					break;
		        case "qOrderProductsDelete1":
                    result = QOrderProductsDelete1;
					break;
		        case "qOrderProductsRefresh1":
                    result = QOrderProductsRefresh1;
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
        protected virtual IQueryable<QOrders> GetqOrdersData(QuickFilter filter)
        {

            return QOrdersCollectionManager.GetObjects(filter);
        }

        protected virtual IRowStyle GetqOrdersRowStyle(QOrders qOrders)
        {
            return null;
        }

        protected virtual void OnqOrdersPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
            if (e.PropertyName == "ActiveItem")
            {            

                if(BlockRegion1.IsEnabled)
			    {
			        BlockRegion1.Select(QOrders.ActiveItem);
			    }

                if(ShipperDetailRegion.IsEnabled)
			    {
			        ShipperDetailRegion.RaiseDataChanged();
			    }
            }

            if(QOrdersActionView1.IsEnabled)
			{
			    QOrdersActionView1.RaiseCanExecuteChanged();
			}

            if(QOrdersEdit1.IsEnabled)
			{
			    QOrdersEdit1.RaiseCanExecuteChanged();
			}

            if(QOrdersDelete1.IsEnabled)
			{
			    QOrdersDelete1.RaiseCanExecuteChanged();
			}

            if(QOrdersPrintOrderInvoice.IsEnabled)
			{
			    QOrdersPrintOrderInvoice.RaiseCanExecuteChanged();
			}

            if(QOrderProductsCreateNew1.IsEnabled)
			{
			    QOrderProductsCreateNew1.RaiseCanExecuteChanged();
			}
        }
        protected virtual IRowStyle GetblockRegion1RowStyle(QOrders qOrders)
        {
            return null;
        }

        protected virtual void OnblockRegion1PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
            if (e.PropertyName == "ActiveItem")
            {            

                if(QOrderProducts.IsEnabled)
			    {
			        QOrderProducts.RaiseDataChanged();
			    }
            }
        }
        protected virtual IQueryable<QOrderProducts> GetqOrderProductsData(QuickFilter filter)
        {
            if(BlockRegion1.ActiveItem == null)
			{
			    return null;
			}
            var cond1 = BlockRegion1.ActiveItem.Id;

            return QOrderProductsCollectionManager.GetObjects(filter).Where(obj => obj.OrderID == cond1);
        }

        protected virtual IRowStyle GetqOrderProductsRowStyle(QOrderProducts qOrderProducts)
        {
            return null;
        }

        protected virtual void OnqOrderProductsPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
            if (e.PropertyName == "ActiveItem")
            {            
            }

            if(QOrderProductsActionView1.IsEnabled)
			{
			    QOrderProductsActionView1.RaiseCanExecuteChanged();
			}

            if(QOrderProductsEdit1.IsEnabled)
			{
			    QOrderProductsEdit1.RaiseCanExecuteChanged();
			}

            if(QOrderProductsDelete1.IsEnabled)
			{
			    QOrderProductsDelete1.RaiseCanExecuteChanged();
			}
        }
        protected virtual IQueryable<QShippers> GetshipperDetailRegionData(QuickFilter filter)
        {
            if(QOrders.ActiveItem == null)
			{
			    return null;
			}
            var cond1 = QOrders.ActiveItem.ShipVia;

            return QShippersCollectionManager.GetObjects(filter).Where(obj => obj.Id == cond1);
        }

        protected virtual IRowStyle GetshipperDetailRegionRowStyle(QShippers qShippers)
        {
            return null;
        }

		#endregion
		#region	Actions
        protected virtual WizardNewResult<Order> DoQOrdersCreateNew1(ScreenActionCommand command)
        {
            var result = EntityManagementService.New(DomainWizards.OrdersWizard, DoQOrdersCreateNew1_SetParameters, DoQOrdersCreateNew1_SetDefaults);
            if (result.SaveToServerComplete)
            {
                QOrders.RaiseDataChanged();
            }
            
            return result;
        }
        
        protected virtual void DoQOrdersCreateNew1_SetDefaults(OrdersWizardParameters parameters, Order entity)
        {
        }
        
          
        protected virtual void DoQOrdersCreateNew1_SetParameters(OrdersWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQOrdersCreateNew1()
        {		 
           return true;
        }

        protected virtual void DoQOrdersActionView1(ScreenActionCommand command)
        {
        
            var key = QOrders.ActiveItem.Id;
            
            EntityManagementService.View(DomainWizards.OrdersWizard, key, DoQOrdersActionView1_SetParameters);
        }
          
        protected virtual void DoQOrdersActionView1_SetParameters(OrdersWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQOrdersActionView1()
        {		 
           if(!(QOrders.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual WizardEditResult<Order> DoQOrdersEdit1(ScreenActionCommand command)
        {
        
            var key = QOrders.ActiveItem.Id;
            var result = EntityManagementService.Edit(DomainWizards.OrdersWizard, key, DoQOrdersEdit1_SetParameters);
            if (result.SaveToServerComplete)
            {
                QOrders.UpdateActiveObject();
            }
            
            return result;
        }
          
        protected virtual void DoQOrdersEdit1_SetParameters(OrdersWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQOrdersEdit1()
        {		 
           if(!(QOrders.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual bool DoQOrdersDelete1(ScreenActionCommand command)
        {
        
            var keys = QOrders.SelectedItems.Select(obj => obj.Id).ToArray();
            
            var result = EntityManagementService.Delete<Order, int>(keys);
            if(result)
            {
                QOrders.RemoveSelectedObjects();
            }
            
            return result;
        }
        


        protected virtual bool CanExecuteQOrdersDelete1()
        {		 
           if(!(QOrders.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual void DoQOrdersRefresh1(ScreenActionCommand command)
        {
        
            QOrders.RaiseDataChanged();
        
        }

        protected virtual bool CanExecuteQOrdersRefresh1()
        {		 
           return true;
        }

        protected virtual void DoQOrdersOpenReports1(ScreenActionCommand command)
        {
        
            if (QOrders.ActiveItem == null || !ReportViewer.IsReportSupported(QOrders.ItemType))
            {
                return;
            }
        
            ReportViewer.OpenReportForm(QOrders.SelectedItems);
        }


        protected virtual bool CanExecuteQOrdersOpenReports1()
        {		 
           return true;
        }

        protected virtual ActionResult DoQOrdersPrintOrderInvoice(ScreenActionCommand command)
        {
            int id = QOrders.ActiveItem.Id;
            return ClientOrderManagerService.PrintOrderInvoice(id);
        }


        protected virtual bool CanExecuteQOrdersPrintOrderInvoice()
        {		 
           if(!(QOrders.ActiveItem != null))
           {
               return false;
           }
           int id = QOrders.ActiveItem.Id;
           
           return ClientOrderManagerService.PrintOrderInvoiceCanExecute(id);
        }

        protected virtual WizardNewResult<OrderDetail> DoQOrderProductsCreateNew1(ScreenActionCommand command)
        {
            var result = EntityManagementService.New(DomainWizards.OrderDetailsWizard, DoQOrderProductsCreateNew1_SetParameters, DoQOrderProductsCreateNew1_SetDefaults);
            if (result.SaveToServerComplete)
            {
                QOrderProducts.RaiseDataChanged();
            }
            
            return result;
        }
        
        protected virtual void DoQOrderProductsCreateNew1_SetDefaults(OrderDetailsWizardParameters parameters, OrderDetail entity)
        {
            entity.OrderID = QOrders.ActiveItem.Id;
        }
        
          
        protected virtual void DoQOrderProductsCreateNew1_SetParameters(OrderDetailsWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQOrderProductsCreateNew1()
        {		 
           if(!(QOrders.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual void DoQOrderProductsActionView1(ScreenActionCommand command)
        {
        
            var key = QOrderProducts.ActiveItem.Id;
            
            EntityManagementService.View(DomainWizards.OrderDetailsWizard, key, DoQOrderProductsActionView1_SetParameters);
        }
          
        protected virtual void DoQOrderProductsActionView1_SetParameters(OrderDetailsWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQOrderProductsActionView1()
        {		 
           if(!(QOrderProducts.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual WizardEditResult<OrderDetail> DoQOrderProductsEdit1(ScreenActionCommand command)
        {
        
            var key = QOrderProducts.ActiveItem.Id;
            var result = EntityManagementService.Edit(DomainWizards.OrderDetailsWizard, key, DoQOrderProductsEdit1_SetParameters);
            if (result.SaveToServerComplete)
            {
                QOrderProducts.UpdateActiveObject();
            }
            
            return result;
        }
          
        protected virtual void DoQOrderProductsEdit1_SetParameters(OrderDetailsWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQOrderProductsEdit1()
        {		 
           if(!(QOrderProducts.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual bool DoQOrderProductsDelete1(ScreenActionCommand command)
        {
        
            var keys = QOrderProducts.SelectedItems.Select(obj => obj.Id).ToArray();
            
            var result = EntityManagementService.Delete<OrderDetail, int>(keys);
            if(result)
            {
                QOrderProducts.RemoveSelectedObjects();
            }
            
            return result;
        }
        


        protected virtual bool CanExecuteQOrderProductsDelete1()
        {		 
           if(!(QOrderProducts.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual void DoQOrderProductsRefresh1(ScreenActionCommand command)
        {
        
            QOrderProducts.RaiseDataChanged();
        
        }

        protected virtual bool CanExecuteQOrderProductsRefresh1()
        {		 
           return true;
        }

        #endregion
    }
}