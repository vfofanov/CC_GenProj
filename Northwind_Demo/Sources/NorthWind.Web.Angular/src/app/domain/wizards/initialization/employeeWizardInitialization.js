import CodeBehindEmployeeWizardInitialization from './codeBehind/codeBehindEmployeeWizardInitialization';

export default class EmployeeWizardInitialization extends CodeBehindEmployeeWizardInitialization {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		httpService){
		"ngInject";
		super(httpService);
	}
}

