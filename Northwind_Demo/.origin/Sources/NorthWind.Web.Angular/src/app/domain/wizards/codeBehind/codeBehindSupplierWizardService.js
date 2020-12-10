export default class CodeBehindCodeBehindSupplierWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, supplierWizardInitialization, supplierWizardFactory, suppliersValidationService) {
		Object.assign(this, {odataService, httpService, supplierWizardInitialization, supplierWizardFactory, suppliersValidationService});
	}

	customizeField(field, wizardContext) {
	}

	get objectFactory() {
		return this.supplierWizardFactory;
	}

	get template() {
		return 'SupplierWizard';		
	}

	get domainControllerName() {
		return "SuppliersApi";
	}

	get wizardInitializationService() {
		return this.supplierWizardInitialization;
	}

	get wizardSettingsControllerName() {
		return "SupplierWizardWizardSettings";
	}

	get validationService(){
		return "suppliersValidationService";
	}

	get entityName() {
		return "Suppliers"
	}

}

