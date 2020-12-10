import CodeBehindCategoriesService from './codeBehind/codeBehindCategoriesService';

export default class CategoriesService extends CodeBehindCategoriesService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		$translate, stringFormat, enumsService, categoryWizardService, domainManagementService, productWizardService, reportManagementService, wizardManagementService) {
		"ngInject";
		super($translate, stringFormat, enumsService, categoryWizardService, domainManagementService, productWizardService, reportManagementService, wizardManagementService);
    }
}
