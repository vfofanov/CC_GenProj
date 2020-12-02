using BusinessFramework.Client.Contracts.Screens;
using FutureTechnologies.DI.Contracts;
using Northwind.Common.Screens;


namespace Northwind.Console
{
    partial class DependencyInjectionConfig
    {
        private static void ConfigureScreens(IClientContainerRegistrator registrator)
        {
            registrator.Transient<IScreenViewModel, CustomersScreenViewModel>("customers");
            registrator.Transient<IScreenViewModel, ShippersScreenViewModel>("shippers");
            registrator.Transient<IScreenViewModel, OrdersScreenViewModel>("orders");
            registrator.Transient<IScreenViewModel, TestDynamicColumnsScreenViewModel>("testDynamicColumns");
            registrator.Transient<IScreenViewModel, CategoriesScreenViewModel>("categories");
            registrator.Transient<IScreenViewModel, ProductsScreenViewModel>("products");
            registrator.Transient<IScreenViewModel, SuppliersScreenViewModel>("suppliers");
            registrator.Transient<IScreenViewModel, EmployeesScreenViewModel>("employees");
        }
    }
}