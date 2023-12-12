// Amos Rains, Example Game Methods, v0.6
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
            string[] commands = {"pass", "ball", "shoot", "y", "n", "quit"};
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
        static int rollDice(int diceNum = 4)
        {
            // Roll a 1d(diceNum)
            int num;
            Random rndNum = new Random();
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
        static void passBall(bool success)
        {
            if (success == true)
            {
                Console.WriteLine("You passed the ball to your teammate\nYou no longer have the ball");
            } else
            {
                Console.WriteLine("You threw the ball too far stupid!!");
            }
        }
        static bool getBall(bool success)
        {
            if (success == true)
            {
                Console.WriteLine("You have finally gotten the ball in your hands. What are you gonna do with it?");
            } else
            {
                Console.WriteLine("You missed the catch you idiot! Ask for the ball again!");
            }
            return success;
        }
        static void shootBall(bool success)
        {
            if (success == true)
            {
                Console.WriteLine("You made the shot! You're the GOAT!");
            } else
            {
                Console.WriteLine("You missed the shot you idiot! Ask for the ball again!");
            }
        }
        static void Main(string[] args)
        {
            bool hasBall = true;
            // While loop keeps the game going until break
            while (true)
            {
                Console.WriteLine("\nChoose your command! (ball/pass/shoot/quit).");
                string playerInput = commandsMethod();
                if (playerInput == "pass")
                {
                    if (hasBall == true)
                    {
                        Console.WriteLine("You are about to pass the ball to your teammate.");
                        Console.WriteLine("Are you ready? (y/n).");
                        playerInput = commandsMethod();
                        if (playerInput == "y")
                        {
                            passBall(compareDice(rollDice(6)+2,rollDice(6)));
                        } else
                        {
                            passBall(false);
                        }
                        hasBall = false;
                    } else
                    {
                        Console.WriteLine("You do not have the Basketball in your hands, ask for the ball.");
                    }
                } else if (playerInput == "ball")
                {
                    if (hasBall == true)
                    {
                        Console.WriteLine("You already have the ball?? Why are you asking for the Ball you weirdo??");
                    } else
                    {
                        Console.WriteLine("Your teammate is about to pass you the ball.");
                        Console.WriteLine("Are you ready? (y/n).");
                        playerInput = commandsMethod();
                        if (playerInput == "y")
                        {
                            hasBall = getBall(compareDice(rollDice(6)+1,rollDice(6)));
                        } else
                        {
                            hasBall = getBall(false);
                        }
                    }
                } else if (playerInput == "shoot")
                {
                    if (hasBall == true)
                    {
                        Console.WriteLine("You are about to shoot the ball to the goal.");
                        Console.WriteLine("Are you ready? (y/n).");
                        playerInput = commandsMethod();
                        if (playerInput == "y")
                        {
                            shootBall(compareDice(rollDice(6),rollDice(6)));
                        } else
                        {
                            shootBall(false);
                        }
                        hasBall = false;
                    } else
                    {
                        Console.WriteLine("You do not have the Basketball in your hands, ask for the ball.");
                    }
                } else if (playerInput == "y")
                {
                    Console.WriteLine("The heck are you saying yes too???");
                } else if (playerInput == "n")
                {
                    Console.WriteLine("The heck are you saying no too???");
                } else if (playerInput == "quit")
                {
                    break;
                } else
                {
                    Console.WriteLine("HOW DID YOU END UP HERE!?!?!?");
                }
            }
        }
    }
}

// Code Review Amarion
// New test