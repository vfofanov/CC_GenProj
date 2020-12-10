import { restoreDefaultCanExecute, disableAll } from '../../../services/actions/actionConstructor';
export default class CodeBehindProductsService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		$translate, stringFormat, enumsService, domainManagementService, productWizardService, wizardManagementService) {
		"ngInject";
		Object.assign(this, {$translate, stringFormat, enumsService, domainManagementService, productWizardService, wizardManagementService});
    }

    qCategoriesCustomizeFields(fields) {
        // hideEmpty
	}

    qSuppliersCustomizeFields(fields) {
        // hideEmpty
	}

	//CreateNew
	qProductsWizardCreateNew (declaration, contextState) {
        const options = {
            service: this.productWizardService,
            commitOnClose: true,
			onAfterOpen: () => {
				this.qProductsWizardCreateNewOnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qProductsWizardCreateNewOnBeforeOpen(contextState);
			},
            contextParameters: { 
            }
		};
        return this.wizardManagementService.createNew(options);
	}

	qProductsWizardCreateNewOnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qProductsWizardCreateNewOnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}
	qProductsWizardCreateNewPostExecute (result, declaration, contextState) {	
        return contextState.refresh(["qProducts"]);
	}

 	//View
	qProductsWizardView (declaration, contextState) {
        const options = {
            service: this.productWizardService,
			commitOnClose: true,
			onAfterOpen: () => {
				this.qProductsWizardViewOnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qProductsWizardViewOnBeforeOpen(contextState);
			},
			contextParameters: {
			},
			entityKey: [contextState.qProducts.activeItem.Id]
        }
	   return this.wizardManagementService.view(options);
	}

	qProductsWizardViewOnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qProductsWizardViewOnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}

	qProductsWizardViewCanExecute (contextState) {	
	   return contextState.qProducts && contextState.qProducts.activeItem;
	}

	get qProductsWizardViewCanExecuteDependsOn() {
		 return  ['qProducts'];
	}


	//Edit
	qProductsWizardEdit (declaration, contextState) {
        const options = {
            service: this.productWizardService,
			commitOnClose: true,
			onAfterOpen: () => {
				this.qProductsWizardEditOnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qProductsWizardEditOnBeforeOpen(contextState);
			},
			contextParameters: {
			},
			entityKey: [contextState.qProducts.activeItem.Id]
        }
        return this.wizardManagementService.edit(options);
	}
	qProductsWizardEditOnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qProductsWizardEditOnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}

	qProductsWizardEditPostExecute (result, declaration, contextState) {	
		return contextState.refreshItem("qProducts", result);
	}

	qProductsWizardEditCanExecute (contextState) {	
	   return contextState.qProducts && contextState.qProducts.activeItem;
	}
		
	get qProductsWizardEditCanExecuteDependsOn() {
		return ['qProducts'];
	}
    //Delete
	qProductsDeleteEntity (declaration, contextState) {

       var keys = [contextState.qProducts.activeItem.Id];
	   
	   return this.domainManagementService.delete('ProductsApi', keys);
	}
	qProductsDeleteEntityPostExecute (result, declaration, contextState) {	
		return contextState.refresh(["qProducts"]);
	}

	qProductsDeleteEntityCanExecute (contextState) {	
	   return contextState.qProducts && contextState.qProducts.activeItem;
	}
		
	get qProductsDeleteEntityCanExecuteDependsOn () {
	 return ['qProducts'];
	}


    //Refresh
	qProductsRefresh (declaration, contextState) {
	    return contextState.refresh([ 'qProducts' ]);
	}


}
