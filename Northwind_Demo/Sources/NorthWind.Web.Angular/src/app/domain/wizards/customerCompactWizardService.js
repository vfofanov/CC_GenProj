import CodeBehindCustomerCompactWizardService from './codeBehind/codeBehindCustomerCompactWizardService';

export default class CustomerCompactWizardService extends CodeBehindCustomerCompactWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, customerCompactWizardInitialization, customerCompactWizardFactory, customersValidationService) {
		"ngInject";
		super(odataService, httpService, customerCompactWizardInitialization, customerCompactWizardFactory, customersValidationService);
	}
}

