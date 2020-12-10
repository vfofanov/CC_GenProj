﻿using System;
using System.Collections.Generic;
using System.Linq;
using BusinessFramework.Client.Common.DomainModel;
using BusinessFramework.Client.Contracts.Connection;
using BusinessFramework.Client.Contracts.Services.Dialogs;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Services.Contracts.DomainModel;


namespace NorthWind.Client.ServerServices.DomainModel
{
    /// <inheritdoc cref="CodeBehind.CodeBehindShipperQueryCollectionManager" />
    public sealed class ShipperQueryCollectionManager : CodeBehind.CodeBehindShipperQueryCollectionManager, IShipperQueryCollectionManager
    {
	    /// <inheritdoc />
        public ShipperQueryCollectionManager(IControllerClientFactory clientFactory, IMessageBoxService messageBoxService) 
		    :base(clientFactory, messageBoxService)
        {
        }		 
    }
}