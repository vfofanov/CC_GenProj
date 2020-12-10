import { restoreDefaultCanExecute, disableAll } from '../../../services/actions/actionConstructor';
export default class CodeBehindSuppliersService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		$translate, stringFormat, enumsService, domainManagementService, supplierWizardService, wizardManagementService) {
		"ngInject";
		Object.assign(this, {$translate, stringFormat, enumsService, domainManagementService, supplierWizardService, wizardManagementService});
    }

	//CreateNew
	blockRegion1CreateNew1 (declaration, contextState) {
        const options = {
            service: this.supplierWizardService,
            commitOnClose: true,
			onAfterOpen: () => {
				this.blockRegion1CreateNew1OnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.blockRegion1CreateNew1OnBeforeOpen(contextState);
			},
            contextParameters: { 
            }
		};
        return this.wizardManagementService.createNew(options);
	}

	blockRegion1CreateNew1OnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	blockRegion1CreateNew1OnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}
	blockRegion1CreateNew1PostExecute (result, declaration, contextState) {	
        return contextState.refresh(["blockRegion1"]);
	}

 	//View
	blockRegion1ActionView1 (declaration, contextState) {
        const options = {
            service: this.supplierWizardService,
			commitOnClose: true,
			onAfterOpen: () => {
				this.blockRegion1ActionView1OnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.blockRegion1ActionView1OnBeforeOpen(contextState);
			},
			contextParameters: {
			},
			entityKey: [contextState.blockRegion1.activeItem.Id]
        }
	   return this.wizardManagementService.view(options);
	}

	blockRegion1ActionView1OnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	blockRegion1ActionView1OnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}

	blockRegion1ActionView1CanExecute (contextState) {	
	   return contextState.blockRegion1 && contextState.blockRegion1.activeItem;
	}

	get blockRegion1ActionView1CanExecuteDependsOn() {
		 return  ['blockRegion1'];
	}


	//Edit
	blockRegion1Edit1 (declaration, contextState) {
        const options = {
            service: this.supplierWizardService,
			commitOnClose: true,
			onAfterOpen: () => {
				this.blockRegion1Edit1OnAfterOpen(contextState);
			},
			onBeforeOpen: () => {
				this.blockRegion1Edit1OnBeforeOpen(contextState);
			},
			contextParameters: {
			},
			entityKey: [contextState.blockRegion1.activeItem.Id]
        }
        return this.wizardManagementService.edit(options);
	}
	blockRegion1Edit1OnAfterOpen (contextState) {	
		restoreDefaultCanExecute(contextState.actions);
	}

	blockRegion1Edit1OnBeforeOpen (contextState) {	
		disableAll(contextState.actions);
	}

	blockRegion1Edit1PostExecute (result, declaration, contextState) {	
		return contextState.refreshItem("blockRegion1", result);
	}

	blockRegion1Edit1CanExecute (contextState) {	
	   return contextState.blockRegion1 && contextState.blockRegion1.activeItem;
	}
		
	get blockRegion1Edit1CanExecuteDependsOn() {
		return ['blockRegion1'];
	}
    //Delete
	blockRegion1Delete1 (declaration, contextState) {

       var keys = [contextState.blockRegion1.activeItem.Id];
	   
	   return this.domainManagementService.delete('SuppliersApi', keys);
	}
	blockRegion1Delete1PostExecute (result, declaration, contextState) {	
		return contextState.refresh(["blockRegion1"]);
	}

	blockRegion1Delete1CanExecute (contextState) {	
	   return contextState.blockRegion1 && contextState.blockRegion1.activeItem;
	}
		
	get blockRegion1Delete1CanExecuteDependsOn () {
	 return ['blockRegion1'];
	}


    //Refresh
	blockRegion1Refresh1 (declaration, contextState) {
	    return contextState.refresh([ 'blockRegion1' ]);
	}


}
