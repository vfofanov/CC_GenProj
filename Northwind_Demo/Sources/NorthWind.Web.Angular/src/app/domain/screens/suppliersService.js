import CodeBehindSuppliersService from './codeBehind/codeBehindSuppliersService';

export default class SuppliersService extends CodeBehindSuppliersService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		$translate, stringFormat, enumsService, domainManagementService, supplierWizardService, wizardManagementService) {
		"ngInject";
		super($translate, stringFormat, enumsService, domainManagementService, supplierWizardService, wizardManagementService);
    }
}
