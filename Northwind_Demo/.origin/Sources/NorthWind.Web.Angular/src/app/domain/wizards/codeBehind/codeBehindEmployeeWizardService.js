export default class CodeBehindCodeBehindEmployeeWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, employeeWizardInitialization, employeeWizardFactory, employeesValidationService) {
		Object.assign(this, {odataService, httpService, employeeWizardInitialization, employeeWizardFactory, employeesValidationService});
	}

	customizeField(field, wizardContext) {
	}

	get objectFactory() {
		return this.employeeWizardFactory;
	}

	get template() {
		return 'EmployeeWizard';		
	}

	get domainControllerName() {
		return "EmployeesApi";
	}

	get wizardInitializationService() {
		return this.employeeWizardInitialization;
	}

	get wizardSettingsControllerName() {
		return "EmployeeWizardWizardSettings";
	}

	get validationService(){
		return "employeesValidationService";
	}

	get entityName() {
		return "Employees"
	}

}

