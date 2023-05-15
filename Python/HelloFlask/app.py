from flask import Flask

app = Flask(__name__)

@app.route("/")
def hello():
    return "<html>Hello, <b>World!</b></html>"

@app.route("/numbers")
def numbers():
    return "<html>These are your lottery numbers: 2, 5, 17, 21, 22, 31, 34</html>"
