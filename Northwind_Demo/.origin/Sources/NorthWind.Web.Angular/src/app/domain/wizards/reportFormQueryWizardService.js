import CodeBehindReportFormQueryWizardService from './codeBehind/codeBehindReportFormQueryWizardService';

export default class ReportFormQueryWizardService extends CodeBehindReportFormQueryWizardService {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		odataService, httpService, reportFormQueryWizardInitialization, reportFormQueryWizardFactory, reportFormQueryValidationService) {
		"ngInject";
		super(odataService, httpService, reportFormQueryWizardInitialization, reportFormQueryWizardFactory, reportFormQueryValidationService);
	}
}

