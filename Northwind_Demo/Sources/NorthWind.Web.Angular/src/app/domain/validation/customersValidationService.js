export default class  CustomersValidationService{
	constructor($q, odataService, httpService){
		"ngInject";
		Object.assign(this, {$q, odataService, httpService});
	}

	Id_Required (value, model) {
    if (angular.isDefined(value)){
	    return true;
    }
	return false;
    }

	CompanyName_Required (value, model) {
    if (angular.isDefined(value)){
	    return true;
    }
	return false;
    }


}
