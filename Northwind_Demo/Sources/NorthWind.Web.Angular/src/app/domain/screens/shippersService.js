import CodeBehindShippersService from './codeBehind/codeBehindShippersService';

export default class ShippersService extends CodeBehindShippersService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		$translate, stringFormat, enumsService, domainManagementService, shipperWizardService, wizardManagementService) {
		"ngInject";
		super($translate, stringFormat, enumsService, domainManagementService, shipperWizardService, wizardManagementService);
    }
}
