-- Stored Procedure to Insert Data into Orders Table
CREATE PROCEDURE InsertOrder
    @OrderId VARCHAR(20),
    @OrderDate DATE,
    @ShipDate DATE,
    @ShipMode VARCHAR(50),
    @CustomerId VARCHAR(20),
    @CustomerName VARCHAR(100),
    @Segment VARCHAR(50),
    @Country VARCHAR(50),
    @City VARCHAR(50),
    @State VARCHAR(50),
    @PostalCode VARCHAR(10),
    @Region VARCHAR(50)
AS
BEGIN
    INSERT INTO Orders (OrderId, OrderDate, ShipDate, ShipMode, CustomerId, CustomerName, Segment, Country, City, State, PostalCode, Region)
    VALUES (@OrderId, @OrderDate, @ShipDate, @ShipMode, @CustomerId, @CustomerName, @Segment, @Country, @City, @State, @PostalCode, @Region);
END
GO

-- Stored Procedure to Insert Data into Products Table
CREATE PROCEDURE InsertProduct
    @ProductId VARCHAR(50),
    @Category VARCHAR(50),
    @SubCategory VARCHAR(50),
    @ProductName VARCHAR(255),
    @Sales DECIMAL(10, 3),
    @Quantity INT,
    @Discount DECIMAL(3, 2),
    @Profit DECIMAL(10, 3)
AS
BEGIN
    INSERT INTO Products (ProductId, Category, SubCategory, ProductName, Sales, Quantity, Discount, Profit)
    VALUES (@ProductId, @Category, @SubCategory, @ProductName, @Sales, @Quantity, @Discount, @Profit);
END
GO

-- Stored Procedure to Insert Data into OrdersReturns Table
CREATE PROCEDURE InsertOrderReturn
    @OrderId VARCHAR(20),
    @Comments VARCHAR(255)
AS
BEGIN
    INSERT INTO OrdersReturns (OrderId, Comments)
    VALUES (@OrderId, @Comments);
END
GO


