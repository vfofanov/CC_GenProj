using System;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Contracts.Actions;


namespace Northwind.Client.ServerServices.ActionServices.Server
{

    /// <summary>
    /// 
    /// </summary>
    public sealed class TestDynamicColumnsActionService : CodeBehind.CodeBehindTestDynamicColumnsActionService
    {    

        /// <summary>
        /// Ctor
        /// </summary>
        public TestDynamicColumnsActionService(
            //--  custom dependencies
            //-- /custom dependencies
            IControllerClientFactory clientFactory)
            : base(clientFactory)
        {
        }
    }
}