import CodeBehindProductWizardInitialization from './codeBehind/codeBehindProductWizardInitialization';

export default class ProductWizardInitialization extends CodeBehindProductWizardInitialization {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		httpService){
		"ngInject";
		super(httpService);
	}
}

