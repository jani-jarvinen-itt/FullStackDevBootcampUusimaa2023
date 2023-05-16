import sqlite3

def list_finnish_customer(con):
    cur = con.cursor()
    cur.execute("SELECT CompanyName FROM Customers WHERE Country = 'Finland'")

    rows = cur.fetchall()
    for row in rows:
        print(row[0])


print("Starting to access the Northwind sample SQLite database.")
con = sqlite3.connect("..\\Databases\\northwind.db")

list_finnish_customer(con)

print("End.")
