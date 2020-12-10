export default class CodeBehindCodeBehindReportFormQueryWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, reportFormQueryWizardInitialization, reportFormQueryWizardFactory, reportFormQueryValidationService) {
		Object.assign(this, {odataService, httpService, reportFormQueryWizardInitialization, reportFormQueryWizardFactory, reportFormQueryValidationService});
	}

	customizeField(field, wizardContext) {
	}

	get objectFactory() {
		return this.reportFormQueryWizardFactory;
	}

	get template() {
		return 'ReportFormQueryWizard';		
	}

	get domainControllerName() {
		return "ReportFormQueryApi";
	}

	get wizardInitializationService() {
		return this.reportFormQueryWizardInitialization;
	}

	get wizardSettingsControllerName() {
		return "ReportFormQueryWizardWizardSettings";
	}

	get validationService(){
		return "reportFormQueryValidationService";
	}

	get entityName() {
		return "ReportFormQuery"
	}

   page1_EmployeeIdData(wizardState) {
	
	    return 'Employees?$select=Id,FirstName';	    
	}
	get page1_EmployeeIdDataDependsOn(){
		return [];
	}
   page1_CustomerIdData(wizardState) {
	
	    return 'Customers?$select=Id,CompanyName';	    
	}
	get page1_CustomerIdDataDependsOn(){
		return [];
	}
}

