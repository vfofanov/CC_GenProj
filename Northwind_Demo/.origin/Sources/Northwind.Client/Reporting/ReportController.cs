using System;
using System.IO;
using BusinessFramework.Client.Contracts.Reporting;
using Northwind.Client.Contracts.BusinessObjects;
using Northwind.Client.Reporting.Controllers.Object;
using ReportingFramework.Client.ReportSystem;


namespace Northwind.Client.Reporting
{
    public sealed class ReportController : BusinessFramework.Client.Contracts.Reporting.ReportController
    {
        public static class ObjectControllerNames
        {
            public const string Category = "category";
            public const string CategoryList = "category_list";
            public const string CategoryAll = "category_all";
            public const string Order = "order";
            public const string OrderList = "order_list";
            public const string OrderAll = "order_all";
            public const string VSalesByCategory = "vsalesbycategory";
            public const string VSalesByCategoryList = "vsalesbycategory_list";
            public const string VSalesByCategoryAll = "vsalesbycategory_all";
            public const string QCategories = "qcategories";
            public const string QCategoriesList = "qcategories_list";
            public const string QCategoriesAll = "qcategories_all";
            public const string QOrders = "qorders";
            public const string QOrdersList = "qorders_list";
            public const string QOrdersAll = "qorders_all";
        }

        public override Guid Guid
        {
            get { return new Guid("e671bc4c-4422-4630-9dd5-9ecce95fc2aa"); }
        }
        public override string ModuleName
        {
            get { return "Northwind"; }
        }
        
        public override void FillObjectDescriptors(IObjectControllerDescriptorHolder holder)
        {
            holder.AddDescriptor<Category,int>(ObjectControllerNames.Category,
                item => new CategoryObjController(item),
                ObjectControllerNames.CategoryList,
                ObjectControllerNames.CategoryAll,
                list => new CategoryObjListController(list));            

            holder.AddDescriptor<Order,int>(ObjectControllerNames.Order,
                item => new OrderObjController(item),
                ObjectControllerNames.OrderList,
                ObjectControllerNames.OrderAll,
                list => new OrderObjListController(list));            

            holder.AddDescriptor<VSalesByCategory,int>(ObjectControllerNames.VSalesByCategory,
                item => new VSalesByCategoryObjController(item),
                ObjectControllerNames.VSalesByCategoryList,
                ObjectControllerNames.VSalesByCategoryAll,
                list => new VSalesByCategoryObjListController(list));            

            holder.AddDescriptor<QCategories,int>(ObjectControllerNames.QCategories,
                item => new QCategoriesObjController(item),
                ObjectControllerNames.QCategoriesList,
                ObjectControllerNames.QCategoriesAll,
                list => new QCategoriesObjListController(list));            

            holder.AddDescriptor<QOrders,int>(ObjectControllerNames.QOrders,
                item => new QOrdersObjController(item),
                ObjectControllerNames.QOrdersList,
                ObjectControllerNames.QOrdersAll,
                list => new QOrdersObjListController(list));            

        }
    }
}
