export default class  OrderDetailsValidationService{
	constructor($q, odataService, httpService){
		"ngInject";
		Object.assign(this, {$q, odataService, httpService});
	}

	OrderID_Required (value, model) {
    if (angular.isDefined(value)){
	    return true;
    }
	return false;
    }

	ProductID_Required (value, model) {
    if (angular.isDefined(value)){
	    return true;
    }
	return false;
    }

	UnitPrice_Required (value, model) {
    if (angular.isDefined(value)){
	    return true;
    }
	return false;
    }

	Quantity_Required (value, model) {
    if (angular.isDefined(value)){
	    return true;
    }
	return false;
    }

	Discount_Required (value, model) {
    if (angular.isDefined(value)){
	    return true;
    }
	return false;
    }


}
