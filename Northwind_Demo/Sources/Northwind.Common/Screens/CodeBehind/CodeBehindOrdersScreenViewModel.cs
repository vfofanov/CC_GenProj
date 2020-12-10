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
    public abstract class CodeBehindOrdersScreenViewModel : ScreenViewModel
    {
        protected CodeBehindOrdersScreenViewModel(IEntityManagementService entityManagementService, IOrderProductQueryCollectionManager orderProductQueryCollectionManager, IOrdersQueryCollectionManager ordersQueryCollectionManager, IReportService reportService, IScreenCommandFactory screenCommandFactory, IServerActionRunService serverActionRunService, IShipperQueryCollectionManager shipperQueryCollectionManager)
        {
            EntityManagementService = entityManagementService;
            OrderProductQueryCollectionManager = orderProductQueryCollectionManager;
            OrdersQueryCollectionManager = ordersQueryCollectionManager;
            ReportService = reportService;
            ScreenCommandFactory = screenCommandFactory;
            ServerActionRunService = serverActionRunService;
            ShipperQueryCollectionManager = shipperQueryCollectionManager;

	        //DataBlocks
            QOrders = new MultiItemsScreenBlockViewModel<OrdersQuery, int>("qOrders", GetqOrdersData, OrdersQueryCollectionManager, GetqOrdersRowStyle);
			QOrders.PropertyChanged += OnqOrdersPropertyChanged;
            BlockRegion1 = new ActiveItemScreenBlockViewModel<OrdersQuery>("blockRegion1");
            QOrderProducts = new MultiItemsScreenBlockViewModel<OrderProductQuery, OrderProductQueryKey>("qOrderProducts", GetqOrderProductsData, OrderProductQueryCollectionManager, GetqOrderProductsRowStyle);
			QOrderProducts.PropertyChanged += OnqOrderProductsPropertyChanged;
            ShipperDetailRegion = new ActiveItemDataFuncScreenBlockViewModel<ShipperQuery>("shipperDetailRegion", GetshipperDetailRegionData);
            //Actions
            QOrdersCreateNew1 = ScreenCommandFactory.CreateFunc("qOrdersCreateNew1", DoQOrdersCreateNew1, CanExecuteQOrdersCreateNew1);
            QOrdersActionView1 = ScreenCommandFactory.Create("qOrdersActionView1", DoQOrdersActionView1, CanExecuteQOrdersActionView1);
            QOrdersEdit1MyButton = ScreenCommandFactory.CreateFunc("qOrdersEdit1MyButton", DoQOrdersEdit1MyButton, CanExecuteQOrdersEdit1MyButton);
            QOrdersDelete1 = ScreenCommandFactory.CreateFunc("qOrdersDelete1", DoQOrdersDelete1, CanExecuteQOrdersDelete1);
            QOrdersPrintOrderInvoice = ScreenCommandFactory.CreateFunc("qOrdersPrintOrderInvoice", DoQOrdersPrintOrderInvoice, CanExecuteQOrdersPrintOrderInvoice);
            QOrdersClientPrintWithWizardAction = ScreenCommandFactory.CreateFunc("qOrdersClientPrintWithWizardAction", DoQOrdersClientPrintWithWizardAction, CanExecuteQOrdersClientPrintWithWizardAction);
            QOrdersRefresh1 = ScreenCommandFactory.Create("qOrdersRefresh1", DoQOrdersRefresh1, CanExecuteQOrdersRefresh1);
            QOrderProductsCreateNew1 = ScreenCommandFactory.CreateFunc("qOrderProductsCreateNew1", DoQOrderProductsCreateNew1, CanExecuteQOrderProductsCreateNew1);
            QOrderProductsActionView1 = ScreenCommandFactory.Create("qOrderProductsActionView1", DoQOrderProductsActionView1, CanExecuteQOrderProductsActionView1);
            QOrderProductsEdit1 = ScreenCommandFactory.CreateFunc("qOrderProductsEdit1", DoQOrderProductsEdit1, CanExecuteQOrderProductsEdit1);
            QOrderProductsDelete1 = ScreenCommandFactory.CreateFunc("qOrderProductsDelete1", DoQOrderProductsDelete1, CanExecuteQOrderProductsDelete1);
            QOrderProductsRefresh1 = ScreenCommandFactory.Create("qOrderProductsRefresh1", DoQOrderProductsRefresh1, CanExecuteQOrderProductsRefresh1);
        }

		//Dependencies
        protected IEntityManagementService EntityManagementService { get; private set; }

        protected IOrderProductQueryCollectionManager OrderProductQueryCollectionManager { get; private set; }

        protected IOrdersQueryCollectionManager OrdersQueryCollectionManager { get; private set; }

        protected IReportService ReportService { get; private set; }

        protected IScreenCommandFactory ScreenCommandFactory { get; private set; }

        protected IServerActionRunService ServerActionRunService { get; private set; }

        protected IShipperQueryCollectionManager ShipperQueryCollectionManager { get; private set; }


	    //DataBlocks
        protected MultiItemsScreenBlockViewModel<OrdersQuery, int> QOrders { get; private set; }
        protected ActiveItemScreenBlockViewModel<OrdersQuery> BlockRegion1 { get; private set; }
        protected MultiItemsScreenBlockViewModel<OrderProductQuery, OrderProductQueryKey> QOrderProducts { get; private set; }
        protected ActiveItemDataFuncScreenBlockViewModel<ShipperQuery> ShipperDetailRegion { get; private set; }
        //Actions
        protected ScreenCommand QOrdersCreateNew1 { get; private set; }
        protected ScreenCommand QOrdersActionView1 { get; private set; }
        protected ScreenCommand QOrdersEdit1MyButton { get; private set; }
        protected ScreenCommand QOrdersDelete1 { get; private set; }
        protected ScreenCommand QOrdersPrintOrderInvoice { get; private set; }
        protected ScreenCommand QOrdersClientPrintWithWizardAction { get; private set; }
        protected ScreenCommand QOrdersRefresh1 { get; private set; }
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
		        case "qOrdersEdit1MyButton":
                    result = QOrdersEdit1MyButton;
					break;
		        case "qOrdersDelete1":
                    result = QOrdersDelete1;
					break;
		        case "qOrdersPrintOrderInvoice":
                    result = QOrdersPrintOrderInvoice;
					break;
		        case "qOrdersClientPrintWithWizardAction":
                    result = QOrdersClientPrintWithWizardAction;
					break;
		        case "qOrdersRefresh1":
                    result = QOrdersRefresh1;
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
        protected virtual IQueryable<OrdersQuery> GetqOrdersData(QuickFilter filter)
        {

            return OrdersQueryCollectionManager.GetObjects(filter);
        }

        protected virtual IRowStyle GetqOrdersRowStyle(OrdersQuery ordersQuery)
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

                if(QOrderProducts.IsEnabled)
			    {
			        QOrderProducts.RaiseDataChanged();
			    }
            }

            if(QOrdersActionView1.IsEnabled)
			{
			    QOrdersActionView1.RaiseCanExecuteChanged();
			}

            if(QOrdersEdit1MyButton.IsEnabled)
			{
			    QOrdersEdit1MyButton.RaiseCanExecuteChanged();
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
        protected virtual IRowStyle GetblockRegion1RowStyle(OrdersQuery ordersQuery)
        {
            return null;
        }

        protected virtual IQueryable<OrderProductQuery> GetqOrderProductsData(QuickFilter filter)
        {
            if(QOrders.ActiveItem == null)
			{
			    return null;
			}
            var cond1 = QOrders.ActiveItem.Id;

            return OrderProductQueryCollectionManager.GetObjects(filter).Where(obj => obj.OrderID == cond1);
        }

        protected virtual IRowStyle GetqOrderProductsRowStyle(OrderProductQuery orderProductQuery)
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
        protected virtual IQueryable<ShipperQuery> GetshipperDetailRegionData(QuickFilter filter)
        {
            if(QOrders.ActiveItem == null)
			{
			    return null;
			}
            var cond1 = QOrders.ActiveItem.ShipVia;

            return ShipperQueryCollectionManager.GetObjects(filter).Where(obj => obj.Id == cond1);
        }

        protected virtual IRowStyle GetshipperDetailRegionRowStyle(ShipperQuery shipperQuery)
        {
            return null;
        }

		#endregion
		#region	Actions
        protected virtual WizardNewResult<Orders> DoQOrdersCreateNew1(ScreenActionCommand command)
        {
            var result = EntityManagementService.New(DomainWizards.OrderWizard, DoQOrdersCreateNew1_SetParameters, DoQOrdersCreateNew1_SetDefaults);
            if (result.SaveToServerComplete)
            {
                QOrders.RaiseDataChanged();
            }
            
            return result;
        }
        
        protected virtual void DoQOrdersCreateNew1_SetDefaults(OrderWizardParameters parameters, Orders entity)
        {
        }
        
          
        protected virtual void DoQOrdersCreateNew1_SetParameters(OrderWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQOrdersCreateNew1()
        {		 
           return true;
        }

        protected virtual void DoQOrdersActionView1(ScreenActionCommand command)
        {
        
            var key = QOrders.ActiveItem.Id;
            
            EntityManagementService.View(DomainWizards.OrderWizard, key, DoQOrdersActionView1_SetParameters);
        }
          
        protected virtual void DoQOrdersActionView1_SetParameters(OrderWizardParameters parameters)
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

        protected virtual WizardEditResult<Orders> DoQOrdersEdit1MyButton(ScreenActionCommand command)
        {
        
            var key = QOrders.ActiveItem.Id;
            var result = EntityManagementService.Edit(DomainWizards.OrderWizard, key, DoQOrdersEdit1MyButton_SetParameters);
            if (result.SaveToServerComplete)
            {
                QOrders.UpdateActiveObject();
            }
            
            return result;
        }
          
        protected virtual void DoQOrdersEdit1MyButton_SetParameters(OrderWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQOrdersEdit1MyButton()
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
            
            var result = EntityManagementService.Delete<Orders, int>(keys);
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

        protected virtual ActionResult<Report> DoQOrdersPrintOrderInvoice(ScreenActionCommand command)
        {
            int id = QOrders.ActiveItem.Id;
            var waitMessage = ReportService.ServerPrintWithParameterGetWaitMessage();
        
            return ServerActionRunService.Run(() => ReportService.ServerPrintWithParameter(id), waitMessage, command.Title);
        }

        protected virtual bool CanExecuteQOrdersPrintOrderInvoice()
        {		 
           if(!(QOrders.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual WizardNewResult<ReportFormQuery> DoQOrdersClientPrintWithWizardAction(ScreenActionCommand command)
        {
            var result = EntityManagementService.New(DomainWizards.ReportFormQueryWizard, DoQOrdersClientPrintWithWizardAction_SetParameters, DoQOrdersClientPrintWithWizardAction_SetDefaults);
            if (result.SaveToServerComplete)
            {
                QOrders.RaiseDataChanged();
            }
            
            return result;
        }
        
        protected virtual void DoQOrdersClientPrintWithWizardAction_SetDefaults(ReportFormQueryWizardParameters parameters, ReportFormQuery entity)
        {
        }
        
          
        protected virtual void DoQOrdersClientPrintWithWizardAction_SetParameters(ReportFormQueryWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQOrdersClientPrintWithWizardAction()
        {		 
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

        protected virtual WizardNewResult<OrderDetails> DoQOrderProductsCreateNew1(ScreenActionCommand command)
        {
            var result = EntityManagementService.New(DomainWizards.OrderDetailWizard, DoQOrderProductsCreateNew1_SetParameters, DoQOrderProductsCreateNew1_SetDefaults);
            if (result.SaveToServerComplete)
            {
                QOrderProducts.RaiseDataChanged();
            }
            
            return result;
        }
        
        protected virtual void DoQOrderProductsCreateNew1_SetDefaults(OrderDetailWizardParameters parameters, OrderDetails entity)
        {
            entity.OrderID = QOrders.ActiveItem.Id;
        }
        
          
        protected virtual void DoQOrderProductsCreateNew1_SetParameters(OrderDetailWizardParameters parameters)
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
        
            var key = new OrderDetailsKey(QOrderProducts.ActiveItem.OrderID, QOrderProducts.ActiveItem.ProductID);
            
            EntityManagementService.View(DomainWizards.OrderDetailWizard, key, DoQOrderProductsActionView1_SetParameters);
        }
          
        protected virtual void DoQOrderProductsActionView1_SetParameters(OrderDetailWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQOrderProductsActionView1()
        {		 
           if(!(QOrderProducts.ActiveItem != null && QOrderProducts.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual WizardEditResult<OrderDetails> DoQOrderProductsEdit1(ScreenActionCommand command)
        {
        
            var key = new OrderDetailsKey(QOrderProducts.ActiveItem.OrderID, QOrderProducts.ActiveItem.ProductID);
            var result = EntityManagementService.Edit(DomainWizards.OrderDetailWizard, key, DoQOrderProductsEdit1_SetParameters);
            if (result.SaveToServerComplete)
            {
                QOrderProducts.UpdateActiveObject();
            }
            
            return result;
        }
          
        protected virtual void DoQOrderProductsEdit1_SetParameters(OrderDetailWizardParameters parameters)
        {
        }


        protected virtual bool CanExecuteQOrderProductsEdit1()
        {		 
           if(!(QOrderProducts.ActiveItem != null && QOrderProducts.ActiveItem != null))
           {
               return false;
           }
           return true;
        }

        protected virtual bool DoQOrderProductsDelete1(ScreenActionCommand command)
        {
        
            var keys = QOrderProducts.SelectedItems.Select(obj => new OrderDetailsKey(obj.OrderID, obj.ProductID)).ToArray();
            
            var result = EntityManagementService.Delete<OrderDetails, OrderDetailsKey>(keys);
            if(result)
            {
                QOrderProducts.RemoveSelectedObjects();
            }
            
            return result;
        }
        


        protected virtual bool CanExecuteQOrderProductsDelete1()
        {		 
           if(!(QOrderProducts.ActiveItem != null && QOrderProducts.ActiveItem != null))
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