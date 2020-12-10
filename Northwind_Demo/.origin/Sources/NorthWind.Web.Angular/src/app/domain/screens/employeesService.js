import CodeBehindEmployeesService from './codeBehind/codeBehindEmployeesService';

export default class EmployeesService extends CodeBehindEmployeesService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		$translate, stringFormat, enumsService, domainManagementService, employeeWizardService, wizardManagementService) {
		"ngInject";
		super($translate, stringFormat, enumsService, domainManagementService, employeeWizardService, wizardManagementService);
    }
}
