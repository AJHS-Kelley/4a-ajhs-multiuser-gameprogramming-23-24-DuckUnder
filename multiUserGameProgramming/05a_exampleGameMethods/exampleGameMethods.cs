// Amos Rains, Example Game Methods, v0.3
using System;

namespace exampleGameMethods
{
    class exampleGameMethods
    {
        static string callouts()
        {
            string[] callouts = {"pass", "ball", "shoot"};
            bool valid = false
            string playerCallout = Console.ReadLine().ToLower();
            while (true)
            {
                for (int i = 0; i < callouts.length; i++)
                {
                    
                }
            }



            return playerCallout;
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

        static void getBall()
        {
        string[] passingCallOuts = { "Ball!", "Pass!", "Rock Me!", "Hand Here!" };
            if (ballInHands() == false && Array.Exists(passingCallOuts, call => call == Console.ReadLine()))
            {
                Console.WriteLine("You have finally gotten the ball in your hands. What are you gonna do with it?\n");
            }
            else if (ballInHands() == true && Array.Exists(passingCallOuts, call => call == Console.ReadLine()))
            {
                Console.WriteLine("You already have the ball?? Why are you asking for the Ball you weirdo??");
            }
            else
            {
                Console.WriteLine("What are you waiting for?? DO SOMETHING????");
            }
        }

        static void Main(string[] args)
        {
            getBall();
        }
    }
}

// Code Review Amarion
// New test