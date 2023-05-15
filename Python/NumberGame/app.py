from flask import Flask, Response
import random

app = Flask(__name__)
correct = 0

@app.route("/")
def hello():
    return "<html>Number Guessing Game API version 1.0</html>"

@app.route("/api/startGame")
def start_game():
    correct = random.randint(1, 20)
    print(correct)
    json = '{ "status": "Game started." }'
    return Response(json, mimetype='application/json')
