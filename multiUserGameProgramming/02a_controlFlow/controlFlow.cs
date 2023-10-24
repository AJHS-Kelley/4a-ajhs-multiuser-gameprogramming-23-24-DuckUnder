// Amos Rains, Program Template, v0.3
using System;

namespace UPDATEFOREACHPROGRAM 
{
    class UPDATEFOREACHPROGRAM
    {
        static void Main(string[] args)
        {
            /*    // DECLARATIONS 
                string favColor = "Onyx";
                int luckyNumber = 8;
                float myGPA = 3.79F;
                int myAge = 17;
                bool pineappleOnPizza = true; 
            
                // if Statements -- Checks for a single condition!
                if (favColor == "Green") {
                    Console.WriteLine("Green with Envy!");
            }
                if (myAge == 17) {
                    Console.WriteLine("1 More year until you graduate.");
                
            }
        
            // if - else Statement -- Checks for a single condition, but has two
            if (myAge > 15) {
                Console.WriteLine("You are eligible to drive a car.");
            } else {
                Console.WriteLine("START WALKING SCRUB!");
            }
        
            // if -- else if -- else - Checks multiple outcomes. 
            if (myGPA == 4.00F) {
                Console.WriteLine("Congrats on straight A grades!");
            } else if (myGPA >= 3.0F) {
                Console.WriteLine("Congrats on making the honor roll!");
            } else if (myGPA >= 2.0F) {
                Console.WriteLine("You are graduation ready!");
            }else {
                Console.WriteLine("You should probably study!");
            }
            // WHEN CHECKING NUMBER VALUES, START WITH THE HIGHEST VALUE!!!!
        
            // Nested Statement
            if (pineappleOnPizza == true) {
                Console.WriteLine("Ew that's gross. You must be a boomer. How old are you?");
                if (myAge > 60) {
                Console.WriteLine("Just as I suspected! What was it like having a dinosaur growing up?");
                } else {
                    Console.WriteLine("Ok, so you're not a boomer but still have no taste in food.");
                }
            
            } else {
                Console.WriteLine("Glad to see you have common sense!");
            }

            // for Loop -- Best for when you know # of iterations needed. 
            /* 
            for (statement1; statement2; statement3) {
            code to loop.
            }
            statement1 is excuted ONCE BEFORE the loop starts. 
            statement2 is a CONDITIONAL that is checked EVERYTIME BEFORE loop starts. 
            statement3 is excuted EVERYTIME after the loop excutes. 
            /

            for (int i = 0; i < 101; i++) {
                Console.WriteLine("" + i);
            }

            // Create your own loop that counts down from 100 to 0.
            for (int i = 100; i <= 0; i--) {
                Console.WriteLine("" + i);
            }

            //Nested loops 
            // Outer Loop
            //for (int j = 1; j <= 2; j++){
            //    Console.WriteLine("Outer: " + 1);

            /    for (int j = 1; j <= 3; i++); {
                    Console.WriteLine("Inner: " + j);
                }
            }
            */
            // while loop -- Best when # of iterations needed is unknown 
            int x = 0;
            while (x < 1000) {
                Console.WriteLine("" + x);
                x++;
            }

            // Special Keywords 
            // break will immediately exit a LOOP or an IF/ELSE or an IF/ELSE IF/ELSE block. 
            for (int i = 0; i < 101; i++) {
                Console.WriteLine("" + i);
                if (i == 50) {
                    break;
                }
            }

            // continue will SKIP the current iteration and then finish the loop. 
            for (int i = 0; i < 101; i++) {
                Console.WriteLine("" + i);
                if (i == 50);
                continue;
            }

        }
    }
}

