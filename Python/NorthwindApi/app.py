import sqlite3
from flask import Flask, Response, request, jsonify
app = Flask(__name__)


@app.route("/")
def hello():
    return "<html>Northwind Web API version 1.0</html>"


@app.route("/api/customers")
def list_customer():
    # myData = ("companyname", "country", 123.45)
    # thisdict = {
    #    "brand": "Ford",
    #    "model": "Mustang",
    #    "year": 1964
    # }

    # read the customer data from the SQLite database
    con = sqlite3.connect("..\\..\\Databases\\northwind.db")
    cur = con.cursor()
    cur.execute("SELECT * FROM Customers")
    rows = cur.fetchall()

    all_customer = []

    for row in rows:
        customer_dict = {
            "customerId": row[0],
            "companyName": row[1],
            "contactPerson": row[2],
            "country": row[8]
        }
        all_customer.append(customer_dict)

    return jsonify(all_customer)
