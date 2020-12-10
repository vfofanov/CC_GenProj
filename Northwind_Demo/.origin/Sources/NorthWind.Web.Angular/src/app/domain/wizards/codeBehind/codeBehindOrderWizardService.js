export default class CodeBehindCodeBehindOrderWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, orderWizardInitialization, orderWizardFactory, ordersValidationService) {
		Object.assign(this, {odataService, httpService, orderWizardInitialization, orderWizardFactory, ordersValidationService});
	}

	customizeField(field, wizardContext) {
	}

	get objectFactory() {
		return this.orderWizardFactory;
	}

	get template() {
		return 'OrderWizard';		
	}

	get domainControllerName() {
		return "OrdersApi";
	}

	get wizardInitializationService() {
		return this.orderWizardInitialization;
	}

	get wizardSettingsControllerName() {
		return "OrderWizardWizardSettings";
	}

	get validationService(){
		return "ordersValidationService";
	}

	get entityName() {
		return "Orders"
	}

   page1_CustomerIDData(wizardState) {
	
	    return 'CustomerQuery?$select=Id,CompanyName';	    
	}
	get page1_CustomerIDDataDependsOn(){
		return [];
	}
   page1_EmployeeIDData(wizardState) {
	
	    return 'EmployeeQuery?$select=Id,Employee_FullName';	    
	}
	get page1_EmployeeIDDataDependsOn(){
		return [];
	}
   page2_ShipViaData(wizardState) {
	
	    return 'Shippers?$select=Id,CompanyName&$orderby=CompanyName';	    
	}
	get page2_ShipViaDataDependsOn(){
		return [];
	}
}

