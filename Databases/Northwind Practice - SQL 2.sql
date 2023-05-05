-- 2a. How many customers does Northwind have?
SELECT COUNT(*)
FROM Customers

-- 2b. What is the stock value of Northwind presently?
SELECT SUM(UnitPrice * UnitsInStock) AS StockValue
FROM Products

-- 2c. How much tofu (in $) has Northwind sold?
SELECT SUM(UnitPrice * Quantity) AS TofuSales
FROM [Order Details]
WHERE ProductID = 14

-- alternative, with discount
SELECT SUM(UnitPrice * Quantity * (1-Discount)) AS TofuSales
FROM [Order Details]
WHERE ProductID = 14

-- alternative, with longlife tofu
SELECT SUM(UnitPrice * Quantity * (1-Discount)) AS TofuSales
FROM [Order Details]
WHERE ProductID = 14 OR ProductID = 74

-- alternative, with longlife tofu and subquery
SELECT SUM(UnitPrice * Quantity * (1-Discount)) AS TofuSales
FROM [Order Details]
WHERE ProductID IN (SELECT ProductID
                    FROM Products
                    WHERE ProductName LIKE '%Tofu%')
