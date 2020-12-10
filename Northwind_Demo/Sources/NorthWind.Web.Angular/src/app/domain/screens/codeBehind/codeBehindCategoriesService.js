import { restoreDefaultCanExecute, disableAll } from '../../../services/actions/actionConstructor';
export default class CodeBehindCategoriesService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		$translate, stringFormat, enumsService, categoryWizardService, domainManagementService, productWizardService, reportManagementService, wizardManagementService) {
		"ngInject";
		Object.assign(this, {$translate, stringFormat, enumsService, categoryWizardService, domainManagementService, productWizardService, reportManagementService, wizardManagementService});
    }

	//CreateNew
	qCategoriesCreateNew1 (declaration, contextState) {
        const options = {
            service: this.categoryWizardService,
            commitOnClose: true,
			onAfterOpen: () => {
				this.qCategoriesCreateNew1OnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qCategoriesCreateNew1OnBeforeOpen(contextState);
			},
            contextParameters: { 
            }
		};
        return this.wizardManagementService.createNew(options);
	}

	qCategoriesCreateNew1OnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qCategoriesCreateNew1OnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}
	qCategoriesCreateNew1PostExecute (result, declaration, contextState) {	
        return contextState.refresh(["qCategories"]);
	}

 	//View
	qCategoriesActionView1 (declaration, contextState) {
        const options = {
            service: this.categoryWizardService,
			commitOnClose: true,
			onAfterOpen: () => {
				this.qCategoriesActionView1OnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qCategoriesActionView1OnBeforeOpen(contextState);
			},
			contextParameters: {
			},
			entityKey: [contextState.qCategories.activeItem.Id]
        }
	   return this.wizardManagementService.view(options);
	}

	qCategoriesActionView1OnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qCategoriesActionView1OnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}

	qCategoriesActionView1CanExecute (contextState) {	
	   return contextState.qCategories && contextState.qCategories.activeItem;
	}

	get qCategoriesActionView1CanExecuteDependsOn() {
		 return  ['qCategories'];
	}


	//Edit
	qCategoriesEdit1 (declaration, contextState) {
        const options = {
            service: this.categoryWizardService,
			commitOnClose: true,
			onAfterOpen: () => {
				this.qCategoriesEdit1OnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qCategoriesEdit1OnBeforeOpen(contextState);
			},
			contextParameters: {
			},
			entityKey: [contextState.qCategories.activeItem.Id]
        }
        return this.wizardManagementService.edit(options);
	}
	qCategoriesEdit1OnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qCategoriesEdit1OnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}

	qCategoriesEdit1PostExecute (result, declaration, contextState) {	
		return contextState.refreshItem("qCategories", result);
	}

	qCategoriesEdit1CanExecute (contextState) {	
	   return contextState.qCategories && contextState.qCategories.activeItem;
	}
		
	get qCategoriesEdit1CanExecuteDependsOn() {
		return ['qCategories'];
	}
    //Delete
	qCategoriesDelete1 (declaration, contextState) {

       var keys = [contextState.qCategories.activeItem.Id];
	   
	   return this.domainManagementService.delete('CategoriesApi', keys);
	}
	qCategoriesDelete1PostExecute (result, declaration, contextState) {	
		return contextState.refresh(["qCategories"]);
	}

	qCategoriesDelete1CanExecute (contextState) {	
	   return contextState.qCategories && contextState.qCategories.activeItem;
	}
		
	get qCategoriesDelete1CanExecuteDependsOn () {
	 return ['qCategories'];
	}


    //Refresh
	qCategoriesRefresh1 (declaration, contextState) {
	    return contextState.refresh([ 'qCategories' ]);
	}


	//CreateNew
	qProductsCreateNew1 (declaration, contextState) {
        const options = {
            service: this.productWizardService,
            commitOnClose: true,
			onAfterOpen: () => {
				this.qProductsCreateNew1OnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qProductsCreateNew1OnBeforeOpen(contextState);
			},
            contextParameters: { 
            }
		};
        options.setContextDefaults = (model) => {
            model.CategoryID = contextState.qCategories.activeItem.Id;
        };
        return this.wizardManagementService.createNew(options);
	}

	qProductsCreateNew1OnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qProductsCreateNew1OnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}
	qProductsCreateNew1PostExecute (result, declaration, contextState) {	
        return contextState.refresh(["qProducts"]);
	}
	qProductsCreateNew1CanExecute (contextState) {	
        return contextState.qCategories && contextState.qCategories.activeItem;
	}

	get qProductsCreateNew1CanExecuteDependsOn (){
        return  ['qCategories'];
	}

 	//View
	qProductsActionView1 (declaration, contextState) {
        const options = {
            service: this.productWizardService,
			commitOnClose: true,
			onAfterOpen: () => {
				this.qProductsActionView1OnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qProductsActionView1OnBeforeOpen(contextState);
			},
			contextParameters: {
			},
			entityKey: [contextState.qProducts.activeItem.Id]
        }
	   return this.wizardManagementService.view(options);
	}

	qProductsActionView1OnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qProductsActionView1OnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}

	qProductsActionView1CanExecute (contextState) {	
	   return contextState.qProducts && contextState.qProducts.activeItem;
	}

	get qProductsActionView1CanExecuteDependsOn() {
		 return  ['qProducts'];
	}


	//Edit
	qProductsEdit1 (declaration, contextState) {
        const options = {
            service: this.productWizardService,
			commitOnClose: true,
			onAfterOpen: () => {
				this.qProductsEdit1OnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qProductsEdit1OnBeforeOpen(contextState);
			},
			contextParameters: {
			},
			entityKey: [contextState.qProducts.activeItem.Id]
        }
        return this.wizardManagementService.edit(options);
	}
	qProductsEdit1OnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qProductsEdit1OnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}

	qProductsEdit1PostExecute (result, declaration, contextState) {	
		return contextState.refreshItem("qProducts", result);
	}

	qProductsEdit1CanExecute (contextState) {	
	   return contextState.qProducts && contextState.qProducts.activeItem;
	}
		
	get qProductsEdit1CanExecuteDependsOn() {
		return ['qProducts'];
	}
    //Delete
	qProductsDelete1 (declaration, contextState) {

       var keys = [contextState.qProducts.activeItem.Id];
	   
	   return this.domainManagementService.delete('ProductsApi', keys);
	}
	qProductsDelete1PostExecute (result, declaration, contextState) {	
		return contextState.refresh(["qProducts"]);
	}

	qProductsDelete1CanExecute (contextState) {	
	   return contextState.qProducts && contextState.qProducts.activeItem;
	}
		
	get qProductsDelete1CanExecuteDependsOn () {
	 return ['qProducts'];
	}


    //Refresh
	qProductsRefresh1 (declaration, contextState) {
	    return contextState.refresh([ 'qProducts' ]);
	}


}
