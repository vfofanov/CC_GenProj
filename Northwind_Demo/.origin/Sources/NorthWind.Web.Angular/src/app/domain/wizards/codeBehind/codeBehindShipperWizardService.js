export default class CodeBehindCodeBehindShipperWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, shipperWizardInitialization, shipperWizardFactory, shippersValidationService) {
		Object.assign(this, {odataService, httpService, shipperWizardInitialization, shipperWizardFactory, shippersValidationService});
	}

	customizeField(field, wizardContext) {
	}

	get objectFactory() {
		return this.shipperWizardFactory;
	}

	get template() {
		return 'ShipperWizard';		
	}

	get domainControllerName() {
		return "ShippersApi";
	}

	get wizardInitializationService() {
		return this.shipperWizardInitialization;
	}

	get wizardSettingsControllerName() {
		return "ShipperWizardWizardSettings";
	}

	get validationService(){
		return "shippersValidationService";
	}

	get entityName() {
		return "Shippers"
	}

}

