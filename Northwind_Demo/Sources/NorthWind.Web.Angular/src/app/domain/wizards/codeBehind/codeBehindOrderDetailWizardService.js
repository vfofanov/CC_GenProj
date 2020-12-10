export default class CodeBehindCodeBehindOrderDetailWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, orderDetailWizardInitialization, orderDetailWizardFactory, orderDetailsValidationService) {
		Object.assign(this, {odataService, httpService, orderDetailWizardInitialization, orderDetailWizardFactory, orderDetailsValidationService});
	}

	customizeField(field, wizardContext) {
	}

	get objectFactory() {
		return this.orderDetailWizardFactory;
	}

	get template() {
		return 'OrderDetailWizard';		
	}

	get domainControllerName() {
		return "OrderDetailsApi";
	}

	get wizardInitializationService() {
		return this.orderDetailWizardInitialization;
	}

	get wizardSettingsControllerName() {
		return "OrderDetailWizardWizardSettings";
	}

	get validationService(){
		return "orderDetailsValidationService";
	}

	get entityName() {
		return "OrderDetails"
	}

   page1_ProductIDData(wizardState) {
	
	    return 'ProductQuery?$select=Id,ProductName';	    
	}
	get page1_ProductIDDataDependsOn(){
		return [];
	}
}

