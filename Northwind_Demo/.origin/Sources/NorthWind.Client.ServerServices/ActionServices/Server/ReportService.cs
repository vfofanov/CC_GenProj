using System;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Contracts.Actions;


namespace NorthWind.Client.ServerServices.ActionServices.Server
{

    /// <summary>
    /// 
    /// </summary>
    public sealed class ReportService : CodeBehind.CodeBehindReportService
    {    

        /// <summary>
        /// Ctor
        /// </summary>
        public ReportService(
            //--  custom dependencies
            //-- /custom dependencies
            IControllerClientFactory clientFactory)
            : base(clientFactory)
        {
        }
    }
}