export default class CodeBehindCodeBehindCustomerCompactWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, customerCompactWizardInitialization, customerCompactWizardFactory, customersValidationService) {
		Object.assign(this, {odataService, httpService, customerCompactWizardInitialization, customerCompactWizardFactory, customersValidationService});
	}

	customizeField(field, wizardContext) {
	}

	get objectFactory() {
		return this.customerCompactWizardFactory;
	}

	get template() {
		return 'CustomerCompactWizard';		
	}

	get domainControllerName() {
		return "CustomersApi";
	}

	get wizardInitializationService() {
		return this.customerCompactWizardInitialization;
	}

	get wizardSettingsControllerName() {
		return "CustomerCompactWizardWizardSettings";
	}

	get validationService(){
		return "customersValidationService";
	}

	get entityName() {
		return "Customers"
	}

}

