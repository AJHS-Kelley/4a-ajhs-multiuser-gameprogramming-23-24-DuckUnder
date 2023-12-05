// Amos Rains, Methods Parameters, v0.5
using System;

namespace MethodsParameters
{
    class MethodsParameters
    {
        // METHOD -- named block of code, can be used over and over. 
        // All methods have a SIGNATURE  that defines their name, parameters, and output. 
        // Example signature
        static void myMethod()
        {
            Console.WriteLine("I like mine with peperoni, olives, and lots of cheese.\n");
        }
        // static -- This method belongs to the current class, it is not a object.
        // void -- This method has no return value. 

        static int DoubleUp()
        {
            int sum = 0; 
            Console.WriteLine("This method will double a number and return it.\n");
            Console.WriteLine("Please enther a number on the next line.\n");
            sum = System.Convert.ToInt32(Console.ReadLine());
            //sum = sum * 2;
            //Console.WriteLine(sum);
            return sum;
        }

        // Methods with Parameters
        
        static void MakePancakes(int num)
        {
            for (int i = 0; i < num; i++) 
            {
                Console.WriteLine("One golden, fluffy pancake coming up!\n");
            }
        }

        static void MakeEggs (int num, string style)
        {
            Console.WriteLine("You have ordered " + num + " eggs cooked " + style + ".\n");
            Console.WriteLine("Order coming right UP!!");
        }
        
        static void MakeBurger(int num = 1)
        {
            Console.WriteLine("I am to cook " + num + " Hamburgers.\n");
        }

        // Named Arguments 
        static void AllMyChildren(string child1, string child2, string child3)
        {
            Console.WriteLine("My favorite child is " + child3);
        }

        // METHOD OVERLOADING
        static int FindSum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Sum: " + sum);
            return sum;
        }

        // Find Sum of Double
        static double FindSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine("Sum: " + sum);
            return sum;
        }

        static void Main(string[] args)
        {
            //myMethod();
            //DoubleUp();
            //MakePancakes(10);
            //MakeEggs(10, "Brunt");
            //MakeBurger();
            //MakeBurger(10);
            //AllMyChildren(child1: "Steve", child2: "Susan", child3: "Chewbacca");
            FindSum(1, 5);
            FindSum(9.5, 2.4);
            FindSum(5, 2.5);
        }
    }   
}
