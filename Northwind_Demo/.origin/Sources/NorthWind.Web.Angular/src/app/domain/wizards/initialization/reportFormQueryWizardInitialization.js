import CodeBehindReportFormQueryWizardInitialization from './codeBehind/codeBehindReportFormQueryWizardInitialization';

export default class ReportFormQueryWizardInitialization extends CodeBehindReportFormQueryWizardInitialization {
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		httpService){
		"ngInject";
		super(httpService);
	}
}

