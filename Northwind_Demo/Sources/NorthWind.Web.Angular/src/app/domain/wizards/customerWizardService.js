import CodeBehindCustomerWizardService from './codeBehind/codeBehindCustomerWizardService';

export default class CustomerWizardService extends CodeBehindCustomerWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, customerWizardInitialization, customerWizardFactory, customersValidationService) {
		"ngInject";
		super(odataService, httpService, customerWizardInitialization, customerWizardFactory, customersValidationService);
	}
}

