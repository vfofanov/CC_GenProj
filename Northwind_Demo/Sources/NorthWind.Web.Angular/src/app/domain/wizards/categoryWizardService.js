import CodeBehindCategoryWizardService from './codeBehind/codeBehindCategoryWizardService';

export default class CategoryWizardService extends CodeBehindCategoryWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, categoryWizardInitialization, categoryWizardFactory, categoriesValidationService) {
		"ngInject";
		super(odataService, httpService, categoryWizardInitialization, categoryWizardFactory, categoriesValidationService);
	}
}

