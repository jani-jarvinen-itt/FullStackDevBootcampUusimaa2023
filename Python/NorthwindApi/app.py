from flask import Flask, Response, request
app = Flask(__name__)

@app.route("/")
def hello():
    return "<html>Northwind Web API version 1.0</html>"


@app.route("/api/customers")
def list_customer():
    json = '{ "status": "OK" }'
    return Response(json, mimetype='application/json')
