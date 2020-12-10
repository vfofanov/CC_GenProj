import CodeBehindRegionWizardService from './codeBehind/codeBehindRegionWizardService';

export default class RegionWizardService extends CodeBehindRegionWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, regionWizardInitialization, regionWizardFactory, regionValidationService) {
		"ngInject";
		super(odataService, httpService, regionWizardInitialization, regionWizardFactory, regionValidationService);
	}
}

