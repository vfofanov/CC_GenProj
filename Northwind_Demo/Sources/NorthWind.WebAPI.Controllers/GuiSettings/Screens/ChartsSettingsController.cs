﻿using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
using BusinessFramework.Contracts.GuiSettings.Actions;
using BusinessFramework.Contracts.GuiSettings.Fields;
using BusinessFramework.Contracts.GuiSettings.Json;
using BusinessFramework.Contracts.GuiSettings.Screens;
using BusinessFramework.Contracts.GuiSettings.Screens.DataBlocks;
using BusinessFramework.WebAPI.Common.GuiSettings;
using BusinessFramework.WebAPI.Common.Request;
using BusinessFramework.WebAPI.Common.Security;
using BusinessFramework.WebAPI.Contracts.Security;
using BusinessFramework.WebAPI.GuiSettingsControllers;
using NorthWind.Contracts;
using NorthWind.WebAPI.Contracts;
using NorthWind.WebAPI.Controllers.Properties;

// ReSharper disable UnusedParameter.Local

namespace NorthWind.WebAPI.Controllers.GuiSettings.Screens
{
    /// <summary>
    ///  Charts screen settings controller
    /// </summary>
    public sealed class ChartsSettingsController : GuiSettingsBaseApiController<DomainPermissions>
    {
	    /// <summary>
        ///     Ctor
        /// </summary>
        /// <param name="requestInitializer"></param>
        /// <param name="securityService"></param>
        public ChartsSettingsController(IRequestStorageInitializer requestInitializer, ISecurityService securityService)
            : base(requestInitializer, securityService)
        {
        }

        /// <summary>
        /// Get settings for 'Charts' screen
        /// </summary>
        /// <returns></returns>		
        public IHttpActionResult Get()
        {            
            if (!(Security.AuthorizeAll(DomainPermissions.Customers_Read)))
            {
                return GetInternalForbiddenResult();
            }

		    var context = new ScreenSettingsContext();
            var result = new Screen
            {
                Name = "charts",
				Title = ScreenResources.Charts_DisplayName,

                Content = GetScreenChildren(context)
            };

            return Json(result, GuiSettingsJsonSettings.WriteSettings);
        }
        
		private ScreenItem GetScreenChildren(ScreenSettingsContext context)
        {
		        var item = new DataBlock 
                {
				    Name = "blockRegion1",
				    Controller = "Customers",
				    Content = GetBlockRegion1Content(context),
                };
				           
			    if (item.Content != null)
				{
				    return item;
				}
            return null;
	    
        }
		private DataBlockContent GetBlockRegion1Content(ScreenSettingsContext context)
        {
		    
            if (!(Security.AuthorizeAll(DomainPermissions.Customers_Read)))
            {
			    return null;
			}
            var categories = new ChartDataBlockContentSeries
			{
			    Field = new Field {Name = "CompanyName", Key = DomainObjectPropertyKeys.Customers.CompanyName, DataType = FieldDataType.String},
				Title = "Company Name",
				Format = 0,
			};

            var series = new List<ChartDataBlockContentSeries>(1);

            series.Add(new ChartDataBlockContentSeries
			{
			    Field = new Field {Name = "Id", Key = DomainObjectPropertyKeys.Customers.Id, DataType = FieldDataType.Integer},
				Title = "Id",
			});
		    return new ChartDataBlockContent
			{
                Title  = "",
                ChartType = ChartDataBlockContentType.Pie,
                Category = categories,
			    Series = series.ToArray()
			};

        }
    }
}
