export default class CodeBehindCodeBehindCustomerWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, customerWizardInitialization, customerWizardFactory, customersValidationService) {
		Object.assign(this, {odataService, httpService, customerWizardInitialization, customerWizardFactory, customersValidationService});
	}

	customizeField(field, wizardContext) {
	}

	get objectFactory() {
		return this.customerWizardFactory;
	}

	get template() {
		return 'CustomerWizard';		
	}

	get domainControllerName() {
		return "CustomersApi";
	}

	get wizardInitializationService() {
		return this.customerWizardInitialization;
	}

	get wizardSettingsControllerName() {
		return "CustomerWizardWizardSettings";
	}

	get validationService(){
		return "customersValidationService";
	}

	get entityName() {
		return "Customers"
	}

}

