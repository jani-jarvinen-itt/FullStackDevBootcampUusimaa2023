const sqlite3 = require('sqlite3');
const db = new sqlite3.Database('../Databases/northwind.db');

const sql = "SELECT * FROM Customers WHERE Country = 'Finland'";
db.all(sql, (err, rows) => {

    rows.forEach(row => {
        console.log(row.CompanyName);
    });
});
