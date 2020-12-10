using BusinessFramework.Client.Contracts.DataObjects.Interfaces;
using BusinessFramework.Client.Contracts.Wizards;
using FutureTechnologies.DI.Contracts;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Common.Wizards;
using NorthWind.Contracts.DataObjects;
using NorthWind.Contracts.Enums;


namespace NorthWind.Console
{
    partial class DependencyInjectionConfig
    {
        private static void ConfigureWizards(IClientContainerRegistrator registrator)
        {
            registrator.Transient<IEntityWizard<Products, ProductWizardParameters>, Client.Wizards.ProductWizard.ProductWizard>(DomainWizards.Names.ProductWizard);
            registrator.Transient<IEntityWizard<Customers, CustomerWizardParameters>, Client.Wizards.CustomerWizard.CustomerWizard>(DomainWizards.Names.CustomerWizard);
            registrator.Transient<IEntityWizard<Employees, EmployeeWizardParameters>, Client.Wizards.EmployeeWizard.EmployeeWizard>(DomainWizards.Names.EmployeeWizard);
            registrator.Transient<IEntityWizard<Shippers, ShipperWizardParameters>, Client.Wizards.ShipperWizard.ShipperWizard>(DomainWizards.Names.ShipperWizard);
            registrator.Transient<IEntityWizard<OrderDetails, OrderDetailWizardParameters>, Client.Wizards.OrderDetailWizard.OrderDetailWizard>(DomainWizards.Names.OrderDetailWizard);
            registrator.Transient<IEntityWizard<Orders, OrderWizardParameters>, Client.Wizards.OrderWizard.OrderWizard>(DomainWizards.Names.OrderWizard);
            registrator.Transient<IEntityWizard<Categories, CategoryWizardParameters>, Client.Wizards.CategoryWizard.CategoryWizard>(DomainWizards.Names.CategoryWizard);
            registrator.Transient<IEntityWizard<Suppliers, SupplierWizardParameters>, Client.Wizards.SupplierWizard.SupplierWizard>(DomainWizards.Names.SupplierWizard);
            registrator.Transient<IEntityWizard<Customers, CustomerCompactWizardParameters>, Client.Wizards.CustomerCompactWizard.CustomerCompactWizard>(DomainWizards.Names.CustomerCompactWizard);
            registrator.Transient<IEntityWizard<Region, RegionWizardParameters>, Client.Wizards.RegionWizard.RegionWizard>(DomainWizards.Names.RegionWizard);
            registrator.Transient<IEntityWizard<ReportFormQuery, ReportFormQueryWizardParameters>, Client.Wizards.ReportFormQueryWizard.ReportFormQueryWizard>(DomainWizards.Names.ReportFormQueryWizard);

            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.ProductWizardInitialization>(DomainWizards.Names.ProductWizard);
            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.CustomerWizardInitialization>(DomainWizards.Names.CustomerWizard);
            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.EmployeeWizardInitialization>(DomainWizards.Names.EmployeeWizard);
            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.ShipperWizardInitialization>(DomainWizards.Names.ShipperWizard);
            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.OrderDetailWizardInitialization>(DomainWizards.Names.OrderDetailWizard);
            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.OrderWizardInitialization>(DomainWizards.Names.OrderWizard);
            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.CategoryWizardInitialization>(DomainWizards.Names.CategoryWizard);
            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.SupplierWizardInitialization>(DomainWizards.Names.SupplierWizard);
            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.CustomerCompactWizardInitialization>(DomainWizards.Names.CustomerCompactWizard);
            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.RegionWizardInitialization>(DomainWizards.Names.RegionWizard);
            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.ReportFormQueryWizardInitialization>(DomainWizards.Names.ReportFormQueryWizard);
        }
    }
}