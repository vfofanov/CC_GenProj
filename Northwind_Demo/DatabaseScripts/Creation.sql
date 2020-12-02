










CREATE TABLE [dbo].[Categories](
 [ID] int IDENTITY(1,1) NOT NULL
    ,[CategoryName] nvarchar(15) NOT NULL
    ,[Description] ntext NULL
    ,[Picture] image NULL
    , CONSTRAINT [PK_Categories] PRIMARY KEY ([ID])

)

GO

CREATE TABLE [dbo].[Customers](
 [ID] int IDENTITY(1,1) NOT NULL
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
    , CONSTRAINT [PK_Customers] PRIMARY KEY ([ID])

)

GO

CREATE TABLE [dbo].[Employees](
 [ID] int IDENTITY(1,1) NOT NULL
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
    ,[Photo] image NULL
    ,[Notes] ntext NULL
    ,[ReportsTo] int NULL
    ,[PhotoPath] nvarchar(255) NULL
    , CONSTRAINT [PK_Employees] PRIMARY KEY ([ID])

)

GO

CREATE TABLE [dbo].[Products](
 [ID] int IDENTITY(1,1) NOT NULL
    ,[ProductName] nvarchar(40) NOT NULL
    ,[SupplierID] int NULL
    ,[CategoryID] int NULL
    ,[QuantityPerUnit] nvarchar(20) NULL
    ,[UnitPrice] money NULL
    ,[UnitsInStock] smallint NULL
    ,[UnitsOnOrder] smallint NULL
    ,[ReorderLevel] smallint NULL
    ,[Discontinued] bit NOT NULL
    , CONSTRAINT [PK_Products] PRIMARY KEY ([ID])

)

GO

CREATE TABLE [dbo].[Shippers](
 [ID] int IDENTITY(1,1) NOT NULL
    ,[CompanyName] nvarchar(40) NOT NULL
    ,[Phone] nvarchar(24) NULL
    , CONSTRAINT [PK_Shippers] PRIMARY KEY ([ID])

)

GO

CREATE TABLE [dbo].[Suppliers](
 [ID] int IDENTITY(1,1) NOT NULL
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
    , CONSTRAINT [PK_Suppliers] PRIMARY KEY ([ID])

)

GO

CREATE TABLE [dbo].[Orders](
 [ID] int IDENTITY(1,1) NOT NULL
    ,[CustomerID] int NULL
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
    ,[StatusID] smallint NULL
    , CONSTRAINT [PK_Orders] PRIMARY KEY ([ID])

)

GO

CREATE TABLE [dbo].[Order Details](
 [Id] int IDENTITY(1,1) NOT NULL
    ,[OrderID] int NOT NULL
    ,[ProductID] int NOT NULL
    ,[UnitPrice] money NOT NULL
    ,[Quantity] smallint NOT NULL
    ,[Discount] real NOT NULL
    , PRIMARY KEY ([Id])

)

GO

CREATE TABLE [dbo].[OrderStatus](
 [ID] smallint NOT NULL
    ,[Name] varchar(50) NULL
    , CONSTRAINT [PK__OrderStatus] PRIMARY KEY ([ID])

)

GO

ALTER TABLE [dbo].[Employees]
    ADD CONSTRAINT [FK_Employees_Employees] FOREIGN KEY([ReportsTo]) 
        REFERENCES [dbo].[Employees]([ID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[Products]
    ADD CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID]) 
        REFERENCES [dbo].[Categories]([ID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[Products]
    ADD CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY([SupplierID]) 
        REFERENCES [dbo].[Suppliers]([ID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[Orders]
    ADD CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerID]) 
        REFERENCES [dbo].[Customers]([ID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[Orders]
    ADD CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeID]) 
        REFERENCES [dbo].[Employees]([ID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[Orders]
    ADD CONSTRAINT [FK_Orders_Shippers] FOREIGN KEY([ShipVia]) 
        REFERENCES [dbo].[Shippers]([ID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[Orders]
    ADD CONSTRAINT [FK_Orders_OrderStatus] FOREIGN KEY([StatusID]) 
        REFERENCES [dbo].[OrderStatus]([ID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[Order Details]
    ADD CONSTRAINT [FK_Order_Details_Orders] FOREIGN KEY([OrderID]) 
        REFERENCES [dbo].[Orders]([ID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

ALTER TABLE [dbo].[Order Details]
    ADD CONSTRAINT [FK_Order_Details_Products] FOREIGN KEY([ProductID]) 
        REFERENCES [dbo].[Products]([ID])
            ON DELETE NO ACTION   
            ON UPDATE NO ACTION   

GO

CREATE VIEW [dbo].[vSalesByCategory]
AS
SELECT
	CAST(NULL AS int) [ID],
	CAST(NULL AS nvarchar) [CategoryName],
	CAST(NULL AS nvarchar) [ProductName],
	CAST(NULL AS money) [ProductSales]
GO

DROP VIEW [dbo].[vSalesByCategory]
GO

CREATE VIEW [dbo].[vSalesByCategory] AS
SELECT Categories.ID, Categories.CategoryName, Products.ProductName, 
 Sum("Order Details Extended".ExtendedPrice) AS ProductSales
FROM  Categories INNER JOIN 
  (Products INNER JOIN 
   (Orders o INNER JOIN "Order Details Extended" ON o.ID = "Order Details Extended".OrderID) 
  ON Products.ID = "Order Details Extended".ProductID) 
 ON Categories.ID = Products.CategoryID
GROUP BY Categories.ID, Categories.CategoryName, Products.ProductName


GO



