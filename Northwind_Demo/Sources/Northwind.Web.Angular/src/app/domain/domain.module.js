





import angular from "angular"
import ClientOrderManagerService from "./clientActionServices/clientOrderManagerService"
import TestDynamicColumnsActionService from "./serverActionServices/testDynamicColumnsActionService"
import CustomersService from "./screens/customersService"
import ShippersService from "./screens/shippersService"
import OrdersService from "./screens/ordersService"
import TestDynamicColumnsService from "./screens/testDynamicColumnsService"
import CategoriesService from "./screens/categoriesService"
import ProductsService from "./screens/productsService"
import SuppliersService from "./screens/suppliersService"
import EmployeesService from "./screens/employeesService"
import ProductsWizardFactory from "./wizards/objectFactories/productsWizardFactory"
import ProductsWizardService from "./wizards/productsWizardService"
import ProductsWizardInitialization from "./wizards/initialization/productsWizardInitialization"
import CustomersWizardFactory from "./wizards/objectFactories/customersWizardFactory"
import CustomersWizardService from "./wizards/customersWizardService"
import CustomersWizardInitialization from "./wizards/initialization/customersWizardInitialization"
import EmployeesWizardFactory from "./wizards/objectFactories/employeesWizardFactory"
import EmployeesWizardService from "./wizards/employeesWizardService"
import EmployeesWizardInitialization from "./wizards/initialization/employeesWizardInitialization"
import ShippersWizardFactory from "./wizards/objectFactories/shippersWizardFactory"
import ShippersWizardService from "./wizards/shippersWizardService"
import ShippersWizardInitialization from "./wizards/initialization/shippersWizardInitialization"
import OrderDetailsWizardFactory from "./wizards/objectFactories/orderDetailsWizardFactory"
import OrderDetailsWizardService from "./wizards/orderDetailsWizardService"
import OrderDetailsWizardInitialization from "./wizards/initialization/orderDetailsWizardInitialization"
import OrdersWizardFactory from "./wizards/objectFactories/ordersWizardFactory"
import OrdersWizardService from "./wizards/ordersWizardService"
import OrdersWizardInitialization from "./wizards/initialization/ordersWizardInitialization"
import CategoriesWizardFactory from "./wizards/objectFactories/categoriesWizardFactory"
import CategoriesWizardService from "./wizards/categoriesWizardService"
import CategoriesWizardInitialization from "./wizards/initialization/categoriesWizardInitialization"
import SuppliersWizardFactory from "./wizards/objectFactories/suppliersWizardFactory"
import SuppliersWizardService from "./wizards/suppliersWizardService"
import SuppliersWizardInitialization from "./wizards/initialization/suppliersWizardInitialization"
import ProductValidationService from "./validation/productValidationService"
import CustomerValidationService from "./validation/customerValidationService"
import EmployeeValidationService from "./validation/employeeValidationService"
import ShipperValidationService from "./validation/shipperValidationService"
import OrderDetailValidationService from "./validation/orderDetailValidationService"
import OrderValidationService from "./validation/orderValidationService"
import CategoryValidationService from "./validation/categoryValidationService"
import SupplierValidationService from "./validation/supplierValidationService"
import EnumsService from "./enums/enumsService"
import registerCustomComponents from './registerCustomComponents'


const app = angular.module("app.domain", []);

app.service("clientOrderManagerService", ClientOrderManagerService);
app.service("testDynamicColumnsActionService", TestDynamicColumnsActionService);
app.service("customersService", CustomersService);
app.service("shippersService", ShippersService);
app.service("ordersService", OrdersService);
app.service("testDynamicColumnsService", TestDynamicColumnsService);
app.service("categoriesService", CategoriesService);
app.service("productsService", ProductsService);
app.service("suppliersService", SuppliersService);
app.service("employeesService", EmployeesService);
app.service("productsWizardFactory", ProductsWizardFactory);
app.service("productsWizardService", ProductsWizardService);
app.service("productsWizardInitialization", ProductsWizardInitialization);
app.service("customersWizardFactory", CustomersWizardFactory);
app.service("customersWizardService", CustomersWizardService);
app.service("customersWizardInitialization", CustomersWizardInitialization);
app.service("employeesWizardFactory", EmployeesWizardFactory);
app.service("employeesWizardService", EmployeesWizardService);
app.service("employeesWizardInitialization", EmployeesWizardInitialization);
app.service("shippersWizardFactory", ShippersWizardFactory);
app.service("shippersWizardService", ShippersWizardService);
app.service("shippersWizardInitialization", ShippersWizardInitialization);
app.service("orderDetailsWizardFactory", OrderDetailsWizardFactory);
app.service("orderDetailsWizardService", OrderDetailsWizardService);
app.service("orderDetailsWizardInitialization", OrderDetailsWizardInitialization);
app.service("ordersWizardFactory", OrdersWizardFactory);
app.service("ordersWizardService", OrdersWizardService);
app.service("ordersWizardInitialization", OrdersWizardInitialization);
app.service("categoriesWizardFactory", CategoriesWizardFactory);
app.service("categoriesWizardService", CategoriesWizardService);
app.service("categoriesWizardInitialization", CategoriesWizardInitialization);
app.service("suppliersWizardFactory", SuppliersWizardFactory);
app.service("suppliersWizardService", SuppliersWizardService);
app.service("suppliersWizardInitialization", SuppliersWizardInitialization);
app.service("productValidationService", ProductValidationService);
app.service("customerValidationService", CustomerValidationService);
app.service("employeeValidationService", EmployeeValidationService);
app.service("shipperValidationService", ShipperValidationService);
app.service("orderDetailValidationService", OrderDetailValidationService);
app.service("orderValidationService", OrderValidationService);
app.service("categoryValidationService", CategoryValidationService);
app.service("supplierValidationService", SupplierValidationService);
app.service("enumsService", EnumsService);

registerCustomComponents(app);