from flask import Flask, Response, request
import random

app = Flask(__name__)
correct = 0


@app.route("/")
def hello():
    return "<html>Number Guessing Game API version 1.0</html>"


@app.route("/api/startGame")
def start_game():
    global correct
    correct = random.randint(1, 20)
    print("Game started, correct number is: " + str(correct))
    json = '{ "status": "Game started." }'
    return Response(json, mimetype='application/json')


@app.route("/api/checkGuess")
def check_guess():
    global correct
    guess = int(request.args.get('guess', '0'))
    # print(guess)

    statusText = ""
    if (guess == correct):
        statusText = "Correct! You win the game!"
    elif (guess < correct):
        statusText = "The correct number is larger."
    else:
        statusText = "The correct number is smaller."

    json = '{ "guess": "' + str(guess) + '", "status": "' + statusText + '" }'
    return Response(json, mimetype='application/json')
