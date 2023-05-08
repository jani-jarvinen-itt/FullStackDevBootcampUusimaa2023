// preparation for reading a SQLite database and the command-line
const sqlite3 = require('sqlite3');
const readline = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout,
});

// define where the SQLite database exists
const db = new sqlite3.Database('../Databases/northwind.db');

readline.question(`Please select your choice:

1. List Finnish customers
2. List London employees
3. List Tofu sales.

Please enter your choice (1-3): `, choice => {
    console.log(`You selected choice ${choice}.`);
    readline.close();

    switch (choice) {
        case "1":
            listFinnishCustomers();
            break;
        case "2":
            listLondonEmployees();
            break;
        case "3":
            listTofuSales();
            break;
    }
});

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
