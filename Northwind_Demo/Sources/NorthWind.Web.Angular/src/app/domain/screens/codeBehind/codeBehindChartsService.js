import { restoreDefaultCanExecute, disableAll } from '../../../services/actions/actionConstructor';
export default class CodeBehindChartsService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		$translate, stringFormat, enumsService, ) {
		"ngInject";
		Object.assign(this, {$translate, stringFormat, enumsService, });
    }

}
