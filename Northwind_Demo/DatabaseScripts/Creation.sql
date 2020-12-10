










CREATE TABLE [dbo].[Categories](
 [CategoryID] int IDENTITY(1,1) NOT NULL
    ,[CategoryName] nvarchar(15) NOT NULL
    ,[Description] ntext NULL
    ,[Picture] varbinary(MAX) NULL
    , CONSTRAINT [PK_Categories] PRIMARY KEY ([CategoryID])

)

GO

CREATE TABLE [dbo].[Customers](
 [CustomerID] int IDENTITY(1,1) NOT NULL
    ,[CompanyName] nvarchar(40) NOT NULL
    ,[ContactName] nvarchar(30) NULL
    ,[ContactTitle] nvarchar(30) NULL
    ,[Address] nvarchar(60) NULL
    ,[City] nvarchar(15) NULL
    ,[Region] nvarchar(15) NULL
    ,[PostalCode] nvarchar(10) NULL
    ,[Country] nvarchar(15) NULL
    ,[Phone] nvarchar(24) NULL
    ,[Fax] nvarchar(24) NULL
    , CONSTRAINT [PK_Customers] PRIMARY KEY ([CustomerID])

)

GO

CREATE TABLE [dbo].[Employees](
 [EmployeeID] int IDENTITY(1,1) NOT NULL
    ,[LastName] nvarchar(20) NOT NULL
    ,[FirstName] nvarchar(10) NOT NULL
    ,[Title] nvarchar(30) NULL
    ,[TitleOfCourtesy] nvarchar(25) NULL
    ,[BirthDate] datetime NULL
    ,[HireDate] datetime NULL
    ,[Address] nvarchar(60) NULL
    ,[City] nvarchar(15) NULL
    ,[Region] nvarchar(15) NULL
    ,[PostalCode] nvarchar(10) NULL
    ,[Country] nvarchar(15) NULL
    ,[HomePhone] nvarchar(24) NULL
    ,[Extension] nvarchar(4) NULL
    ,[Photo] varbinary(MAX) NULL
    ,[Notes] ntext NULL
    ,[ReportsTo] int NULL
    ,[PhotoPath] nvarchar(255) NULL
    ,[DocumentScanFileId] int NULL
    , CONSTRAINT [PK_Employees] PRIMARY KEY ([EmployeeID])

)

GO

CREATE TABLE [dbo].[Products](
 [ProductID] int IDENTITY(1,1) NOT NULL
    ,[ProductName] nvarchar(40) NOT NULL
    ,[SupplierID] int NULL
    ,[CategoryID] int NULL
    ,[QuantityPerUnit] nvarchar(20) NULL
    ,[UnitPrice] money NULL
    ,[UnitsInStock] smallint NULL
    ,[UnitsOnOrder] smallint NULL
    ,[ReorderLevel] smallint NULL
    ,[Discontinued] bit NOT NULL
    , CONSTRAINT [PK_Products] PRIMARY KEY ([ProductID])

)

GO

CREATE TABLE [dbo].[Shippers](
 [ShipperID] int IDENTITY(1,1) NOT NULL
    ,[CompanyName] nvarchar(40) NOT NULL
    ,[Phone] nvarchar(24) NULL
    , CONSTRAINT [PK_Shippers] PRIMARY KEY ([ShipperID])

)

GO

CREATE TABLE [dbo].[Suppliers](
 [SupplierID] int IDENTITY(1,1) NOT NULL
    ,[CompanyName] nvarchar(40) NOT NULL
    ,[ContactName] nvarchar(30) NULL
    ,[ContactTitle] nvarchar(30) NULL
    ,[Address] nvarchar(60) NULL
    ,[City] nvarchar(15) NULL
    ,[Region] nvarchar(15) NULL
    ,[PostalCode] nvarchar(10) NULL
    ,[Country] nvarchar(15) NULL
    ,[Phone] nvarchar(24) NULL
    ,[Fax] nvarchar(24) NULL
    ,[HomePage] ntext NULL
    , CONSTRAINT [PK_Suppliers] PRIMARY KEY ([SupplierID])

)

GO

CREATE TABLE [dbo].[Orders](
 [OrderID] int IDENTITY(1,1) NOT NULL
    ,[CustomerID] int NOT NULL
    ,[EmployeeID] int NULL
    ,[OrderDate] datetime NULL
    ,[RequiredDate] datetime NULL
    ,[ShippedDate] datetime NULL
    ,[ShipVia] int NULL
    ,[Freight] money NULL
    ,[ShipName] nvarchar(40) NULL
    ,[ShipAddress] nvarchar(60) NULL
    ,[ShipCity] nvarchar(15) NULL
    ,[ShipRegion] nvarchar(15) NULL
    ,[ShipPostalCode] nvarchar(10) NULL
    ,[ShipCountry] nvarchar(15) NULL
    , CONSTRAINT [PK_Orders] PRIMARY KEY ([OrderID])

)

GO

CREATE TABLE [dbo].[Order Details](
 [OrderID] int NOT NULL
    ,[ProductID] int NOT NULL
    ,[UnitPrice] money NOT NULL
    ,[Quantity] smallint NOT NULL
    ,[Discount] real NOT NULL
    , CONSTRAINT [PK_Order_Details] PRIMARY KEY ([OrderID], [ProductID])

)

GO

CREATE TABLE [dbo].[CustomerCustomerDemo](
 [CustomerID] int NOT NULL
    ,[CustomerTypeID] int NOT NULL
    , CONSTRAINT [PK_CustomerCustomerDemo] PRIMARY KEY ([CustomerID], [CustomerTypeID])

)

GO

CREATE TABLE [dbo].[CustomerDemographics](
 [CustomerTypeID] int NOT NULL
    ,[CustomerDesc] ntext NULL
    , CONSTRAINT [PK_CustomerDemographics] PRIMARY KEY ([CustomerTypeID])

)

GO

CREATE TABLE [dbo].[EmployeeTerritories](
 [EmployeeID] int NOT NULL
    ,[TerritoryID] int NOT NULL
    , CONSTRAINT [PK_EmployeeTerritories] PRIMARY KEY ([EmployeeID], [TerritoryID])

)

GO

CREATE TABLE [dbo].[Region](
 [RegionID] int NOT NULL
    ,[RegionDescription] nchar(50) NOT NULL
    , CONSTRAINT [PK_Region] PRIMARY KEY ([RegionID])

)

GO

CREATE TABLE [dbo].[Territories](
 [TerritoryID] int NOT NULL
    ,[TerritoryDescription] nchar(50) NOT NULL
    ,[RegionID] int NOT NULL
    , CONSTRAINT [PK_Territories] PRIMARY KEY ([TerritoryID])

)

GO

ALTER TABLE [dbo].[Employees]
    ADD CONSTRAINT [FK_Employees_Employees] FOREIGN KEY([ReportsTo]) 
        REFERENCES [dbo].[Employees]([EmployeeID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[Products]
    ADD CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID]) 
        REFERENCES [dbo].[Categories]([CategoryID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[Products]
    ADD CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY([SupplierID]) 
        REFERENCES [dbo].[Suppliers]([SupplierID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[Orders]
    ADD CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerID]) 
        REFERENCES [dbo].[Customers]([CustomerID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[Orders]
    ADD CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeID]) 
        REFERENCES [dbo].[Employees]([EmployeeID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[Orders]
    ADD CONSTRAINT [FK_Orders_Shippers] FOREIGN KEY([ShipVia]) 
        REFERENCES [dbo].[Shippers]([ShipperID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[Order Details]
    ADD CONSTRAINT [FK_Order_Details_Orders] FOREIGN KEY([OrderID]) 
        REFERENCES [dbo].[Orders]([OrderID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[Order Details]
    ADD CONSTRAINT [FK_Order_Details_Products] FOREIGN KEY([ProductID]) 
        REFERENCES [dbo].[Products]([ProductID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[CustomerCustomerDemo]
    ADD CONSTRAINT [FK_CustomerCustomerDemo] FOREIGN KEY([CustomerTypeID]) 
        REFERENCES [dbo].[CustomerDemographics]([CustomerTypeID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[CustomerCustomerDemo]
    ADD CONSTRAINT [FK_CustomerCustomerDemo_Customers] FOREIGN KEY([CustomerID]) 
        REFERENCES [dbo].[Customers]([CustomerID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[EmployeeTerritories]
    ADD CONSTRAINT [FK_EmployeeTerritories_Employees] FOREIGN KEY([EmployeeID]) 
        REFERENCES [dbo].[Employees]([EmployeeID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[EmployeeTerritories]
    ADD CONSTRAINT [FK_EmployeeTerritories_Territories] FOREIGN KEY([TerritoryID]) 
        REFERENCES [dbo].[Territories]([TerritoryID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[Territories]
    ADD CONSTRAINT [FK_Territories_Region] FOREIGN KEY([RegionID]) 
        REFERENCES [dbo].[Region]([RegionID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO



