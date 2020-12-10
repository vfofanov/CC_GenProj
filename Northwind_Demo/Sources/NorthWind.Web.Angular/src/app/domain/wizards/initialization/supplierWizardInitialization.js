import CodeBehindSupplierWizardInitialization from './codeBehind/codeBehindSupplierWizardInitialization';

export default class SupplierWizardInitialization extends CodeBehindSupplierWizardInitialization {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		httpService){
		"ngInject";
		super(httpService);
	}
}

