import CodeBehindOrderWizardInitialization from './codeBehind/codeBehindOrderWizardInitialization';

export default class OrderWizardInitialization extends CodeBehindOrderWizardInitialization {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		httpService){
		"ngInject";
		super(httpService);
	}
}

