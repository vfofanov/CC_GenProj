import CodeBehindReportService from './codeBehind/codeBehindReportService';

export default class ReportService extends CodeBehindReportService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		customActionRunner) {
		"ngInject";	
		super(customActionRunner);
	}
}


