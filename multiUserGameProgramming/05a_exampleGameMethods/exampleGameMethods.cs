// Amos Rains, Example Game Methods, v0.4
using System;
using System.Linq;

// This game is about training the player when it comes to handling a basketball in game
// The game mainly uses 2d8 for each action
// If the first dice will be compared to the second to determine the success of an action

namespace exampleGameMethods
{
    class exampleGameMethods
    {
        static string commandsMethod()
        {
            string[] commands = {"pass", "ball", "shoot"};
            string playerInput = Console.ReadLine().ToLower();
            while (true)
            {
                if (commands.Any(playerInput.Contains) == true)
                {
                    break;
                } else
                {
                    Console.WriteLine("That's not a command?? Try again!");
                    playerInput = Console.ReadLine().ToLower();
                }
            }
            return playerInput;
        }
        static void passBall()
        {
            
        }
        static int rollDice(int diceNum = 4)
        {
            // Roll a 1d(diceNum)
            int num;
            Random num = new Random();
            num = rndNum.Next(1, diceNum);
            Console.WriteLine(num);
            return num;
        }
        static bool compareDice(int num1, int num2)
        {
            // If first number is greater than second number, player succeeds
            bool success = false;
            if (num1 > num2)
            {
                success = true;
            }
            return success;
        }
        static bool ballInHands()
        {
            bool playerWithBall = false;
            if (playerWithBall == false)
            {
                Console.WriteLine("You do not have the Basketball in your hands ask for the ball.\n");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You have the ball in your hands what do you want to do with it?\n");
            }
            return playerWithBall;
        }

        // static void getBall()
        // {
        // string[] passingCallOuts = { "Ball!", "Pass!", "Rock Me!", "Hand Here!" };
        //     if (ballInHands() == false && Array.Exists(passingCallOuts, call >= call == Console.ReadLine()))
        //     {
        //         Console.WriteLine("You have finally gotten the ball in your hands. What are you gonna do with it?\n");
        //     }
        //     else if (ballInHands() == true && Array.Exists(passingCallOuts, call >= call == Console.ReadLine()))
        //     {
        //         Console.WriteLine("You already have the ball?? Why are you asking for the Ball you weirdo??");
        //     }
        //     else
        //     {
        //         Console.WriteLine("What are you waiting for?? DO SOMETHING????");
        //     }
        // }

        static void Main(string[] args)
        {
            commandsMethod();
            while (true)
            {

            }
        }
    }
}

// Code Review Amarion
// New test