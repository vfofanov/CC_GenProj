import CodeBehindOrdersService from './codeBehind/codeBehindOrdersService';

export default class OrdersService extends CodeBehindOrdersService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		$translate, stringFormat, enumsService, domainManagementService, orderDetailWizardService, orderWizardService, reportFormQueryWizardService, reportService, wizardManagementService) {
		"ngInject";
		super($translate, stringFormat, enumsService, domainManagementService, orderDetailWizardService, orderWizardService, reportFormQueryWizardService, reportService, wizardManagementService);
    }
}
