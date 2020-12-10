import CodeBehindProductWizardService from './codeBehind/codeBehindProductWizardService';

export default class ProductWizardService extends CodeBehindProductWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, productWizardInitialization, productWizardFactory, productsValidationService) {
		"ngInject";
		super(odataService, httpService, productWizardInitialization, productWizardFactory, productsValidationService);
	}
}

