import CodeBehindOrderDetailWizardService from './codeBehind/codeBehindOrderDetailWizardService';

export default class OrderDetailWizardService extends CodeBehindOrderDetailWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, orderDetailWizardInitialization, orderDetailWizardFactory, orderDetailsValidationService) {
		"ngInject";
		super(odataService, httpService, orderDetailWizardInitialization, orderDetailWizardFactory, orderDetailsValidationService);
	}
}

