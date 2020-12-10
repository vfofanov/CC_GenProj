import { restoreDefaultCanExecute, disableAll } from '../../../services/actions/actionConstructor';
export default class CodeBehindCustomersService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		$translate, stringFormat, enumsService, customerWizardService, domainManagementService, wizardManagementService) {
		"ngInject";
		Object.assign(this, {$translate, stringFormat, enumsService, customerWizardService, domainManagementService, wizardManagementService});
    }

	//CreateNew
	qCustomersWizardCreateNew (declaration, contextState) {
        const options = {
            service: this.customerWizardService,
            commitOnClose: true,
			onAfterOpen: () => {
				this.qCustomersWizardCreateNewOnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qCustomersWizardCreateNewOnBeforeOpen(contextState);
			},
            contextParameters: { 
            }
		};
        return this.wizardManagementService.createNew(options);
	}

	qCustomersWizardCreateNewOnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qCustomersWizardCreateNewOnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}
	qCustomersWizardCreateNewPostExecute (result, declaration, contextState) {	
        return contextState.refresh(["qCustomers"]);
	}

 	//View
	qCustomersWizardView (declaration, contextState) {
        const options = {
            service: this.customerWizardService,
			commitOnClose: true,
			onAfterOpen: () => {
				this.qCustomersWizardViewOnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qCustomersWizardViewOnBeforeOpen(contextState);
			},
			contextParameters: {
			},
			entityKey: [contextState.qCustomers.activeItem.Id]
        }
	   return this.wizardManagementService.view(options);
	}

	qCustomersWizardViewOnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qCustomersWizardViewOnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}

	qCustomersWizardViewCanExecute (contextState) {	
	   return contextState.qCustomers && contextState.qCustomers.activeItem;
	}

	get qCustomersWizardViewCanExecuteDependsOn() {
		 return  ['qCustomers'];
	}


	//Edit
	qCustomersWizardEdit (declaration, contextState) {
        const options = {
            service: this.customerWizardService,
			commitOnClose: true,
			onAfterOpen: () => {
				this.qCustomersWizardEditOnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qCustomersWizardEditOnBeforeOpen(contextState);
			},
			contextParameters: {
			},
			entityKey: [contextState.qCustomers.activeItem.Id]
        }
        return this.wizardManagementService.edit(options);
	}
	qCustomersWizardEditOnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qCustomersWizardEditOnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}

	qCustomersWizardEditPostExecute (result, declaration, contextState) {	
		return contextState.refreshItem("qCustomers", result);
	}

	qCustomersWizardEditCanExecute (contextState) {	
	   return contextState.qCustomers && contextState.qCustomers.activeItem;
	}
		
	get qCustomersWizardEditCanExecuteDependsOn() {
		return ['qCustomers'];
	}
    //Delete
	qCustomersDeleteEntity (declaration, contextState) {

       var keys = [contextState.qCustomers.activeItem.Id];
	   
	   return this.domainManagementService.delete('CustomersApi', keys);
	}
	qCustomersDeleteEntityPostExecute (result, declaration, contextState) {	
		return contextState.refresh(["qCustomers"]);
	}

	qCustomersDeleteEntityCanExecute (contextState) {	
	   return contextState.qCustomers && contextState.qCustomers.activeItem;
	}
		
	get qCustomersDeleteEntityCanExecuteDependsOn () {
	 return ['qCustomers'];
	}


    //Refresh
	qCustomersRefresh (declaration, contextState) {
	    return contextState.refresh([ 'qCustomers' ]);
	}


}
