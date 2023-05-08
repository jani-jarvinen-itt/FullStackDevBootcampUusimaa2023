const sqlite3 = require('sqlite3');
const db = new sqlite3.Database('../Databases/northwind.db');

listFinnishCustomers();
listLondonEmployees();
listTofuSales();

function listFinnishCustomers() {
    const sql = "SELECT * FROM Customers WHERE Country = 'Finland'";
    db.all(sql, (err, rows) => {

        rows.forEach(row => {
            console.log(row.CompanyName);
        });
    });
}

function listLondonEmployees() {
    const sql = "SELECT * FROM Employees WHERE City = 'London'";
    db.all(sql, (err, rows) => {

        rows.forEach(row => {
            console.log(row.FirstName + " " + row.LastName);
        });
    });
}

function listTofuSales() {
    const sql = `SELECT SUM(UnitPrice * Quantity * (1-Discount)) AS TofuSales
                 FROM [Order Details]
                 WHERE ProductID IN (SELECT ProductID
                                     FROM Products
                                     WHERE ProductName LIKE '%Tofu%')`;
    db.all(sql, (err, rows) => {

        rows.forEach(row => {
            console.log(row.TofuSales);
        });
    });
}
