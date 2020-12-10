using System;
using System.Collections.Generic;
using System.Linq;
using NorthWind.WebApi.Tests.APITests.DataProviders;
using NorthWind.WebAPI.Contracts.DataObjects;
using NUnit.Framework;

namespace NorthWind.WebAPI.Tests.APITests.CRUDTests
{
    [TestFixture]
    public class CustomerWizardBaseTest : NorthWind.WebApi.Tests.APITests.CRUDTests.CodeBehind.CodeBehindCustomerWizardBaseTest
    {
        // ## TEMPLATE 
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
            base.CustomerWizardInvalidCreateTest(obj);
        }
        // ## TEMPLATE 

        // Optional
        public override Type EntityQuery()
        {
            return typeof(CustomerQuery);
        }

        // Optional
        public override void AssertEntityQuery(Customers obj, List<dynamic> queryEntity)
        {
            base.AssertEntityQuery(obj, queryEntity);
            
            // Example how to cast list of dynamic
            var queryList = queryEntity.Select(x=> Cast(x, EntityQuery())).ToList();

            // Some custom asserts
            //Assert.That(queryList[0].Fax, Is.Empty, "Fax is NOT empty");  // тут я не понял что мы хотели с Денисом проверять :(
        }

    }
}
