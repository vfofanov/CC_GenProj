export default class codeBehindOrderWizardFactory {
	getNew(){
		const result = {};
			result.OrderDate = new Date();
		return result;
	}
}
