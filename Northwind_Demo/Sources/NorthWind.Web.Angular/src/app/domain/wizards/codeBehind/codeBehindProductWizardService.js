export default class CodeBehindCodeBehindProductWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, productWizardInitialization, productWizardFactory, productsValidationService) {
		Object.assign(this, {odataService, httpService, productWizardInitialization, productWizardFactory, productsValidationService});
	}

	customizeField(field, wizardContext) {
	}

	get objectFactory() {
		return this.productWizardFactory;
	}

	get template() {
		return 'ProductWizard';		
	}

	get domainControllerName() {
		return "ProductsApi";
	}

	get wizardInitializationService() {
		return this.productWizardInitialization;
	}

	get wizardSettingsControllerName() {
		return "ProductWizardWizardSettings";
	}

	get validationService(){
		return "productsValidationService";
	}

	get entityName() {
		return "Products"
	}

   page1_CategoryIDData(wizardState) {
	
	    return 'Categories?$select=Id,CategoryName';	    
	}
	get page1_CategoryIDDataDependsOn(){
		return [];
	}
   page1_SupplierIDData(wizardState) {
	
	    return 'Suppliers?$select=Id,CompanyName';	    
	}
	get page1_SupplierIDDataDependsOn(){
		return [];
	}
}

