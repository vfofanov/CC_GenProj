import CodeBehindclientOrderManagerService from "./codeBehind/codeBehindclientOrderManagerService"

export default class ClientOrderManagerService extends CodeBehindclientOrderManagerService {
	constructor(
		//--  custom dependencies
		reportManagementService, 
    	//-- /custom dependencies
		customActionRunner){
		"ngInject";
		super(customActionRunner);
		this.reportManagementService = reportManagementService;
	}

    clientPrintSimple (){
        return this.reportManagementService.printReport('ReportWithoutParameters');
    }

    clientPrintWithForm(){
    	const parameters = [
    		{name: "dateFrom", title: "Date from", dataType: 6, editorType: 4 },
            {name: "dateTo", title: "Date to", dataType: 6, editorType: 4 }
		];
        return this.reportManagementService.printReportWithParameters('ReportWithParameters', parameters, 'Report with parameters');
	}
	
	clientPrintWithParameter (id) {
		return this.reportManagementService.printReport('PrintOrderInvoice', {id: id});
	}
	

}
