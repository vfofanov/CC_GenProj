import angular from "angular"
import registerCustomComponents from './registerCustomComponents'
import ReportService from "./serverActionServices/reportService"
import CustomersService from "./screens/customersService"
import ShippersService from "./screens/shippersService"
import OrdersService from "./screens/ordersService"
import CategoriesService from "./screens/categoriesService"
import ProductsService from "./screens/productsService"
import SuppliersService from "./screens/suppliersService"
import EmployeesService from "./screens/employeesService"
import RegionService from "./screens/regionService"
import ChartsService from "./screens/chartsService"
import ProductWizardFactory from "./wizards/objectFactories/productWizardFactory"
import ProductWizardService from "./wizards/productWizardService"
import ProductWizardInitialization from "./wizards/initialization/productWizardInitialization"
import CustomerWizardFactory from "./wizards/objectFactories/customerWizardFactory"
import CustomerWizardService from "./wizards/customerWizardService"
import CustomerWizardInitialization from "./wizards/initialization/customerWizardInitialization"
import EmployeeWizardFactory from "./wizards/objectFactories/employeeWizardFactory"
import EmployeeWizardService from "./wizards/employeeWizardService"
import EmployeeWizardInitialization from "./wizards/initialization/employeeWizardInitialization"
import ShipperWizardFactory from "./wizards/objectFactories/shipperWizardFactory"
import ShipperWizardService from "./wizards/shipperWizardService"
import ShipperWizardInitialization from "./wizards/initialization/shipperWizardInitialization"
import OrderDetailWizardFactory from "./wizards/objectFactories/orderDetailWizardFactory"
import OrderDetailWizardService from "./wizards/orderDetailWizardService"
import OrderDetailWizardInitialization from "./wizards/initialization/orderDetailWizardInitialization"
import OrderWizardFactory from "./wizards/objectFactories/orderWizardFactory"
import OrderWizardService from "./wizards/orderWizardService"
import OrderWizardInitialization from "./wizards/initialization/orderWizardInitialization"
import CategoryWizardFactory from "./wizards/objectFactories/categoryWizardFactory"
import CategoryWizardService from "./wizards/categoryWizardService"
import CategoryWizardInitialization from "./wizards/initialization/categoryWizardInitialization"
import SupplierWizardFactory from "./wizards/objectFactories/supplierWizardFactory"
import SupplierWizardService from "./wizards/supplierWizardService"
import SupplierWizardInitialization from "./wizards/initialization/supplierWizardInitialization"
import CustomerCompactWizardFactory from "./wizards/objectFactories/customerCompactWizardFactory"
import CustomerCompactWizardService from "./wizards/customerCompactWizardService"
import CustomerCompactWizardInitialization from "./wizards/initialization/customerCompactWizardInitialization"
import RegionWizardFactory from "./wizards/objectFactories/regionWizardFactory"
import RegionWizardService from "./wizards/regionWizardService"
import RegionWizardInitialization from "./wizards/initialization/regionWizardInitialization"
import ReportFormQueryWizardFactory from "./wizards/objectFactories/reportFormQueryWizardFactory"
import ReportFormQueryWizardService from "./wizards/reportFormQueryWizardService"
import ReportFormQueryWizardInitialization from "./wizards/initialization/reportFormQueryWizardInitialization"
import ProductsValidationService from "./validation/productsValidationService"
import CustomersValidationService from "./validation/customersValidationService"
import EmployeesValidationService from "./validation/employeesValidationService"
import ShippersValidationService from "./validation/shippersValidationService"
import OrderDetailsValidationService from "./validation/orderDetailsValidationService"
import OrdersValidationService from "./validation/ordersValidationService"
import CategoriesValidationService from "./validation/categoriesValidationService"
import SuppliersValidationService from "./validation/suppliersValidationService"
import RegionValidationService from "./validation/regionValidationService"
import ReportFormQueryValidationService from "./validation/reportFormQueryValidationService"
import OperationResultEnum from "./enums/operationResultEnum"
import EnumsService from "./enums/enumsService"

const app = angular.module("app.domain", []);

app.service("reportService", ReportService);
app.service("customersService", CustomersService);
app.service("shippersService", ShippersService);
app.service("ordersService", OrdersService);
app.service("categoriesService", CategoriesService);
app.service("productsService", ProductsService);
app.service("suppliersService", SuppliersService);
app.service("employeesService", EmployeesService);
app.service("regionService", RegionService);
app.service("chartsService", ChartsService);
app.service("productWizardFactory", ProductWizardFactory);
app.service("productWizardService", ProductWizardService);
app.service("productWizardInitialization", ProductWizardInitialization);
app.service("customerWizardFactory", CustomerWizardFactory);
app.service("customerWizardService", CustomerWizardService);
app.service("customerWizardInitialization", CustomerWizardInitialization);
app.service("employeeWizardFactory", EmployeeWizardFactory);
app.service("employeeWizardService", EmployeeWizardService);
app.service("employeeWizardInitialization", EmployeeWizardInitialization);
app.service("shipperWizardFactory", ShipperWizardFactory);
app.service("shipperWizardService", ShipperWizardService);
app.service("shipperWizardInitialization", ShipperWizardInitialization);
app.service("orderDetailWizardFactory", OrderDetailWizardFactory);
app.service("orderDetailWizardService", OrderDetailWizardService);
app.service("orderDetailWizardInitialization", OrderDetailWizardInitialization);
app.service("orderWizardFactory", OrderWizardFactory);
app.service("orderWizardService", OrderWizardService);
app.service("orderWizardInitialization", OrderWizardInitialization);
app.service("categoryWizardFactory", CategoryWizardFactory);
app.service("categoryWizardService", CategoryWizardService);
app.service("categoryWizardInitialization", CategoryWizardInitialization);
app.service("supplierWizardFactory", SupplierWizardFactory);
app.service("supplierWizardService", SupplierWizardService);
app.service("supplierWizardInitialization", SupplierWizardInitialization);
app.service("customerCompactWizardFactory", CustomerCompactWizardFactory);
app.service("customerCompactWizardService", CustomerCompactWizardService);
app.service("customerCompactWizardInitialization", CustomerCompactWizardInitialization);
app.service("regionWizardFactory", RegionWizardFactory);
app.service("regionWizardService", RegionWizardService);
app.service("regionWizardInitialization", RegionWizardInitialization);
app.service("reportFormQueryWizardFactory", ReportFormQueryWizardFactory);
app.service("reportFormQueryWizardService", ReportFormQueryWizardService);
app.service("reportFormQueryWizardInitialization", ReportFormQueryWizardInitialization);
app.service("productsValidationService", ProductsValidationService);
app.service("customersValidationService", CustomersValidationService);
app.service("employeesValidationService", EmployeesValidationService);
app.service("shippersValidationService", ShippersValidationService);
app.service("orderDetailsValidationService", OrderDetailsValidationService);
app.service("ordersValidationService", OrdersValidationService);
app.service("categoriesValidationService", CategoriesValidationService);
app.service("suppliersValidationService", SuppliersValidationService);
app.service("regionValidationService", RegionValidationService);
app.service("reportFormQueryValidationService", ReportFormQueryValidationService);
app.service("operationResultEnum", OperationResultEnum);
app.service("enumsService", EnumsService);
registerCustomComponents(app);