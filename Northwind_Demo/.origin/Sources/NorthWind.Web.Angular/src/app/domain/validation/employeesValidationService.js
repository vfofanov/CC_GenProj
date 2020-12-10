export default class  EmployeesValidationService{
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

	LastName_Required (value, model) {
    if (angular.isDefined(value)){
	    return true;
    }
	return false;
    }

	FirstName_Required (value, model) {
    if (angular.isDefined(value)){
	    return true;
    }
	return false;
    }


}
