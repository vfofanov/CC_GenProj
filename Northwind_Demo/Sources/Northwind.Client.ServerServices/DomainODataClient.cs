using Microsoft.OData.Edm;
using System;
using BusinessFramework.Client.Connection;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Contracts.OData;


namespace Northwind.Client.ServerServices
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
                case "Northwind.WebAPI.Contracts.DataObjects.OrderStatus":
                    return typeof (OrderStatus);
                case "Northwind.WebAPI.Contracts.DataObjects.Product":
                    return typeof (Product);
                case "Northwind.WebAPI.Contracts.DataObjects.SysResetPasswordToken":
                    return typeof (SysResetPasswordToken);
                case "Northwind.WebAPI.Contracts.DataObjects.SysRole":
                    return typeof (SysRole);
                case "Northwind.WebAPI.Contracts.DataObjects.Customer":
                    return typeof (Customer);
                case "Northwind.WebAPI.Contracts.DataObjects.Category":
                    return typeof (Category);
                case "Northwind.WebAPI.Contracts.DataObjects.Supplier":
                    return typeof (Supplier);
                case "Northwind.WebAPI.Contracts.DataObjects.SysOperationLock":
                    return typeof (SysOperationLock);
                case "Northwind.WebAPI.Contracts.DataObjects.Order":
                    return typeof (Order);
                case "Northwind.WebAPI.Contracts.DataObjects.OrderDetail":
                    return typeof (OrderDetail);
                case "Northwind.WebAPI.Contracts.DataObjects.SysSetting":
                    return typeof (SysSetting);
                case "Northwind.WebAPI.Contracts.DataObjects.Employee":
                    return typeof (Employee);
                case "Northwind.WebAPI.Contracts.DataObjects.SysSettingProperty":
                    return typeof (SysSettingProperty);
                case "Northwind.WebAPI.Contracts.DataObjects.VSalesByCategory":
                    return typeof (VSalesByCategory);
                case "Northwind.WebAPI.Contracts.DataObjects.Shipper":
                    return typeof (Shipper);
                case "Northwind.WebAPI.Contracts.DataObjects.QSuppliers":
                    return typeof (QSuppliers);
                case "Northwind.WebAPI.Contracts.DataObjects.QEmployees":
                    return typeof (QEmployees);
                case "Northwind.WebAPI.Contracts.DataObjects.QShippers":
                    return typeof (QShippers);
                case "Northwind.WebAPI.Contracts.DataObjects.QCategories":
                    return typeof (QCategories);
                case "Northwind.WebAPI.Contracts.DataObjects.QCustomers":
                    return typeof (QCustomers);
                case "Northwind.WebAPI.Contracts.DataObjects.QProducts":
                    return typeof (QProducts);
                case "Northwind.WebAPI.Contracts.DataObjects.QOrderProducts":
                    return typeof (QOrderProducts);
                case "Northwind.WebAPI.Contracts.DataObjects.QOrders":
                    return typeof (QOrders);
                default:
                    return null;
            }
        }

        protected override string ResolveNameFromType(Type type)
        {
            switch (type.Name)
            {
                case "OrderStatus":
                    return "Northwind.WebAPI.Contracts.DataObjects.OrderStatus";
                case "Product":
                    return "Northwind.WebAPI.Contracts.DataObjects.Product";
                case "SysResetPasswordToken":
                    return "Northwind.WebAPI.Contracts.DataObjects.SysResetPasswordToken";
                case "SysRole":
                    return "Northwind.WebAPI.Contracts.DataObjects.SysRole";
                case "Customer":
                    return "Northwind.WebAPI.Contracts.DataObjects.Customer";
                case "Category":
                    return "Northwind.WebAPI.Contracts.DataObjects.Category";
                case "Supplier":
                    return "Northwind.WebAPI.Contracts.DataObjects.Supplier";
                case "SysOperationLock":
                    return "Northwind.WebAPI.Contracts.DataObjects.SysOperationLock";
                case "Order":
                    return "Northwind.WebAPI.Contracts.DataObjects.Order";
                case "OrderDetail":
                    return "Northwind.WebAPI.Contracts.DataObjects.OrderDetail";
                case "SysSetting":
                    return "Northwind.WebAPI.Contracts.DataObjects.SysSetting";
                case "Employee":
                    return "Northwind.WebAPI.Contracts.DataObjects.Employee";
                case "SysSettingProperty":
                    return "Northwind.WebAPI.Contracts.DataObjects.SysSettingProperty";
                case "VSalesByCategory":
                    return "Northwind.WebAPI.Contracts.DataObjects.VSalesByCategory";
                case "Shipper":
                    return "Northwind.WebAPI.Contracts.DataObjects.Shipper";
                case "QSuppliers":
                    return "Northwind.WebAPI.Contracts.DataObjects.QSuppliers";
                case "QEmployees":
                    return "Northwind.WebAPI.Contracts.DataObjects.QEmployees";
                case "QShippers":
                    return "Northwind.WebAPI.Contracts.DataObjects.QShippers";
                case "QCategories":
                    return "Northwind.WebAPI.Contracts.DataObjects.QCategories";
                case "QCustomers":
                    return "Northwind.WebAPI.Contracts.DataObjects.QCustomers";
                case "QProducts":
                    return "Northwind.WebAPI.Contracts.DataObjects.QProducts";
                case "QOrderProducts":
                    return "Northwind.WebAPI.Contracts.DataObjects.QOrderProducts";
                case "QOrders":
                    return "Northwind.WebAPI.Contracts.DataObjects.QOrders";
                default:
                    return null;
            }
        }
    }
}