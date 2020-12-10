import CodeBehindOrderWizardService from './codeBehind/codeBehindOrderWizardService';

export default class OrderWizardService extends CodeBehindOrderWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, orderWizardInitialization, orderWizardFactory, ordersValidationService) {
		"ngInject";
		super(odataService, httpService, orderWizardInitialization, orderWizardFactory, ordersValidationService);
	}
}

