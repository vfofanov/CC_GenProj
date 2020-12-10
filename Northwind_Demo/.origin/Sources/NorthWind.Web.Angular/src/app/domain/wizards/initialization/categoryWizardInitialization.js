import CodeBehindCategoryWizardInitialization from './codeBehind/codeBehindCategoryWizardInitialization';

export default class CategoryWizardInitialization extends CodeBehindCategoryWizardInitialization {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		httpService){
		"ngInject";
		super(httpService);
	}
}

