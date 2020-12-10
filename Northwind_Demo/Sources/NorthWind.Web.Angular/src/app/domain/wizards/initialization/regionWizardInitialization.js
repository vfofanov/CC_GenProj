import CodeBehindRegionWizardInitialization from './codeBehind/codeBehindRegionWizardInitialization';

export default class RegionWizardInitialization extends CodeBehindRegionWizardInitialization {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		httpService){
		"ngInject";
		super(httpService);
	}
}

