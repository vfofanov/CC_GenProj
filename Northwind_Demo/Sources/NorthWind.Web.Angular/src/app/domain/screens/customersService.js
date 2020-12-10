import CodeBehindCustomersService from './codeBehind/codeBehindCustomersService';

export default class CustomersService extends CodeBehindCustomersService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		$translate, stringFormat, enumsService, customerWizardService, domainManagementService, wizardManagementService) {
		"ngInject";
		super($translate, stringFormat, enumsService, customerWizardService, domainManagementService, wizardManagementService);
    }
}
