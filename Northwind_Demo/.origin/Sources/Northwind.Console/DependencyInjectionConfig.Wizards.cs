using BusinessFramework.Client.Contracts.DataObjects.Interfaces;
using BusinessFramework.Client.Contracts.Wizards;
using FutureTechnologies.DI.Contracts;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Common.Wizards;
using Northwind.Contracts.DataObjects;
using Northwind.Contracts.Enums;


namespace Northwind.Console
{
    partial class DependencyInjectionConfig
    {
        private static void ConfigureWizards(IClientContainerRegistrator registrator)
        {
            registrator.Transient<IEntityWizard<Product, ProductsWizardParameters>, Client.Wizards.ProductsWizard.ProductsWizard>(DomainWizards.Names.ProductsWizard);
            registrator.Transient<IEntityWizard<Customer, CustomersWizardParameters>, Client.Wizards.CustomersWizard.CustomersWizard>(DomainWizards.Names.CustomersWizard);
            registrator.Transient<IEntityWizard<Employee, EmployeesWizardParameters>, Client.Wizards.EmployeesWizard.EmployeesWizard>(DomainWizards.Names.EmployeesWizard);
            registrator.Transient<IEntityWizard<Shipper, ShippersWizardParameters>, Client.Wizards.ShippersWizard.ShippersWizard>(DomainWizards.Names.ShippersWizard);
            registrator.Transient<IEntityWizard<OrderDetail, OrderDetailsWizardParameters>, Client.Wizards.OrderDetailsWizard.OrderDetailsWizard>(DomainWizards.Names.OrderDetailsWizard);
            registrator.Transient<IEntityWizard<Order, OrdersWizardParameters>, Client.Wizards.OrdersWizard.OrdersWizard>(DomainWizards.Names.OrdersWizard);
            registrator.Transient<IEntityWizard<Category, CategoriesWizardParameters>, Client.Wizards.CategoriesWizard.CategoriesWizard>(DomainWizards.Names.CategoriesWizard);
            registrator.Transient<IEntityWizard<Supplier, SuppliersWizardParameters>, Client.Wizards.SuppliersWizard.SuppliersWizard>(DomainWizards.Names.SuppliersWizard);

            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.ProductsWizardInitialization>(DomainWizards.Names.ProductsWizard);
            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.CustomersWizardInitialization>(DomainWizards.Names.CustomersWizard);
            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.EmployeesWizardInitialization>(DomainWizards.Names.EmployeesWizard);
            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.ShippersWizardInitialization>(DomainWizards.Names.ShippersWizard);
            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.OrderDetailsWizardInitialization>(DomainWizards.Names.OrderDetailsWizard);
            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.OrdersWizardInitialization>(DomainWizards.Names.OrdersWizard);
            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.CategoriesWizardInitialization>(DomainWizards.Names.CategoriesWizard);
            registrator.PerSession<IWizardInitialization, Common.Wizards.Initialization.SuppliersWizardInitialization>(DomainWizards.Names.SuppliersWizard);
        }
    }
}