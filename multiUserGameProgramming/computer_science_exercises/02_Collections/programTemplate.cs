//Amos Rains, 02_Collections, v0.1c
using System;

namespace UPDATEFOREACHPROGRAM 
{
    class UPDATEFOREACHPROGRAM
    {
        static void Main(string[] args)
        {
            // Collections are variables that can store multiple values in one variable.

            /* Arrays
            -- Number of elements in an array CONNOT change.
            -- Contents of elements in an array CAN change.
            -- Items in the array are called ELEMENTS. 
            -- Arrays are ordered, meaning each item has a fixed position. 
            -- The position is knwon as the INDEX.
            -- First element in an array is index 0.
            */

            // Declaring and defining an Array 
            string[] breakfastFoods = {"Bacon", "Waffles", "Pancakes", "Cereal", "Parfait"};
            int[] testScores = {95, 100, 25, 15, 27, 35};
            float[] GPA = {3.14f, 2.25f, 1.74f, 1.99f, 0.99f, 4.25f};

            // Print Array Contents -- All Elements on Single Line
            Console.WriteLine("The element for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + string.Join(", ", breakfastFoods));
            Console.WriteLine();
            Console.WriteLine("testScores: \n" + string.Join(", ", testScores));
            Console.WriteLine();
            Console.WriteLine("GPA: \n" + string.Join(", ", GPA));
            Console.WriteLine();

            /* Print Array Contents -- Each Element on Separate Line 
            Console.WriteLine("The element for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + string.Join("\n", breakfastFoods));
            Console.WriteLine();
            Console.WriteLine("testScores: \n" + string.Join("\n", testScores));
            Console.WriteLine();
            Console.WriteLine("GPA: \n" + string.Join("\n", GPA));
            Console.WriteLine();
            */








        }
    }   
}
