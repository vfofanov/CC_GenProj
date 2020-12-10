import CodeBehindProductsService from './codeBehind/codeBehindProductsService';

export default class ProductsService extends CodeBehindProductsService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		$translate, stringFormat, enumsService, domainManagementService, productWizardService, wizardManagementService) {
		"ngInject";
		super($translate, stringFormat, enumsService, domainManagementService, productWizardService, wizardManagementService);
    }
}
