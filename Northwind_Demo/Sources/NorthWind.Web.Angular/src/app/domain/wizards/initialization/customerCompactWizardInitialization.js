import CodeBehindCustomerCompactWizardInitialization from './codeBehind/codeBehindCustomerCompactWizardInitialization';

export default class CustomerCompactWizardInitialization extends CodeBehindCustomerCompactWizardInitialization {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		httpService){
		"ngInject";
		super(httpService);
	}
}

