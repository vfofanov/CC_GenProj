export default class  ProductsValidationService{
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

	ProductName_Required (value, model) {
    if (angular.isDefined(value)){
	    return true;
    }
	return false;
    }

	Discontinued_Required (value, model) {
    if (angular.isDefined(value)){
	    return true;
    }
	return false;
    }


}
