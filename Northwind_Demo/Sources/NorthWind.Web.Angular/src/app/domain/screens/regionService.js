import CodeBehindRegionService from './codeBehind/codeBehindRegionService';

export default class RegionService extends CodeBehindRegionService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		$translate, stringFormat, enumsService, regionWizardService, wizardManagementService) {
		"ngInject";
		super($translate, stringFormat, enumsService, regionWizardService, wizardManagementService);
    }
}
