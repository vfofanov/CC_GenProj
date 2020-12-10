import { restoreDefaultCanExecute, disableAll } from '../../../services/actions/actionConstructor';
export default class CodeBehindEmployeesService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		$translate, stringFormat, enumsService, domainManagementService, employeeWizardService, wizardManagementService) {
		"ngInject";
		Object.assign(this, {$translate, stringFormat, enumsService, domainManagementService, employeeWizardService, wizardManagementService});
    }

    qEmployees1CustomizeFields(fields) {
        // hideEmpty
	}

	//CreateNew
	qEmployeesWizardCreateNew (declaration, contextState) {
        const options = {
            service: this.employeeWizardService,
            commitOnClose: true,
			onAfterOpen: () => {
				this.qEmployeesWizardCreateNewOnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qEmployeesWizardCreateNewOnBeforeOpen(contextState);
			},
            contextParameters: { 
            }
		};
        return this.wizardManagementService.createNew(options);
	}

	qEmployeesWizardCreateNewOnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qEmployeesWizardCreateNewOnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}
	qEmployeesWizardCreateNewPostExecute (result, declaration, contextState) {	
        return contextState.refresh(["qEmployees"]);
	}

 	//View
	qEmployeesWizardView (declaration, contextState) {
        const options = {
            service: this.employeeWizardService,
			commitOnClose: true,
			onAfterOpen: () => {
				this.qEmployeesWizardViewOnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qEmployeesWizardViewOnBeforeOpen(contextState);
			},
			contextParameters: {
			},
			entityKey: [contextState.qEmployees.activeItem.Id]
        }
	   return this.wizardManagementService.view(options);
	}

	qEmployeesWizardViewOnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qEmployeesWizardViewOnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}

	qEmployeesWizardViewCanExecute (contextState) {	
	   return contextState.qEmployees && contextState.qEmployees.activeItem;
	}

	get qEmployeesWizardViewCanExecuteDependsOn() {
		 return  ['qEmployees'];
	}


	//Edit
	qEmployeesWizardEdit (declaration, contextState) {
        const options = {
            service: this.employeeWizardService,
			commitOnClose: true,
			onAfterOpen: () => {
				this.qEmployeesWizardEditOnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qEmployeesWizardEditOnBeforeOpen(contextState);
			},
			contextParameters: {
			},
			entityKey: [contextState.qEmployees.activeItem.Id]
        }
        return this.wizardManagementService.edit(options);
	}
	qEmployeesWizardEditOnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	qEmployeesWizardEditOnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}

	qEmployeesWizardEditPostExecute (result, declaration, contextState) {	
		return contextState.refreshItem("qEmployees", result);
	}

	qEmployeesWizardEditCanExecute (contextState) {	
	   return contextState.qEmployees && contextState.qEmployees.activeItem;
	}
		
	get qEmployeesWizardEditCanExecuteDependsOn() {
		return ['qEmployees'];
	}
    //Delete
	qEmployeesDeleteEntity (declaration, contextState) {

       var keys = [contextState.qEmployees.activeItem.Id];
	   
	   return this.domainManagementService.delete('EmployeesApi', keys);
	}
	qEmployeesDeleteEntityPostExecute (result, declaration, contextState) {	
		return contextState.refresh(["qEmployees"]);
	}

	qEmployeesDeleteEntityCanExecute (contextState) {	
	   return contextState.qEmployees && contextState.qEmployees.activeItem;
	}
		
	get qEmployeesDeleteEntityCanExecuteDependsOn () {
	 return ['qEmployees'];
	}


    //Refresh
	qEmployeesRefresh (declaration, contextState) {
	    return contextState.refresh([ 'qEmployees' ]);
	}


}
