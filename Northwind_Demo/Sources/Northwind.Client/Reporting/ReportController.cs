using System;
using System.IO;
using BusinessFramework.Client.Contracts.Reporting;
using NorthWind.Client.Contracts.BusinessObjects;
using NorthWind.Client.Reporting.Controllers.Object;
using ReportingFramework.Client.ReportSystem;


namespace NorthWind.Client.Reporting
{
    public sealed class ReportController : BusinessFramework.Client.Contracts.Reporting.ReportController
    {
        public static class ObjectControllerNames
        {
            public const string Categories = "categories";
            public const string CategoriesList = "categories_list";
            public const string CategoriesAll = "categories_all";
            public const string Orders = "orders";
            public const string OrdersList = "orders_list";
            public const string OrdersAll = "orders_all";
            public const string CategoryQuery = "categoryquery";
            public const string CategoryQueryList = "categoryquery_list";
            public const string CategoryQueryAll = "categoryquery_all";
            public const string OrdersQuery = "ordersquery";
            public const string OrdersQueryList = "ordersquery_list";
            public const string OrdersQueryAll = "ordersquery_all";
            public const string ReportFormQuery = "reportformquery";
            public const string ReportFormQueryList = "reportformquery_list";
            public const string ReportFormQueryAll = "reportformquery_all";
        }

        public override Guid Guid
        {
            get { return new Guid("e671bc4c-4422-4630-9dd5-9ecce95fc2aa"); }
        }
        public override string ModuleName
        {
            get { return "NorthWind"; }
        }
        
        public override void FillObjectDescriptors(IObjectControllerDescriptorHolder holder)
        {
            holder.AddDescriptor<Categories,int>(ObjectControllerNames.Categories,
                item => new CategoriesObjController(item),
                ObjectControllerNames.CategoriesList,
                ObjectControllerNames.CategoriesAll,
                list => new CategoriesObjListController(list));            

            holder.AddDescriptor<Orders,int>(ObjectControllerNames.Orders,
                item => new OrdersObjController(item),
                ObjectControllerNames.OrdersList,
                ObjectControllerNames.OrdersAll,
                list => new OrdersObjListController(list));            

            holder.AddDescriptor<CategoryQuery,int>(ObjectControllerNames.CategoryQuery,
                item => new CategoryQueryObjController(item),
                ObjectControllerNames.CategoryQueryList,
                ObjectControllerNames.CategoryQueryAll,
                list => new CategoryQueryObjListController(list));            

            holder.AddDescriptor<OrdersQuery,int>(ObjectControllerNames.OrdersQuery,
                item => new OrdersQueryObjController(item),
                ObjectControllerNames.OrdersQueryList,
                ObjectControllerNames.OrdersQueryAll,
                list => new OrdersQueryObjListController(list));            

            holder.AddDescriptor<ReportFormQuery,int>(ObjectControllerNames.ReportFormQuery,
                item => new ReportFormQueryObjController(item),
                ObjectControllerNames.ReportFormQueryList,
                ObjectControllerNames.ReportFormQueryAll,
                list => new ReportFormQueryObjListController(list));            

        }
    }
}
