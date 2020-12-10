import { restoreDefaultCanExecute, disableAll } from '../../../services/actions/actionConstructor';
export default class CodeBehindOrdersService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		$translate, stringFormat, enumsService, domainManagementService, orderDetailWizardService, orderWizardService, reportFormQueryWizardService, reportService, wizardManagementService) {
		"ngInject";
		Object.assign(this, {$translate, stringFormat, enumsService, domainManagementService, orderDetailWizardService, orderWizardService, reportFormQueryWizardService, reportService, wizardManagementService});
    }

    blockRegion1CustomizeFields(fields) {
        // hideEmpty
	}

    shipperDetailRegionCustomizeFields(fields) {
        // hideEmpty
	}

	//CreateNew
	qOrdersCreateNew1 (declaration, contextState) {
        const options = {
            service: this.orderWizardService,
            commitOnClose: true,
			onAfterOpen: () => {
				this.qOrdersCreateNew1OnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qOrdersCreateNew1OnBeforeOpen(contextState);
			},
            contextParameters: { 
            }
		};
        return this.wizardManagementService.createNew(options);
	}

	qOrdersCreateNew1OnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qOrdersCreateNew1OnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}
	qOrdersCreateNew1PostExecute (result, declaration, contextState) {	
        return contextState.refresh(["qOrders"]);
	}

 	//View
	qOrdersActionView1 (declaration, contextState) {
        const options = {
            service: this.orderWizardService,
			commitOnClose: true,
			onAfterOpen: () => {
				this.qOrdersActionView1OnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qOrdersActionView1OnBeforeOpen(contextState);
			},
			contextParameters: {
			},
			entityKey: [contextState.qOrders.activeItem.Id]
        }
	   return this.wizardManagementService.view(options);
	}

	qOrdersActionView1OnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qOrdersActionView1OnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}

	qOrdersActionView1CanExecute (contextState) {	
	   return contextState.qOrders && contextState.qOrders.activeItem;
	}

	get qOrdersActionView1CanExecuteDependsOn() {
		 return  ['qOrders'];
	}


	//Edit
	qOrdersEdit1MyButton (declaration, contextState) {
        const options = {
            service: this.orderWizardService,
			commitOnClose: true,
			onAfterOpen: () => {
				this.qOrdersEdit1MyButtonOnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qOrdersEdit1MyButtonOnBeforeOpen(contextState);
			},
			contextParameters: {
			},
			entityKey: [contextState.qOrders.activeItem.Id]
        }
        return this.wizardManagementService.edit(options);
	}
	qOrdersEdit1MyButtonOnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qOrdersEdit1MyButtonOnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}

	qOrdersEdit1MyButtonPostExecute (result, declaration, contextState) {	
		return contextState.refreshItem("qOrders", result);
	}

	qOrdersEdit1MyButtonCanExecute (contextState) {	
	   return contextState.qOrders && contextState.qOrders.activeItem;
	}
		
	get qOrdersEdit1MyButtonCanExecuteDependsOn() {
		return ['qOrders'];
	}
    //Delete
	qOrdersDelete1 (declaration, contextState) {

       var keys = [contextState.qOrders.activeItem.Id];
	   
	   return this.domainManagementService.delete('OrdersApi', keys);
	}
	qOrdersDelete1PostExecute (result, declaration, contextState) {	
		return contextState.refresh(["qOrders"]);
	}

	qOrdersDelete1CanExecute (contextState) {	
	   return contextState.qOrders && contextState.qOrders.activeItem;
	}
		
	get qOrdersDelete1CanExecuteDependsOn () {
	 return ['qOrders'];
	}



	qOrdersPrintOrderInvoice (declaration, contextState){
	
		var id = contextState.qOrders.activeItem.Id;
		return this.reportService.serverPrintWithParameter(id);

		
	}


	//CreateNew
	qOrdersClientPrintWithWizardAction (declaration, contextState) {
        const options = {
            service: this.reportFormQueryWizardService,
            commitOnClose: true,
			onAfterOpen: () => {
				this.qOrdersClientPrintWithWizardActionOnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qOrdersClientPrintWithWizardActionOnBeforeOpen(contextState);
			},
            contextParameters: { 
            }
		};
        return this.wizardManagementService.createNew(options);
	}

	qOrdersClientPrintWithWizardActionOnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qOrdersClientPrintWithWizardActionOnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}
	qOrdersClientPrintWithWizardActionPostExecute (result, declaration, contextState) {	
        return contextState.refresh(["qOrders"]);
	}

    //Refresh
	qOrdersRefresh1 (declaration, contextState) {
	    return contextState.refresh([ 'qOrders' ]);
	}


	//CreateNew
	qOrderProductsCreateNew1 (declaration, contextState) {
        const options = {
            service: this.orderDetailWizardService,
            commitOnClose: true,
			onAfterOpen: () => {
				this.qOrderProductsCreateNew1OnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qOrderProductsCreateNew1OnBeforeOpen(contextState);
			},
            contextParameters: { 
            }
		};
        options.setContextDefaults = (model) => {
            model.OrderID = contextState.qOrders.activeItem.Id;
        };
        return this.wizardManagementService.createNew(options);
	}

	qOrderProductsCreateNew1OnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qOrderProductsCreateNew1OnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}
	qOrderProductsCreateNew1PostExecute (result, declaration, contextState) {	
        return contextState.refresh(["qOrderProducts"]);
	}
	qOrderProductsCreateNew1CanExecute (contextState) {	
        return contextState.qOrders && contextState.qOrders.activeItem;
	}

	get qOrderProductsCreateNew1CanExecuteDependsOn (){
        return  ['qOrders'];
	}

 	//View
	qOrderProductsActionView1 (declaration, contextState) {
        const options = {
            service: this.orderDetailWizardService,
			commitOnClose: true,
			onAfterOpen: () => {
				this.qOrderProductsActionView1OnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qOrderProductsActionView1OnBeforeOpen(contextState);
			},
			contextParameters: {
			},
			entityKey: [{ OrderID: contextState.qOrderProducts.activeItem.OrderID, ProductID: contextState.qOrderProducts.activeItem.ProductID }]
        }
	   return this.wizardManagementService.view(options);
	}

	qOrderProductsActionView1OnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qOrderProductsActionView1OnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}

	qOrderProductsActionView1CanExecute (contextState) {	
	   return contextState.qOrderProducts && contextState.qOrderProducts.activeItem;
	}

	get qOrderProductsActionView1CanExecuteDependsOn() {
		 return  ['qOrderProducts'];
	}


	//Edit
	qOrderProductsEdit1 (declaration, contextState) {
        const options = {
            service: this.orderDetailWizardService,
			commitOnClose: true,
			onAfterOpen: () => {
				this.qOrderProductsEdit1OnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qOrderProductsEdit1OnBeforeOpen(contextState);
			},
			contextParameters: {
			},
			entityKey: [{ OrderID: contextState.qOrderProducts.activeItem.OrderID, ProductID: contextState.qOrderProducts.activeItem.ProductID }]
        }
        return this.wizardManagementService.edit(options);
	}
	qOrderProductsEdit1OnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qOrderProductsEdit1OnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}

	qOrderProductsEdit1PostExecute (result, declaration, contextState) {	
		return contextState.refreshItem("qOrderProducts", result);
	}

	qOrderProductsEdit1CanExecute (contextState) {	
	   return contextState.qOrderProducts && contextState.qOrderProducts.activeItem;
	}
		
	get qOrderProductsEdit1CanExecuteDependsOn() {
		return ['qOrderProducts'];
	}
    //Delete
	qOrderProductsDelete1 (declaration, contextState) {

       var keys = [{ OrderID: contextState.qOrderProducts.activeItem.OrderID, ProductID: contextState.qOrderProducts.activeItem.ProductID }];
	   
	   return this.domainManagementService.delete('OrderDetailsApi', keys);
	}
	qOrderProductsDelete1PostExecute (result, declaration, contextState) {	
		return contextState.refresh(["qOrderProducts"]);
	}

	qOrderProductsDelete1CanExecute (contextState) {	
	   return contextState.qOrderProducts && contextState.qOrderProducts.activeItem;
	}
		
	get qOrderProductsDelete1CanExecuteDependsOn () {
	 return ['qOrderProducts'];
	}


    //Refresh
	qOrderProductsRefresh1 (declaration, contextState) {
	    return contextState.refresh([ 'qOrderProducts' ]);
	}


}
