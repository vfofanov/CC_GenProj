import CodeBehindOrderDetailWizardInitialization from './codeBehind/codeBehindOrderDetailWizardInitialization';

export default class OrderDetailWizardInitialization extends CodeBehindOrderDetailWizardInitialization {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		httpService){
		"ngInject";
		super(httpService);
	}
}

