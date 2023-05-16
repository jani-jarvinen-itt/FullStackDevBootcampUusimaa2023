import sqlite3


def list_finnish_customer(con):
    cur = con.cursor()
    cur.execute("SELECT CompanyName FROM Customers WHERE Country = 'Finland'")

    rows = cur.fetchall()
    for row in rows:
        print(row[0])


def export_customers_to_csv_file(con, filename):

    # read the customer data from the SQLite database
    cur = con.cursor()
    cur.execute("SELECT * FROM Customers")
    rows = cur.fetchall()

    # prepare the CSV file for writing
    f = open(filename, "a", encoding="utf8")
    f.write("CustomerId,CompanyName,ContactPerson,Country\n")

    for row in rows:
        # csv_row = row[0] + "," + row[1] + "," + row[2] + "," + row[8] + "\n"
        csv_row = f"{row[0]},{row[1]},{row[2]},{row[8]}\n"
        f.write(csv_row)

    f.close()


print("Starting to access the Northwind sample SQLite database.")
con = sqlite3.connect("..\\Databases\\northwind.db")

list_finnish_customer(con)

export_customers_to_csv_file(con, "Customers.csv")

print("End.")
