﻿using System;
using System.Collections.Generic;
using BusinessFramework.Contracts.Actions;
using BusinessFramework.Contracts.Reporting;


namespace Northwind.WebAPI.ActionServices
{

    /// <summary>
    /// 
    /// </summary>
    public sealed class TestDynamicColumnsActionService : CodeBehind.CodeBehindTestDynamicColumnsActionService
    {
		/// <inheritdoc />
		public override ActionResult GetTestData(DateTime startDate, DateTime endDate, int periodQuantity)
		{
		    throw new NotImplementedException();
		}
    }
}