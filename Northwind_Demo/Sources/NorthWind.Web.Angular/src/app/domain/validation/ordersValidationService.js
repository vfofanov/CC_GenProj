export default class  OrdersValidationService{
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

	CustomerID_Required (value, model) {
    if (angular.isDefined(value)){
	    return true;
    }
	return false;
    }


}
