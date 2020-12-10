export default class CodeBehindCodeBehindCategoryWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, categoryWizardInitialization, categoryWizardFactory, categoriesValidationService) {
		Object.assign(this, {odataService, httpService, categoryWizardInitialization, categoryWizardFactory, categoriesValidationService});
	}

	customizeField(field, wizardContext) {
	}

	get objectFactory() {
		return this.categoryWizardFactory;
	}

	get template() {
		return 'CategoryWizard';		
	}

	get domainControllerName() {
		return "CategoriesApi";
	}

	get wizardInitializationService() {
		return this.categoryWizardInitialization;
	}

	get wizardSettingsControllerName() {
		return "CategoryWizardWizardSettings";
	}

	get validationService(){
		return "categoriesValidationService";
	}

	get entityName() {
		return "Categories"
	}

}

