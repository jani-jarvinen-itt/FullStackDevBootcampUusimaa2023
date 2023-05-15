import random

print("Welcome to the Number Guessing Game!")

# select random number 1-20
correct = random.randint(1, 20)
print(correct)

for round in range(3):
    # ask the player for a guess
    guess_value = input("Please enter your guess between 1 and 20: ")
    guess = int(guess_value)

    print("You guessed: " + str(guess))

print("Game ends.")
