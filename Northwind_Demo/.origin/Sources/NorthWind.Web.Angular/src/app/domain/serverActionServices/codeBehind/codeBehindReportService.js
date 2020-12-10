export default class CodeBehindReportService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		customActionRunner) {
		this.customActionRunner = customActionRunner;
		this.serviceRoute = 'reportservice';
	}
		serverPrintSimple (){
			const path = `${this.serviceRoute}/serverprintsimple`;
			return this.customActionRunner.runReportAction(path);
		}
		ServerPrintSimpleCanExecute (){
		    return true;
		}
		ServerPrintSimpleGetConfirmMessage (){
		    return null;
		}
		serverPrintWithParameter ( id){
			const path = `${this.serviceRoute}/serverprintwithparameter?id=${encodeURI(id)}`;
			return this.customActionRunner.runReportAction(path);
		}
		ServerPrintWithParameterCanExecute (){
		    return true;
		}
		ServerPrintWithParameterGetConfirmMessage (){
		    return null;
		}
		serverPrintWithForm ( employeeId,  fromDate,  toDate,  useExcel,  customerId){
			const path = `${this.serviceRoute}/serverprintwithform?employeeId=${encodeURI(employeeId)}&fromDate=${encodeURI(fromDate)}&toDate=${encodeURI(toDate)}&useExcel=${encodeURI(useExcel)}&customerId=${encodeURI(customerId)}`;
			return this.customActionRunner.runReportAction(path);
		}
		ServerPrintWithFormCanExecute (){
		    return true;
		}
		ServerPrintWithFormGetConfirmMessage (){
		    return null;
		}
}


