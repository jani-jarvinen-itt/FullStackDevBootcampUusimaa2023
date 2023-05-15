from flask import Flask, Response

app = Flask(__name__)

@app.route("/")
def hello():
    return "<html>Number Guessing Game API version 1.0</html>"

@app.route("/api/startGame")
def start_game():
    json = '{ "status": "Game started." }'
    return Response(json, mimetype='application/json')
