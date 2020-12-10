import CodeBehindShipperWizardService from './codeBehind/codeBehindShipperWizardService';

export default class ShipperWizardService extends CodeBehindShipperWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, shipperWizardInitialization, shipperWizardFactory, shippersValidationService) {
		"ngInject";
		super(odataService, httpService, shipperWizardInitialization, shipperWizardFactory, shippersValidationService);
	}
}

