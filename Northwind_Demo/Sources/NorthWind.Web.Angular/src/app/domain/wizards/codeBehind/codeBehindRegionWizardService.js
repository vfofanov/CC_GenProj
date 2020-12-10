export default class CodeBehindCodeBehindRegionWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, regionWizardInitialization, regionWizardFactory, regionValidationService) {
		Object.assign(this, {odataService, httpService, regionWizardInitialization, regionWizardFactory, regionValidationService});
	}

	customizeField(field, wizardContext) {
	}

	get objectFactory() {
		return this.regionWizardFactory;
	}

	get template() {
		return 'RegionWizard';		
	}

	get domainControllerName() {
		return "RegionApi";
	}

	get wizardInitializationService() {
		return this.regionWizardInitialization;
	}

	get wizardSettingsControllerName() {
		return "RegionWizardWizardSettings";
	}

	get validationService(){
		return "regionValidationService";
	}

	get entityName() {
		return "Region"
	}

}

