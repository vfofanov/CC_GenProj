import CodeBehindShipperWizardInitialization from './codeBehind/codeBehindShipperWizardInitialization';

export default class ShipperWizardInitialization extends CodeBehindShipperWizardInitialization {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		httpService){
		"ngInject";
		super(httpService);
	}
}

