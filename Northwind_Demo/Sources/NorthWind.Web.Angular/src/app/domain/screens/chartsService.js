import CodeBehindChartsService from './codeBehind/codeBehindChartsService';

export default class ChartsService extends CodeBehindChartsService{
	constructor(
		//--  custom dependencies
		//-- /custom dependencies
		$translate, stringFormat, enumsService, ) {
		"ngInject";
		super($translate, stringFormat, enumsService, );
    }
}
