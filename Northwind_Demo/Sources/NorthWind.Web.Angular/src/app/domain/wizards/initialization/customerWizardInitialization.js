import CodeBehindCustomerWizardInitialization from './codeBehind/codeBehindCustomerWizardInitialization';

export default class CustomerWizardInitialization extends CodeBehindCustomerWizardInitialization {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		httpService){
		"ngInject";
		super(httpService);
	}
}

