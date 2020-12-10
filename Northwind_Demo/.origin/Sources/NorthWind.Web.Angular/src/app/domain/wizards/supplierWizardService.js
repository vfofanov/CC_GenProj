import CodeBehindSupplierWizardService from './codeBehind/codeBehindSupplierWizardService';

export default class SupplierWizardService extends CodeBehindSupplierWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, supplierWizardInitialization, supplierWizardFactory, suppliersValidationService) {
		"ngInject";
		super(odataService, httpService, supplierWizardInitialization, supplierWizardFactory, suppliersValidationService);
	}
}

