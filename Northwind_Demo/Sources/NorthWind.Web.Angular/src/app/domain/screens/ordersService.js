import CodeBehindOrdersService from './codeBehind/codeBehindOrdersService';

export default class OrdersService extends CodeBehindOrdersService{
	constructor(
		//--  custom dependencies
		customActionRunner,
		//-- /custom dependencies
		$translate, stringFormat, enumsService, domainManagementService, orderDetailWizardService, orderWizardService, reportFormQueryWizardService, reportService, wizardManagementService) {
		"ngInject";
		super($translate, stringFormat, enumsService, domainManagementService, orderDetailWizardService, orderWizardService, reportFormQueryWizardService, reportService, wizardManagementService);
		
		this.customActionRunner = customActionRunner;
    }
	
	
	qOrdersClientPrintWithWizardAction (declaration, contextState) {
        const options = {
            service: this.reportFormQueryWizardService,
            commitOnClose: false, // Set to false, so default api method won't be called
			onAfterOpen: () => {
				this.qOrdersClientPrintWithWizardActionOnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.qOrdersClientPrintWithWizardActionOnBeforeOpen(contextState);
			},
            contextParameters: { 
            }
		};
		 
		return this.wizardManagementService.createNew(options).then(result => {
			
			var fromDate = null;
			if( typeof result.model.From !== 'undefined' ) {
               fromDate = result.model.From.toDateString();
            }
			
			var toDate = null;
			if( typeof result.model.To !== 'undefined' ) {
               toDate = result.model.To.toDateString();
            }
			
			var useExcel = false;
			if( typeof result.model.useExcel !== 'undefined' ) {
               useExcel =result.model.useExcel;
            }
			
			const path = `reportservice/serverprintwithform?employeeid=${encodeURI(result.model.EmployeeId)}&customerid=${encodeURI(result.model.CustomerId)}&fromdate=${encodeURI(fromDate)}&todate=${encodeURI(toDate)}&useExcel=${encodeURI(useExcel)}`;
			return this.customActionRunner.runReportAction(path)
		});
	}
	
}
