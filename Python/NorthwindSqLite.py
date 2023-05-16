import sqlite3

print("Starting to access the Northwind sample SQLite database.")
con = sqlite3.connect("..\\Databases\\northwind.db")

cur = con.cursor()
cur.execute("SELECT * FROM Customers WHERE Country = 'Finland'")

rows = cur.fetchall()
for row in rows:
    print(row)

print("End.")
