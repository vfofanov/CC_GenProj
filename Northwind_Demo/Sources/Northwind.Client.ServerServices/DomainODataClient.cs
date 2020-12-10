using Microsoft.OData.Edm;
using System;
using BusinessFramework.Client.Connection;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Contracts.OData;


namespace NorthWind.Client.ServerServices
{
    public sealed class DomainODataClient : ODataClient
    {
        public DomainODataClient(Uri rootUri)
            : base(rootUri)
        {
        }

        protected override IEdmModel GetEdmModel()
        {
            var edmReader = new EdmModelReader();
            return edmReader.ReadModel();
        }

        protected override Type ResolveTypeFromName(string typeName)
        {
            switch (typeName)
            {
                case "NorthWind.WebAPI.Contracts.DataObjects.Products":
                    return typeof (Products);
                case "NorthWind.WebAPI.Contracts.DataObjects.CustomerCustomerDemo":
                    return typeof (CustomerCustomerDemo);
                case "NorthWind.WebAPI.Contracts.DataObjects.SysResetPasswordToken":
                    return typeof (SysResetPasswordToken);
                case "NorthWind.WebAPI.Contracts.DataObjects.SysRole":
                    return typeof (SysRole);
                case "NorthWind.WebAPI.Contracts.DataObjects.Territory":
                    return typeof (Territory);
                case "NorthWind.WebAPI.Contracts.DataObjects.EmployeeTerritory":
                    return typeof (EmployeeTerritory);
                case "NorthWind.WebAPI.Contracts.DataObjects.Customers":
                    return typeof (Customers);
                case "NorthWind.WebAPI.Contracts.DataObjects.Categories":
                    return typeof (Categories);
                case "NorthWind.WebAPI.Contracts.DataObjects.Region":
                    return typeof (Region);
                case "NorthWind.WebAPI.Contracts.DataObjects.Suppliers":
                    return typeof (Suppliers);
                case "NorthWind.WebAPI.Contracts.DataObjects.SysOperationLock":
                    return typeof (SysOperationLock);
                case "NorthWind.WebAPI.Contracts.DataObjects.Orders":
                    return typeof (Orders);
                case "NorthWind.WebAPI.Contracts.DataObjects.OrderDetails":
                    return typeof (OrderDetails);
                case "NorthWind.WebAPI.Contracts.DataObjects.SysSetting":
                    return typeof (SysSetting);
                case "NorthWind.WebAPI.Contracts.DataObjects.Employees":
                    return typeof (Employees);
                case "NorthWind.WebAPI.Contracts.DataObjects.CustomerDemographic":
                    return typeof (CustomerDemographic);
                case "NorthWind.WebAPI.Contracts.DataObjects.SysSettingProperty":
                    return typeof (SysSettingProperty);
                case "NorthWind.WebAPI.Contracts.DataObjects.Shippers":
                    return typeof (Shippers);
                case "NorthWind.WebAPI.Contracts.DataObjects.SupplierQuery":
                    return typeof (SupplierQuery);
                case "NorthWind.WebAPI.Contracts.DataObjects.EmployeeQuery":
                    return typeof (EmployeeQuery);
                case "NorthWind.WebAPI.Contracts.DataObjects.ShipperQuery":
                    return typeof (ShipperQuery);
                case "NorthWind.WebAPI.Contracts.DataObjects.CategoryQuery":
                    return typeof (CategoryQuery);
                case "NorthWind.WebAPI.Contracts.DataObjects.ReportFormQuery":
                    return typeof (ReportFormQuery);
                case "NorthWind.WebAPI.Contracts.DataObjects.CustomerQuery":
                    return typeof (CustomerQuery);
                case "NorthWind.WebAPI.Contracts.DataObjects.ProductQuery":
                    return typeof (ProductQuery);
                case "NorthWind.WebAPI.Contracts.DataObjects.OrderProductQuery":
                    return typeof (OrderProductQuery);
                case "NorthWind.WebAPI.Contracts.DataObjects.OrdersQuery":
                    return typeof (OrdersQuery);
                case "NorthWind.WebAPI.Contracts.DataObjects.RegionQuery":
                    return typeof (RegionQuery);
                default:
                    return null;
            }
        }

        protected override string ResolveNameFromType(Type type)
        {
            switch (type.Name)
            {
                case "Products":
                    return "NorthWind.WebAPI.Contracts.DataObjects.Products";
                case "CustomerCustomerDemo":
                    return "NorthWind.WebAPI.Contracts.DataObjects.CustomerCustomerDemo";
                case "SysResetPasswordToken":
                    return "NorthWind.WebAPI.Contracts.DataObjects.SysResetPasswordToken";
                case "SysRole":
                    return "NorthWind.WebAPI.Contracts.DataObjects.SysRole";
                case "Territory":
                    return "NorthWind.WebAPI.Contracts.DataObjects.Territory";
                case "EmployeeTerritory":
                    return "NorthWind.WebAPI.Contracts.DataObjects.EmployeeTerritory";
                case "Customers":
                    return "NorthWind.WebAPI.Contracts.DataObjects.Customers";
                case "Categories":
                    return "NorthWind.WebAPI.Contracts.DataObjects.Categories";
                case "Region":
                    return "NorthWind.WebAPI.Contracts.DataObjects.Region";
                case "Suppliers":
                    return "NorthWind.WebAPI.Contracts.DataObjects.Suppliers";
                case "SysOperationLock":
                    return "NorthWind.WebAPI.Contracts.DataObjects.SysOperationLock";
                case "Orders":
                    return "NorthWind.WebAPI.Contracts.DataObjects.Orders";
                case "OrderDetails":
                    return "NorthWind.WebAPI.Contracts.DataObjects.OrderDetails";
                case "SysSetting":
                    return "NorthWind.WebAPI.Contracts.DataObjects.SysSetting";
                case "Employees":
                    return "NorthWind.WebAPI.Contracts.DataObjects.Employees";
                case "CustomerDemographic":
                    return "NorthWind.WebAPI.Contracts.DataObjects.CustomerDemographic";
                case "SysSettingProperty":
                    return "NorthWind.WebAPI.Contracts.DataObjects.SysSettingProperty";
                case "Shippers":
                    return "NorthWind.WebAPI.Contracts.DataObjects.Shippers";
                case "SupplierQuery":
                    return "NorthWind.WebAPI.Contracts.DataObjects.SupplierQuery";
                case "EmployeeQuery":
                    return "NorthWind.WebAPI.Contracts.DataObjects.EmployeeQuery";
                case "ShipperQuery":
                    return "NorthWind.WebAPI.Contracts.DataObjects.ShipperQuery";
                case "CategoryQuery":
                    return "NorthWind.WebAPI.Contracts.DataObjects.CategoryQuery";
                case "ReportFormQuery":
                    return "NorthWind.WebAPI.Contracts.DataObjects.ReportFormQuery";
                case "CustomerQuery":
                    return "NorthWind.WebAPI.Contracts.DataObjects.CustomerQuery";
                case "ProductQuery":
                    return "NorthWind.WebAPI.Contracts.DataObjects.ProductQuery";
                case "OrderProductQuery":
                    return "NorthWind.WebAPI.Contracts.DataObjects.OrderProductQuery";
                case "OrdersQuery":
                    return "NorthWind.WebAPI.Contracts.DataObjects.OrdersQuery";
                case "RegionQuery":
                    return "NorthWind.WebAPI.Contracts.DataObjects.RegionQuery";
                default:
                    return null;
            }
        }
    }
}