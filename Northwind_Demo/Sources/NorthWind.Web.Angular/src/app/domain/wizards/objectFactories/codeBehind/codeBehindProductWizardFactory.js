export default class codeBehindProductWizardFactory {
	getNew(){
		const result = {};
			result.UnitsInStock = 0;
			result.UnitsOnOrder = 0;
			result.ReorderLevel = 0;
			result.Discontinued = false;
		return result;
	}
}
