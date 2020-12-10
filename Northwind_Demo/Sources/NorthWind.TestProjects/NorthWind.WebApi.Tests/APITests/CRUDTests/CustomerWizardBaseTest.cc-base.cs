using System.Collections.Generic;
using NorthWind.WebAPI.Contracts.DataObjects;
using NorthWind.WebApi.Tests.APITests.DataProviders;
using NUnit.Framework;

namespace NorthWind.WebApi.Tests.APITests.CRUDTests
{
	[TestFixture]
	public class CustomerWizardBaseTest: CodeBehind.CodeBehindCustomerWizardBaseTest
	{
        [Test,
         TestCaseSource(typeof(CustomerWizardDataProvider), @"GetValidData")]
        // nameof(CodeBehindCustomerWizardDataProvider.GetValidData))]  //AM: disable C#6 syntax till VS reinstall
        public override void CustomerWizardValidCreateTest(Customers obj)
        {
            base.CustomerWizardValidCreateTest(obj);
        }

        [Test,
        TestCaseSource(typeof(CustomerWizardDataProvider), @"GetInvalidData")] // nameof(CodeBehindCustomerWizardDataProvider.GetInvalidData))] //AM: disable C#6 syntax till VS reinstall
        public override void CustomerWizardInvalidCreateTest(Customers obj)
        {
//			base.CustomerWizardInvalidCreateTest(obj);
        }		
	}
}


