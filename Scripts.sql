CREATE TABLE orders (
    OrderId VARCHAR(20) PRIMARY KEY,
    OrderDate DATE,
    ShipDate DATE,
    ShipMode VARCHAR(50),
    CustomerId VARCHAR(20),
    CustomerName VARCHAR(100),
    Segment VARCHAR(50),
    Country VARCHAR(50),
    City VARCHAR(50),
    State VARCHAR(50),
    PostalCode VARCHAR(10),
    Region VARCHAR(50)
);


CREATE TABLE Products (
    ProductId VARCHAR(50) PRIMARY KEY,
    Category VARCHAR(50),
    SubCategory VARCHAR(50),
    ProductName VARCHAR(255),
    Sales DECIMAL(10, 3),
    Quantity INT,
    Discount DECIMAL(3, 2),
    Profit DECIMAL(10, 3)
);

CREATE TABLE ORDERSRETURNS (
  OrderId VARCHAR(20) PRIMARY KEY,
  Comments VARCHAR(255)
);


-- Inserting values into the orders table
INSERT INTO orders (OrderId, OrderDate, ShipDate, ShipMode, CustomerId, CustomerName, Segment, Country, City, State, PostalCode, Region)
VALUES 
('ORD001', '2023-01-01', '2023-01-03', 'Standard', 'CUST001', 'John Doe', 'Consumer', 'USA', 'New York', 'NY', '10001', 'East');

-- Inserting values into the Products table
INSERT INTO Products (ProductId, Category, SubCategory, ProductName, Sales, Quantity, Discount, Profit)
VALUES 
('PROD001', 'Office Supplies', 'Paper', 'Printer Paper', 100.50, 10, 0.10, 20.00);

-- Inserting values into the ORDERSRETURNS table
INSERT INTO ORDERSRETURNS (OrderId, Comments)
VALUES 
('ORD001', 'Customer returned the item due to a defect');