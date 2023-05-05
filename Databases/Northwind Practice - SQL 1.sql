-- 1a. All Finnish customers
SELECT *
FROM Customers
WHERE Country = 'Finland'

-- 1b. All orders for the customer "Que Delícia" -> with a subquery
SELECT *
FROM Orders
WHERE CustomerID = (SELECT CustomerID
                    FROM Customers
                    WHERE CompanyName = 'Que Delícia')

-- 1c. All employees from London (UK).
SELECT *
FROM Employees
WHERE City = 'London' AND Country = 'UK'
