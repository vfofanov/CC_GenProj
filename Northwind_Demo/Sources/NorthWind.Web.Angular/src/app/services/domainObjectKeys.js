(function() {
    'use strict';
	class DomainObjectKeysService {
		constructor() {}
		getPropertyNameById (propertyId) {
			if (36 === propertyId)
				return "Id";
			if (38 === propertyId)
				return "CategoryID";
			if (39 === propertyId)
				return "Discontinued";
			if (40 === propertyId)
				return "ProductName";
			if (41 === propertyId)
				return "QuantityPerUnit";
			if (42 === propertyId)
				return "ReorderLevel";
			if (43 === propertyId)
				return "SupplierID";
			if (45 === propertyId)
				return "UnitPrice";
			if (46 === propertyId)
				return "UnitsInStock";
			if (47 === propertyId)
				return "UnitsOnOrder";
			if (52 === propertyId)
				return "CustomerID";
			if (53 === propertyId)
				return "CustomerTypeID";
			if (60 === propertyId)
				return "Id";
			if (61 === propertyId)
				return "IsExecuted";
			if (63 === propertyId)
				return "Token";
			if (64 === propertyId)
				return "UserId";
			if (65 === propertyId)
				return "ValidFrom";
			if (76 === propertyId)
				return "Id";
			if (77 === propertyId)
				return "Description";
			if (78 === propertyId)
				return "IsOwnByUser";
			if (79 === propertyId)
				return "IsSystem";
			if (80 === propertyId)
				return "Name";
			if (82 === propertyId)
				return "OwnerUserID";
			if (88 === propertyId)
				return "Id";
			if (90 === propertyId)
				return "RegionID";
			if (91 === propertyId)
				return "TerritoryDescription";
			if (96 === propertyId)
				return "EmployeeID";
			if (97 === propertyId)
				return "TerritoryID";
			if (126 === propertyId)
				return "Id";
			if (127 === propertyId)
				return "Address";
			if (128 === propertyId)
				return "City";
			if (129 === propertyId)
				return "CompanyName";
			if (130 === propertyId)
				return "ContactName";
			if (131 === propertyId)
				return "ContactTitle";
			if (132 === propertyId)
				return "Country";
			if (133 === propertyId)
				return "Fax";
			if (134 === propertyId)
				return "Phone";
			if (135 === propertyId)
				return "PostalCode";
			if (136 === propertyId)
				return "Region";
			if (141 === propertyId)
				return "Id";
			if (142 === propertyId)
				return "CategoryName";
			if (143 === propertyId)
				return "Description";
			if (144 === propertyId)
				return "Picture";
			if (149 === propertyId)
				return "Id";
			if (150 === propertyId)
				return "RegionDescription";
			if (155 === propertyId)
				return "Id";
			if (156 === propertyId)
				return "Address";
			if (157 === propertyId)
				return "City";
			if (158 === propertyId)
				return "CompanyName";
			if (159 === propertyId)
				return "ContactName";
			if (160 === propertyId)
				return "ContactTitle";
			if (161 === propertyId)
				return "Country";
			if (162 === propertyId)
				return "Fax";
			if (163 === propertyId)
				return "HomePage";
			if (164 === propertyId)
				return "Phone";
			if (165 === propertyId)
				return "PostalCode";
			if (166 === propertyId)
				return "Region";
			if (171 === propertyId)
				return "OperationName";
			if (172 === propertyId)
				return "OperationContext";
			if (173 === propertyId)
				return "AquiredTime";
			if (174 === propertyId)
				return "ExpirationTime";
			if (175 === propertyId)
				return "MachineName";
			if (176 === propertyId)
				return "ProcessId";
			if (189 === propertyId)
				return "Id";
			if (190 === propertyId)
				return "CustomerID";
			if (192 === propertyId)
				return "EmployeeID";
			if (194 === propertyId)
				return "Freight";
			if (195 === propertyId)
				return "OrderDate";
			if (197 === propertyId)
				return "RequiredDate";
			if (198 === propertyId)
				return "ShipAddress";
			if (199 === propertyId)
				return "ShipCity";
			if (200 === propertyId)
				return "ShipCountry";
			if (201 === propertyId)
				return "ShipName";
			if (202 === propertyId)
				return "ShippedDate";
			if (204 === propertyId)
				return "ShipPostalCode";
			if (205 === propertyId)
				return "ShipRegion";
			if (206 === propertyId)
				return "ShipVia";
			if (221 === propertyId)
				return "OrderID";
			if (222 === propertyId)
				return "ProductID";
			if (223 === propertyId)
				return "Discount";
			if (226 === propertyId)
				return "Quantity";
			if (227 === propertyId)
				return "UnitPrice";
			if (232 === propertyId)
				return "Id";
			if (233 === propertyId)
				return "SettingPropertyId";
			if (234 === propertyId)
				return "StringValue";
			if (237 === propertyId)
				return "UserId";
			if (246 === propertyId)
				return "Id";
			if (247 === propertyId)
				return "Address";
			if (248 === propertyId)
				return "BirthDate";
			if (249 === propertyId)
				return "City";
			if (250 === propertyId)
				return "Country";
			if (251 === propertyId)
				return "DocumentScanFileId";
			if (252 === propertyId)
				return "Extension";
			if (253 === propertyId)
				return "FirstName";
			if (254 === propertyId)
				return "HireDate";
			if (255 === propertyId)
				return "HomePhone";
			if (256 === propertyId)
				return "LastName";
			if (257 === propertyId)
				return "Notes";
			if (258 === propertyId)
				return "Photo";
			if (259 === propertyId)
				return "PhotoPath";
			if (260 === propertyId)
				return "PostalCode";
			if (261 === propertyId)
				return "Region";
			if (262 === propertyId)
				return "ReportsTo";
			if (264 === propertyId)
				return "Title";
			if (265 === propertyId)
				return "TitleOfCourtesy";
			if (278 === propertyId)
				return "Id";
			if (279 === propertyId)
				return "CustomerDesc";
			if (289 === propertyId)
				return "Id";
			if (290 === propertyId)
				return "DefaultType";
			if (291 === propertyId)
				return "Description";
			if (292 === propertyId)
				return "GroupName";
			if (293 === propertyId)
				return "IsManaged";
			if (294 === propertyId)
				return "IsOverridable";
			if (295 === propertyId)
				return "Name";
			if (296 === propertyId)
				return "UIEditorType";
			if (305 === propertyId)
				return "Id";
			if (306 === propertyId)
				return "CompanyName";
			if (307 === propertyId)
				return "Phone";
			if (309 === propertyId)
				return "Id";
			if (310 === propertyId)
				return "Address";
			if (311 === propertyId)
				return "City";
			if (312 === propertyId)
				return "CompanyName";
			if (313 === propertyId)
				return "ContactName";
			if (314 === propertyId)
				return "ContactTitle";
			if (315 === propertyId)
				return "Country";
			if (316 === propertyId)
				return "Fax";
			if (317 === propertyId)
				return "HomePage";
			if (318 === propertyId)
				return "Phone";
			if (319 === propertyId)
				return "PostalCode";
			if (320 === propertyId)
				return "Region";
			if (322 === propertyId)
				return "Id";
			if (323 === propertyId)
				return "Address";
			if (324 === propertyId)
				return "BirthDate";
			if (325 === propertyId)
				return "City";
			if (326 === propertyId)
				return "Country";
			if (327 === propertyId)
				return "DocumentScanFileId";
			if (328 === propertyId)
				return "Employee_FullName";
			if (329 === propertyId)
				return "Extension";
			if (330 === propertyId)
				return "FirstName";
			if (331 === propertyId)
				return "HireDate";
			if (332 === propertyId)
				return "HomePhone";
			if (333 === propertyId)
				return "LastName";
			if (334 === propertyId)
				return "Notes";
			if (335 === propertyId)
				return "Photo";
			if (336 === propertyId)
				return "PostalCode";
			if (337 === propertyId)
				return "Region";
			if (338 === propertyId)
				return "ReportsTo";
			if (339 === propertyId)
				return "Title";
			if (340 === propertyId)
				return "TitleOfCourtesy";
			if (342 === propertyId)
				return "Id";
			if (343 === propertyId)
				return "CompanyName";
			if (344 === propertyId)
				return "Phone";
			if (346 === propertyId)
				return "Id";
			if (347 === propertyId)
				return "CategoryName";
			if (348 === propertyId)
				return "Description";
			if (349 === propertyId)
				return "Picture";
			if (352 === propertyId)
				return "Id";
			if (353 === propertyId)
				return "CustomerId";
			if (354 === propertyId)
				return "EmployeeId";
			if (355 === propertyId)
				return "From";
			if (356 === propertyId)
				return "To";
			if (357 === propertyId)
				return "useExcel";
			if (359 === propertyId)
				return "Id";
			if (360 === propertyId)
				return "Address";
			if (361 === propertyId)
				return "City";
			if (362 === propertyId)
				return "CompanyName";
			if (363 === propertyId)
				return "ContactName";
			if (364 === propertyId)
				return "ContactTitle";
			if (365 === propertyId)
				return "Country";
			if (366 === propertyId)
				return "Fax";
			if (367 === propertyId)
				return "Phone";
			if (368 === propertyId)
				return "PostalCode";
			if (369 === propertyId)
				return "Region";
			if (371 === propertyId)
				return "Id";
			if (372 === propertyId)
				return "Categories_CategoryName";
			if (373 === propertyId)
				return "Categories_Description";
			if (374 === propertyId)
				return "Categories_Id";
			if (375 === propertyId)
				return "CategoryID";
			if (376 === propertyId)
				return "Discontinued";
			if (377 === propertyId)
				return "ProductName";
			if (378 === propertyId)
				return "QuantityPerUnit";
			if (379 === propertyId)
				return "ReorderLevel";
			if (380 === propertyId)
				return "SupplierID";
			if (381 === propertyId)
				return "Suppliers_Address";
			if (382 === propertyId)
				return "Suppliers_City";
			if (383 === propertyId)
				return "Suppliers_CompanyName";
			if (384 === propertyId)
				return "Suppliers_ContactName";
			if (385 === propertyId)
				return "Suppliers_ContactTitle";
			if (386 === propertyId)
				return "Suppliers_Country";
			if (387 === propertyId)
				return "Suppliers_Fax";
			if (388 === propertyId)
				return "Suppliers_HomePage";
			if (389 === propertyId)
				return "Suppliers_Id";
			if (390 === propertyId)
				return "Suppliers_Phone";
			if (391 === propertyId)
				return "Suppliers_PostalCode";
			if (392 === propertyId)
				return "Suppliers_Region";
			if (393 === propertyId)
				return "UnitPrice";
			if (394 === propertyId)
				return "UnitsInStock";
			if (395 === propertyId)
				return "UnitsOnOrder";
			if (397 === propertyId)
				return "Id";
			if (398 === propertyId)
				return "OrderID";
			if (399 === propertyId)
				return "ProductID";
			if (400 === propertyId)
				return "Discount";
			if (401 === propertyId)
				return "Orders_CustomerID";
			if (402 === propertyId)
				return "Orders_EmployeeID";
			if (403 === propertyId)
				return "Orders_Freight";
			if (404 === propertyId)
				return "Orders_Id";
			if (405 === propertyId)
				return "Orders_OrderDate";
			if (406 === propertyId)
				return "Orders_RequiredDate";
			if (407 === propertyId)
				return "Orders_ShipAddress";
			if (408 === propertyId)
				return "Orders_ShipCity";
			if (409 === propertyId)
				return "Orders_ShipCountry";
			if (410 === propertyId)
				return "Orders_ShipName";
			if (411 === propertyId)
				return "Orders_ShippedDate";
			if (412 === propertyId)
				return "Orders_ShipPostalCode";
			if (413 === propertyId)
				return "Orders_ShipRegion";
			if (414 === propertyId)
				return "Orders_ShipVia";
			if (415 === propertyId)
				return "Products_CategoryID";
			if (416 === propertyId)
				return "Products_Discontinued";
			if (417 === propertyId)
				return "Products_Id";
			if (418 === propertyId)
				return "Products_ProductName";
			if (419 === propertyId)
				return "Products_QuantityPerUnit";
			if (420 === propertyId)
				return "Products_ReorderLevel";
			if (421 === propertyId)
				return "Products_SupplierID";
			if (422 === propertyId)
				return "Products_UnitPrice";
			if (423 === propertyId)
				return "Products_UnitsInStock";
			if (424 === propertyId)
				return "Products_UnitsOnOrder";
			if (425 === propertyId)
				return "Quantity";
			if (426 === propertyId)
				return "UnitPrice";
			if (428 === propertyId)
				return "Id";
			if (429 === propertyId)
				return "CustomerID";
			if (430 === propertyId)
				return "Customers_Address";
			if (431 === propertyId)
				return "Customers_City";
			if (432 === propertyId)
				return "Customers_CompanyName";
			if (433 === propertyId)
				return "Customers_ContactName";
			if (434 === propertyId)
				return "Customers_ContactTitle";
			if (435 === propertyId)
				return "Customers_Country";
			if (436 === propertyId)
				return "Customers_Fax";
			if (437 === propertyId)
				return "Customers_Id";
			if (438 === propertyId)
				return "Customers_Phone";
			if (439 === propertyId)
				return "Customers_PostalCode";
			if (440 === propertyId)
				return "Customers_Region";
			if (441 === propertyId)
				return "EmployeeFullName";
			if (442 === propertyId)
				return "EmployeeID";
			if (443 === propertyId)
				return "Employees_Address";
			if (444 === propertyId)
				return "Employees_BirthDate";
			if (445 === propertyId)
				return "Employees_City";
			if (446 === propertyId)
				return "Employees_Country";
			if (447 === propertyId)
				return "Employees_Extension";
			if (448 === propertyId)
				return "Employees_FirstName";
			if (449 === propertyId)
				return "Employees_HireDate";
			if (450 === propertyId)
				return "Employees_HomePhone";
			if (451 === propertyId)
				return "Employees_Id";
			if (452 === propertyId)
				return "Employees_LastName";
			if (453 === propertyId)
				return "Employees_Notes";
			if (454 === propertyId)
				return "Employees_PhotoPath";
			if (455 === propertyId)
				return "Employees_PostalCode";
			if (456 === propertyId)
				return "Employees_Region";
			if (457 === propertyId)
				return "Employees_ReportsTo";
			if (458 === propertyId)
				return "Employees_Title";
			if (459 === propertyId)
				return "Employees_TitleOfCourtesy";
			if (460 === propertyId)
				return "Freight";
			if (461 === propertyId)
				return "OrderDate";
			if (462 === propertyId)
				return "RequiredDate";
			if (463 === propertyId)
				return "ShipAddress";
			if (464 === propertyId)
				return "ShipCity";
			if (465 === propertyId)
				return "ShipCountry";
			if (466 === propertyId)
				return "ShipName";
			if (467 === propertyId)
				return "ShippedDate";
			if (468 === propertyId)
				return "Shippers_CompanyName";
			if (469 === propertyId)
				return "Shippers_Id";
			if (470 === propertyId)
				return "Shippers_Phone";
			if (471 === propertyId)
				return "ShipPostalCode";
			if (472 === propertyId)
				return "ShipRegion";
			if (473 === propertyId)
				return "ShipVia";
			if (475 === propertyId)
				return "Id";
			if (476 === propertyId)
				return "RegionDescription";
		
		}

	}
	angular.module('acsys').service('domainObjectKeysService', DomainObjectKeysService);
}).call(this);
