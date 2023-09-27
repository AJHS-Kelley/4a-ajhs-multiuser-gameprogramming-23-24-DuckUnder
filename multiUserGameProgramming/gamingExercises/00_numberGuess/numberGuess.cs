// Amos Rains, Number Guess, v0.2
/*
Generate scecret number from a defined range of numbers (i.e. 0-10, 0-50, 0-100)
Print game instructions inculding range and num. of guesses allowed.
    MATCH == first player to score 3 points.
    ROUND == guessinf a specific number, until correct or no more attempts
Ask the player what difficulty they want to play on. 
Ask the player what their guess is. 
Determine if Guess is correct or not. 
    If guess is correct {
        Tell theme they have guessed correctly. 
        Award the player a point. 
    } else {
        Tell them they are wrong. 
        Tell player if guess is too high or too low.
        Check to see how many guesses they have remaining {
            if guess remain: {
                allow player to gyess again
            } else {
                CPU wins the round.
            }

        }


*/
using System;

namespace numberGuess
{
    class numberGuess
    {
        static void Main(string[] args)
        {
            int scecretNumber = -1;
            int numberGuesses = 0; // Number of guesses player is ALLOWED.
            int numAttempts = 0; // Number of guesses TAKEN. 
            int playerScore = 0;
            int cpuScore = 0;
            string difficulty = "";
            int rangeMin = -1;
            int rangeMax = -1;

            Console.WriteLine("Welcome to the my Number Guessing Game! My name is Numby!\nYou well select a difficultly setting for me!\n");
            Console.WriteLine("Easy Numby: Range is 0 - 10 with 4 guesses.\nNormal Numby: Range is 0 - 25 with 3 guesses.\nHard Numby: Range is 0 - 50 with 2 guesses.\n Impossible Numby: 0 - 100 with 1 guess.");

            // DIFFICULTLY SELECTION 
            Console.WriteLine("Please type Easy Numby, Normal Numby, Hard Numby, or Impossible Numby and Press Enter.");
            difficulty = Console.ReadLine();
            // Console.ReadLine() will save to STRING by default. 
            Console.WriteLine("You have selected: " + difficulty);
            if (difficulty == "Easy Numby") {
                rangeMin = 0;
                rangeMax = 10;
                numberGuesses = 4;

            } else if (difficulty == "Normal Numby") {
                rangeMin = 0;
                rangeMax = 25;
                numberGuesses = 3;
 
            } else if (difficulty == "Hard Numby") {
                rangeMin = 0;
                rangeMax = 50;
                numberGuesses = 2;
            } else if (difficulty == "Impossible Numby") {
                rangeMin = 0;
                rangeMax = 100;
                numberGuesses = 1;
            } else {
                rangeMin = 0;
                rangeMax = 25;
                numberGuesses = 3;
            }
            Console.WriteLine("Minimum: " + rangeMin);
            Console.WriteLine("Maximum: " + rangeMax);
            Console.WriteLine("Num. Guesses: " + numberGuesses);
        }
    }   
}