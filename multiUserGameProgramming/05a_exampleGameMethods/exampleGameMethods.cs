// Amos Rains, Example Game Methods, v0.3
using System;
using System.Linq;

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
            // getBall();
            commandsMethod();
            // string test = "pass";
            // string[] things = {"pass", "lol", "dumb"};
            // // Console.WriteLine(things.Any(test.Contains));
            // bool b = things.Any(test.Contains);
            // Console.WriteLine(b);

            while (true)
            {

            }
        }
    }
}

// Code Review Amarion
// New test