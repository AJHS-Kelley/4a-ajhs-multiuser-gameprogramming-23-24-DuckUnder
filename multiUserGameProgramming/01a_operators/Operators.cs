// Amos Rains, Operators, v0.4
using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // create TWO Strings, Interger, and Float variables. 
            
            int myDogAge = 4;
            int myFootballYears = 7;

            string myPizza = "My Pizza will arrive at 10:30 PM.";
            string myGame = "The Football game will start at 8:00 PM.";

            float amountOfMilk = 0.34F;
            float amountWater = 2.76F;
            
            // Arithemic Operators
            Console.WriteLine(myDogAge + myFootballYears);
            //  Console.WriteLine(myPizza + myGame);
            Console.WriteLine(amountOfMilk + amountWater);
            // Console.WriteLine(myDogAge + amountWater);
            
            Console.WriteLine(myDogAge * myFootballYears);
            // Console.WriteLine(myPizza * myGame);
            Console.WriteLine(amountOfMilk * amountWater);
            // Console.WriteLine(myDogAge * amountWater);

            Console.WriteLine(myDogAge / myFootballYears);
            // Console.WriteLine(myPizza / myGame);
            Console.WriteLine(amountOfMilk / amountWater);
            // Console.WriteLine(myDogAge / amountWater);

            Console.WriteLine(myDogAge - myFootballYears);
            // Console.WriteLine(myPizza - myGame);
            Console.WriteLine(amountOfMilk - amountWater);
            // Console.WriteLine(myDogAge - amountWater);

            // Modulus 
            Console.WriteLine(10 % 2);
            Console.WriteLine(9 % 4);
            
            // Increment
            int increaseIt = 1;
            myDogAge++;
            Console.WriteLine(myDogAge);

            Console.WriteLine("");

            // Decrement 
            int decreaseIt = 2;
            myFootballYears--;
            Console.WriteLine(myFootballYears);

            // Assignment Operators
            // =
            // = THIS ASSIGNMENT OPERATOR THROWS OUT OLD VALUES 
            
            // These Assignment Operators Keep old Values!!

            // +=
            // -=
            // *=
            // /=

            // Comparison Operators 
            // Is Equal To 
            // Greater Than 
            // Greater Than or Equal To 
            // Less Than 
            // Less Than or Equal To 
            // Not Equal To 

            // Logical Operators 
            // And 
            // Or 
            // Not 

            int int1 = 1;
            int int2 = 2; 

            Console.WriteLine(int1 = int1);
            Console.WriteLine(int2 += int1);
            Console.WriteLine(int1 -= int2);
            Console.WriteLine(int2 *= int1);
            Console.WriteLine(int1 /= int2);

            Console.WriteLine("");

            int a = 1;
            int b = 2*2;
            int c = 10/2; 

            Console.WriteLine(a == b); 
            Console.WriteLine(c > b); 
            Console.WriteLine(b >= a); 
            Console.WriteLine(a < c);
            Console.WriteLine(a <= a);
            Console.WriteLine(c != b);

            Console.WriteLine("");

            int x = 10;
            int y = 20;

            bool result = (x > y) && (x == 10); 

            Console.WriteLine("And Operator: " + result);

            bool result2 = (y > x) || (y > 30); 

            Console.WriteLine("Or Operator: " + result2);

            bool result3 = !(x == y);

            Console.WriteLine("Not Operator: " + result3);
        }
    }



    
}
