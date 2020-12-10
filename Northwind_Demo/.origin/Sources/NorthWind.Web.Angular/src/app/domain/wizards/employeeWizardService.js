import CodeBehindEmployeeWizardService from './codeBehind/codeBehindEmployeeWizardService';

export default class EmployeeWizardService extends CodeBehindEmployeeWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, employeeWizardInitialization, employeeWizardFactory, employeesValidationService) {
		"ngInject";
		super(odataService, httpService, employeeWizardInitialization, employeeWizardFactory, employeesValidationService);
	}
}

